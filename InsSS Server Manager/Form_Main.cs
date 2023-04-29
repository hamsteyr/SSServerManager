using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Configuration;
using IniParser;
using IniParser.Model;

namespace InsSS_Server_Manager
{
    public partial class Form_Main : Form
    {
        List<MapType> mapList;
        public List<MutatorType> mutatorList { get; set; }
        public List<ModType> modList { get; set; }
        string exePath;
        string cfgDir;
        string iniDir;

        private ProcessStartInfo InsSS_Server= new ProcessStartInfo();
        private Action action;

        //int selectedMap = 0;
        MapType selectedMap;
        int mapScenarioIndex;
        string lighting;

        // modlist
        string modsListString = "";

        // ini data parser
        FileIniDataParser parser = new FileIniDataParser();
        IniData data;

        public Form_Main()
        {
            InitializeComponent();
            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            label_version.Text = "v" + Application.ProductVersion;

            tabControl1.TabPages[1].Enabled = false;
            LoadData();

            // set default values
            listBox_scenario.SelectedIndex = 0;
            listBox_map.SelectedIndex = 0;
            radioButton1.Checked = true;
            mapScenarioIndex = listBox_scenario.SelectedIndex;
        }

        /* Read any saved user settings and load/ process them as needed */
        private void LoadData()
        {
            string settings = "";
            SaveDataType savedData;

            //string saveDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Application.ProductName); // Local AppData Folder 
            string saveDir = System.Reflection.Assembly.GetExecutingAssembly().Location; // get exe location
            saveDir = Path.GetDirectoryName(saveDir); // get path only of exe

            /* load data from JSON, if JSON doesn't exist, make empty data file */
            if (File.Exists(Path.Combine(saveDir, "settings.json")))
            {
                settings = File.ReadAllText(Path.Combine(saveDir, "settings.json"));
                savedData = JsonConvert.DeserializeObject<SaveDataType>(settings);
            }
            else
            {
                savedData = new SaveDataType();
            }

            textBox_GameStats.Text = savedData.stringData.GameStat;
            textBox_GLST.Text = savedData.stringData.GLST;
            textBox_Password.Text = savedData.stringData.password;


            /* Directory */
            if (savedData.stringData.serverDir != "")
                textField_server.Text = savedData.stringData.serverDir;

            if (File.Exists(textField_server.Text)) // if directory is valid then process it to load all the variables in so that they're not empty.
            {
                ValidDir();
            }

            RestoreModList(savedData);
            RestoreMutatorList(savedData);
            PopulateScenarios();
            RestoreMapList(savedData);
        }

        /* Game.ini Read */
        private void ReadGameIni()
        {
            data = parser.ReadFile(Path.Combine(iniDir, "Game.ini"));

            textBox_serverName.Text = data["/Script/Insurgency.INSGameMode"]["ServerHostname"];

            textBox_maxPlayers.Text = data["/Script/Engine.GameSession"]["MaxPlayers"];

            textBox_aiDifficulty.Text = data["/Script/Insurgency.INSCoopMode"]["AIDifficulty"];
            textBox_maxBots.Text = data["/Script/Insurgency.INSCoopMode"]["MaximumEnemies"];
            textBox_minBots.Text = data["/Script/Insurgency.INSCoopMode"]["MinimumEnemies"];
        }

        private void WriteGameIni()
        {
            if (data == null)
                return;

            data["/Script/Insurgency.INSGameMode"]["ServerHostname"] = textBox_serverName.Text;
            data["/Script/Engine.GameSession"]["MaxPlayers"] = textBox_maxPlayers.Text;
            data["/Script/Insurgency.INSCoopMode"]["AIDifficulty"] = textBox_aiDifficulty.Text;
            data["/Script/Insurgency.INSCoopMode"]["MaximumEnemies"] = textBox_maxBots.Text;
            data["/Script/Insurgency.INSCoopMode"]["MinimumEnemies"] = textBox_minBots.Text;
            parser.WriteFile(Path.Combine(iniDir, "Game.ini"), data);
        }

        private void ID_NumberFilter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // intercept if it's not a digit or a control character.
        }

        private void ID_FloatFilter(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }


        /* Mod List */
        private void RestoreModList(SaveDataType savedData)
        {
            modList = new List<ModType>();

            if (savedData.modList != null) // if not empty
                foreach (ModType mod in savedData.modList)
                {
                    modList.Add(mod);
                }
        }

        /* Mutator List */
        private void RestoreMutatorList(SaveDataType savedData)
        {
            mutatorList = new List<MutatorType>();

            if (savedData.mutatorList != null) // if not empty
            {
                foreach (MutatorType mutator in savedData.mutatorList)
                {
                    mutatorList.Add(mutator);
                }
            }
            else // fill with default mutators
            {
                PopulateDefaultMutators();
            }
        }

        public void PopulateScenarios()
        {
            listBox_scenario.Items.Clear(); // clear existing list

            string[] scenarioList = Enum.GetNames(typeof(ScenarioType.scenarioCat)); // get list from ScenarioType Class

            foreach (string name in scenarioList)
                listBox_scenario.Items.Add(name.Replace('_', ' '));
        }

        private void RestoreMapList(SaveDataType savedData)
        {
            /* Problematic as if later maps are added, even though they're in program code, they don't appear in app because it always loads the old one 
                Needs to split in between user added maps and always populating the default maps */

            mapList = new List<MapType>();

            if (savedData.mapList != null) // if not empty
            {
                foreach (MapType map in savedData.mapList)
                {
                    mapList.Add(map);
                }
            }
            else // fill with default maps
            {
                PopulateDefaultMaps();
            }
        }

        private MapType AddMap(string mapName, string scenarioName)
        {
            MapType newMap = new MapType(mapName, MapType.mapCat.Official, scenarioName);
            mapList.Add(newMap); // add into internal list
            listBox_map.Items.Add(scenarioName);

            return newMap;
        }

        private void PopulateDefaultMaps()
        {
            // init map list.
            mapList = new List<MapType>();
            MapType map;

            // add default maps
            map = AddMap("Canyon", "Crossing");
            map.RemoveScenario(ScenarioType.scenarioCat.Firefight_East);
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map.RemoveScenario(ScenarioType.scenarioCat.Survival);
            map = AddMap("Farmhouse", "Farmhouse");
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map = AddMap("Mountain", "Summit");
            map.RemoveScenario(ScenarioType.scenarioCat.Domination);
            map = AddMap("OilField", "Refinery");
            map.RemoveScenario(ScenarioType.scenarioCat.Firefight_East);
            map.RemoveScenario(ScenarioType.scenarioCat.Domination);
            map.RemoveScenario(ScenarioType.scenarioCat.Survival);
            map = AddMap("Precinct", "Precinct");
            map.RemoveScenario(ScenarioType.scenarioCat.Domination);
            map = AddMap("Town", "Hideout");
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map = AddMap("Compound", "Outskirts");
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map.RemoveScenario(ScenarioType.scenarioCat.Domination);
            map = AddMap("Ministry", "Ministry");
            map.RemoveScenario(ScenarioType.scenarioCat.Push_Security);
            map.RemoveScenario(ScenarioType.scenarioCat.Push_Insurgents);
            map.RemoveScenario(ScenarioType.scenarioCat.Firefight_West);
            map.SetScenario(ScenarioType.scenarioCat.Firefight_East, "Scenario_Ministry_Firefight_A");
            map.RemoveScenario(ScenarioType.scenarioCat.Frontline);
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map.RemoveScenario(ScenarioType.scenarioCat.Survival);
            map = AddMap("Sinjar", "Hillside");
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map = AddMap("PowerPlant", "PowerPlant");
            map.RemoveScenario(ScenarioType.scenarioCat.Frontline);
            map.RemoveScenario(ScenarioType.scenarioCat.Skirmish);
            map.RemoveScenario(ScenarioType.scenarioCat.Team_Deathmatch);
            map.RemoveScenario(ScenarioType.scenarioCat.Outpost);
            map = AddMap("Tell", "Tell");
            map.RemoveScenario(ScenarioType.scenarioCat.Push_Insurgents);
            map.RemoveScenario(ScenarioType.scenarioCat.Push_Security);
            map.RemoveScenario(ScenarioType.scenarioCat.Skirmish);
            map.RemoveScenario(ScenarioType.scenarioCat.Team_Deathmatch);
            map.RemoveScenario(ScenarioType.scenarioCat.Survival);
            map = AddMap("Bab", "Bab");
            map.RemoveScenario(ScenarioType.scenarioCat.Firefight_West);
            map.RemoveScenario(ScenarioType.scenarioCat.Frontline);
            map.RemoveScenario(ScenarioType.scenarioCat.Skirmish);
            map.RemoveScenario(ScenarioType.scenarioCat.Team_Deathmatch);
            map.RemoveScenario(ScenarioType.scenarioCat.Survival);
            map = AddMap("Citadel", "Citadel");
            map.SetScenario(ScenarioType.scenarioCat.Hardcore_CP_Insurgents, "Scenario_Citadel_Hardcore_Checkpoint_Insurgents");
            map.SetScenario(ScenarioType.scenarioCat.Hardcore_CP_Security, "Scenario_Citadel_Hardcore_Checkpoint_Security");
            map.SetScenario(ScenarioType.scenarioCat.Firefight_East, "Scenario_Citadel_Firefight");
            map.RemoveScenario(ScenarioType.scenarioCat.Firefight_West);
            map = AddMap("Gap", "Gap");
            map.RemoveScenario(ScenarioType.scenarioCat.Hardcore_CP_Insurgents);
            map.RemoveScenario(ScenarioType.scenarioCat.Hardcore_CP_Security);
            map.RemoveScenario(ScenarioType.scenarioCat.Skirmish);
            map.RemoveScenario(ScenarioType.scenarioCat.Team_Deathmatch);
            map.SetScenario(ScenarioType.scenarioCat.Firefight_East, "Scenario_Gap_Firefight");
            map.RemoveScenario(ScenarioType.scenarioCat.Firefight_West);
        }

        private void PopulateDefaultMutators()
        {
            mutatorList.Add(new MutatorType("AllYouCanEat", "All You Can Eat Start with 100 supply points.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("AntiMaterielRiflesOnly", "Anti - Materiel Only Only anti - materiel rifles are available along with normal equipment and explosives.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("BoltActionsOnly", "Bolt - Actions Only Only bolt - action rifles are available along with normal equipment and explosives.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Broke", "Broke Start with 0 supply points.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("BulletSponge", "Bullet Sponge Health is increased.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Competitive", "Competitive Equipment is more expensive, rounds are shorter, and capturing objectives is faster.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("CompetitiveLoadouts", "Competitive Loadouts Player classes are replaced with those from Competitive.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("FastMovement", "Fast Movement Move faster.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Frenzy", "Frenzy Fight against AI enemies who only use melee attacks.Watch out for special enemies.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Guerrillas", "Guerrillas Start with 5 supply points.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Hardcore", "Hardcore Mutator featuring slower movement speeds and longer capture times.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("HeadshotOnly", "Headshots Only Players only take damage when shot in the head.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("HotPotato", "Hot Potato A live fragmentation grenade is dropped on death.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("LockedAim", "Locked Aim Weapons always point to the center of the screen.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("LowGravity", "Low Gravity Float when jumping or falling, and shoot while midair.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("NoAim", "No Aim Down Sights Aiming down sights is disabled.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("PistolsOnly", "Pistols Only Only pistols are available along with normal equipment and explosives.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("ShotgunsOnly", "Shotguns Only Only Shotguns are available along with normal equipment and explosives.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("SlowCaptureTimes", "Slow Capture Times Objectives will take longer to capture.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("SlowMovement", "Slow Movement Move slower.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("SoldierOfFortune", "Soldier of Fortune Gain supply points as your score increases.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("SpecialOperations", "Special Operations Start with 30 supply points.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Strapped", "Strapped Start with 1 supply point.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Ultralethal", "Ultralethal Everyone dies with one shot.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Vampirism", "Vampirism Receive health when dealing damage to enemies equal to the amount of damage dealt.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Warlords", "Warlords Start with 10 supply points.", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("OfficialRules", "- ruleset = OfficialRules is now - mutators =", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("BudgetAntiquing", "This mutator only allows only old, cheap weapons along with normal equipment and explosives", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("NoDrops", "Weapons, explosives, and equipment are not dropped by dead players or enemy AI", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("MakarovsOnly", "Makarov pistols only", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Poor", "Players start with only 2 supply points", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("FullyLoaded", "All weapons, equipment, and explosives in the game are available in the Loadout Menu", MutatorType.mutatorCat.Official));
            mutatorList.Add(new MutatorType("Gunslingers", "Players are equipped with the MR 73 revolver, normal equipment, and explosives", MutatorType.mutatorCat.Official));
        }

        private void OnClick_RandomiseMap(object sender, EventArgs e)
        {
           // Changes the map to a random map and locks the map selector.
            if (checkBox_randomMap.Checked)
            {
                Random rNum = new Random();
                listBox_map.SelectedIndex = rNum.Next(listBox_map.Items.Count);
            }
            listBox_map.Enabled = !listBox_map.Enabled;
        }

        private void OnClick_ServerBrowse(object sender, EventArgs e)
        {
            if (serverBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                textField_server.Text = serverBrowseDialog.FileName;
                ValidDir();
            }
        }

        private void ValidDir()
        {
            exePath = textField_server.Text;
            cfgDir = Path.Combine(Directory.GetParent(exePath).FullName, "Insurgency", "Config", "Server");
            iniDir = Path.Combine(Directory.GetParent(exePath).FullName, "Insurgency", "Saved", "Config", "WindowsServer");
            Directory.CreateDirectory(cfgDir); // creates directory if it doesn't exist

            button_config.Enabled = true;
            button_ini.Enabled = true;
            button_mods.Enabled = true;
            buttonStartServer.Enabled = true;
            tabControl1.TabPages[1].Enabled = true;

            ReadGameIni();
        }

        private void OnClick_ScenarioSelect(object sender, EventArgs e)
        {
            bool startTab = ((ListBox)sender).Name == listBox_scenario.Name;


            ScenarioType.scenarioCat scenarioCat = (ScenarioType.scenarioCat)((ListBox)sender).SelectedIndex; // get scenario category from index

            ListBox mapBox = startTab ? listBox_map : listBox_changeMap;

            Console.WriteLine(((ListBox)sender).Name);

            mapBox.Items.Clear(); // Remove all

            for (int i = 0; i < mapList.Count; i++)
            {
                foreach (ScenarioType scenario in mapList[i].scenarioList)
                {
                    if (scenario.scenarioCategory == scenarioCat)
                    {
                        mapBox.Items.Add(mapList[i].scenarioName);
                    }
                }
            }

            mapBox.SelectedIndex = 0; //default selection
        }

        private void OnClick_MapSelect(object sender, EventArgs e)
        {
            bool startTab = ((ListBox)sender).Name == listBox_map.Name;


            /* find map in list and return it's index */
            for (int i = 0; i < mapList.Count; i++)
            {
                if (mapList[i].scenarioName == ((ListBox)sender).SelectedItem.ToString())
                {
                    selectedMap = mapList[i];

                    for (int x = 0; x < selectedMap.scenarioList.Count; x++)
                    {
                        if (selectedMap.scenarioList[x].scenarioCategory == (ScenarioType.scenarioCat)listBox_scenario.SelectedIndex)
                        {
                            mapScenarioIndex = x;
                        }
                    }
                }
            }
        }

        private void BuildMapCycle()
        {
            string mapText = "";
            //int mapIndex = 0;
            ScenarioType.scenarioCat scenarioCat = (ScenarioType.scenarioCat)listBox_scenario.SelectedIndex; // get scenario category from index
            int scenarioAdditionalCat = -1; // store additional scenario category as type int as it's easier to work with.
            int scenarioTypeIndex = -1;

            /* Go through maplist and add maps with our scenario */
            foreach (MapType map in mapList)
            {
                foreach (ScenarioType scenario in map.scenarioList)
                {
                    if (scenario.scenarioCategory == scenarioCat)
                    {
                        mapText += "(Scenario=\"" + scenario.scenarioLine + "\")" + Environment.NewLine;

                        scenarioTypeIndex = (int)scenario.scenarioCategory;
                    }
                }

                /* check if checkpoint or hc checkpoint, add opposing side as well */
                if (scenarioTypeIndex < 4)
                {
                    if (scenarioTypeIndex % 2 == 0) // if remainder is 0, it means we +1 and add that, else -1. 0 basically means Security Checkpoint or Hardcore Security Checkpoint.
                    {
                        scenarioAdditionalCat = scenarioTypeIndex + 1; // search for the +1 of self and add it e.g. Insurgents Checkpoint or Hardcore Insurgents Checkpoint.
                    }
                    else
                    {
                        scenarioAdditionalCat = scenarioTypeIndex - 1; // search for the -1 of self and add it e.g. Security Checkpoint or Hardcore Security Checkpoint.
                    }
                }

                /* add additional categories */
                if (scenarioAdditionalCat != -1) // check if we even need to add any additional categories.
                {
                    foreach (ScenarioType scenario in map.scenarioList)
                    {
                        if (scenario.scenarioCategory == (ScenarioType.scenarioCat)scenarioAdditionalCat)
                        {
                            mapText += "(Scenario=\"" + scenario.scenarioLine + "\")" + Environment.NewLine;
                        }
                    }
                }
            }

            File.WriteAllText(Path.Combine(cfgDir, "MapCycle.txt"), mapText);
        }

        private string BuildSelectedMutatorList()
        {
            string mutString = "";

            foreach (MutatorType mutator in mutatorList)
            {
                if (mutator.enabled)
                {
                    if (mutString != "") // if string is not empty
                        mutString += ",";

                    mutString += mutator.mutatorName;
                }
            }

            return mutString;
        }

        public void ModMutatorMapUpdate()
        {
            List<MutatorType> removeMutatorArray = new List<MutatorType>();
            List<MapType> removeMapArray = new List<MapType>();

            /* Make a list of mutators to remove */
            for (int i=0; i < mutatorList.Count; i++)
            {
                if (mutatorList[i].category == MutatorType.mutatorCat.Custom)
                    removeMutatorArray.Add(mutatorList[i]);
            }

            /* Remove mutators */
            if (removeMutatorArray.Count != 0)
            {
                foreach (MutatorType customMut in removeMutatorArray)
                {
                    mutatorList.Remove(customMut);
                }
            }

            /* make a list of maps to remove */
            foreach (MapType map in mapList)
            {
                if (map.mapCategory == MapType.mapCat.Custom)
                    removeMapArray.Add(map);
            }

            /* Remove Maps */
            if (removeMapArray.Count != 0)
            {
                foreach (MapType customMap in removeMapArray)
                    mapList.Remove(customMap);
            }

            modsListString = "";

            foreach (ModType mod in modList)
            {
                if (mod.enabled) // if mod is enabled
                {
                    /* Add mutators in */
                    modsListString += mod.modID + Environment.NewLine;

                    foreach (MutatorType mutator in mod.mutators)
                    {
                        mutatorList.Add(mutator);
                    }

                    /* Add Maps in */
                    foreach (MapType customMap in mod.maps)
                    {
                        mapList.Add(customMap);
                    }
                }
            }

            OnClick_ScenarioSelect(listBox_scenario, null); // update the scenario box

            /* Update Mods.txt with active mods */
            File.WriteAllText(Path.Combine(cfgDir, "Mods.txt"), modsListString);

        }

        private void OnClick_StartServer(object sender, EventArgs e)
        {
            if (!File.Exists(exePath))
            {
                MessageBox.Show("Please browse for the Sandstorm server first!", Application.ProductName + " " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            /* disable start server button after server is started */
            buttonStartServer.Text = "Server" + Environment.NewLine + "Running...";
            buttonStartServer.Enabled = false;

            SetServerProcess();
            BuildMapCycle();
            ModMutatorMapUpdate();
            WriteGameIni();

            ScenarioType.scenarioCat s = (ScenarioType.scenarioCat)listBox_scenario.SelectedIndex; // get scenario category
            ScenarioType selectedScenario = selectedMap.scenarioList[mapScenarioIndex];

            string map = selectedMap.mapName + "?Scenario=" + selectedScenario.scenarioLine + "?Lighting=" + lighting + (textBox_Password.Text == "" ? "" : ("?password=" + textBox_Password.Text));
            //s tring map = mapList[selectedMap].mapName + "?Scenario=" + mapList[selectedMap].GetScenario(s) + "?Lighting=" + lighting + (textBox_Password.Text == "" ? "" : ("?password=" + textBox_Password.Text));
            // string mutators = "JoinLeaveMessage";
            string mutators = BuildSelectedMutatorList();

            string args = map + " -log -AdminList=Admins -MapCycle=MapCycle" + (mutators == "" ? "" : (" -mutators=" + mutators)) + " -GameStatsToken=" + textBox_GameStats.Text + " -GameStats -GSLTToken=" + textBox_GLST.Text + (modsListString == "" ? "" : " -Mods -ModDownloadTravelTo=" + map);
            //Console.WriteLine(args);

            /* Start Server Thread */
            backgroundWorker1.RunWorkerAsync(args);
        }

        private void SetServerProcess()
        {
            // This stuff comes first. They then call stuff that's in individual forms. Perhaps I can use this to store variables that are static through the program
            InsSS_Server.FileName = exePath;
            InsSS_Server.UseShellExecute = false;
            InsSS_Server.ErrorDialog = false;
            InsSS_Server.StandardOutputEncoding = System.Text.Encoding.UTF8;

            // set up output redirection
            InsSS_Server.RedirectStandardOutput = true;
            InsSS_Server.RedirectStandardError = true;
            //adbProcInfo.RedirectStandardInput = true;
            InsSS_Server.CreateNoWindow = false;
        }

        private void Thread_StartServer(object sender, DoWorkEventArgs args)
        {
            using (Process serverProcess = new Process())
            {
                serverProcess.StartInfo = InsSS_Server;
                serverProcess.StartInfo.Arguments = args.Argument.ToString();

                serverProcess.EnableRaisingEvents = true;

                // When there's an error callback
                serverProcess.ErrorDataReceived += (procSender, d) =>
                {
                    if (d.Data != null)
                    {
                        //output = CmdOutputParser(e.Data);
                        //outputLine(output);
                    }
                };
                serverProcess.OutputDataReceived += (procSender, d) =>
                {
                    if (d.Data != null)
                    {
                        Thread_OutputParser(d);
                    }
                };

                serverProcess.Start();

                serverProcess.BeginErrorReadLine();
                serverProcess.BeginOutputReadLine();

                serverProcess.WaitForExit();

                /* Reset Start button */
                action = () => ServerClosed();
                BeginInvoke(action);

                /*
                if (serverProcess.ExitCode != 0)
                    return output;
                else
                    return "";
                */
                //ErrorHandler(adbProc.ExitCode);
            }
        }

        private void Thread_OutputParser(DataReceivedEventArgs data)
        {
            if (data.Data.Contains("Scenario loading complete"))
            {
                action = () => tabControl1.SelectedIndex = 1;
                BeginInvoke(action);
                Console.WriteLine("Server Loaded");
            }

            Console.WriteLine("Data - " + data.Data);
        }

        private void ServerClosed()
        {
            buttonStartServer.Text = "Start" + Environment.NewLine + "Server";
            buttonStartServer.Enabled = true;
        }

        /* Saving of all variables is done here */
        private void ExitForm(object sender, FormClosingEventArgs e)
        {
            // Save Game.ini Changes.
            WriteGameIni();

            /* Save to JSON */
            SaveDataType.stringDataStruct stringDataStruct = new SaveDataType.stringDataStruct
            {
                serverDir = exePath,
                GLST = textBox_GLST.Text,
                GameStat = textBox_GameStats.Text,
                password = textBox_Password.Text
            };

            // string saveDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Application.CompanyName, Application.ProductName);
            // Directory.CreateDirectory(saveDir); // create directory if doesn't exist
            string saveDir = System.Reflection.Assembly.GetExecutingAssembly().Location; // get exe location
            saveDir = Path.GetDirectoryName(saveDir); // get path only of exe

            SaveDataType saveData = new SaveDataType(stringDataStruct, mutatorList.ToArray(), modList.ToArray(), mapList.ToArray());
            File.WriteAllText(Path.Combine(saveDir, "settings.json"), JsonConvert.SerializeObject(saveData));
        }

        private void OnClick_LightingChange(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                lighting = ((RadioButton)sender).Text;
            }
        }

        private void OnClick_About(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + " v" + Application.ProductVersion + Environment.NewLine + "By TechRodent - 2021", Application.ProductName + " v" + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnClick_Mutators(object sender, EventArgs e)
        {
            Form_MutatorSelect dialog = new Form_MutatorSelect();
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        private void OnClick_GetGameStats(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gamestats.sandstorm.game/");
        }

        private void OnClick_GetGLST(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://steamcommunity.com/dev/managegameservers");
        }

        private void OnClick_ManageMods(object sender, EventArgs e)
        {
            Form_ModManager dialog = new Form_ModManager();
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        private void OnClick_gameIni(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(iniDir, "Game.ini"));
        }

        private void OnClick_iniDir(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", iniDir);
        }

        private void OnClick_cfgFolder(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", cfgDir);
        }

        private void OnClick_Paypal(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.paypal.me/hsinyangho?locale.x=en_US");
        }

        private void On_TabChange(object sender, EventArgs e)
        {
            listBox_changeScenario.Items.Clear();
            listBox_changeMap.Items.Clear();

            listBox_changeScenario.Items.AddRange(listBox_scenario.Items);
            listBox_changeMap.Items.AddRange(listBox_map.Items);

            listBox_changeScenario.SelectedIndex = listBox_scenario.SelectedIndex;
            listBox_changeMap.SelectedIndex = listBox_map.SelectedIndex;
        }
    }
}

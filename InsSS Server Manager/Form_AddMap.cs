using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsSS_Server_Manager
{
    public partial class Form_AddMap : Form
    {
        List<ScenarioType> scenarioList;
        ScenarioType selectedScenario;
        int selectedScenarioIndex;

        bool bEdit = false;

        public Form_AddMap()
        {
            InitializeComponent();
            this.Text = "Add Map";
            listView_scenarios.Items.Clear();
            scenarioList = new List<ScenarioType>();
        }

        public void LoadMap(MapType map)
        {
            textBox_map.Text = map.mapName;

            scenarioList = map.scenarioList;

            foreach (ScenarioType scenario in map.scenarioList)
            {
                listView_scenarios.Items.Add(scenario.scenarioCategory.ToString().Replace('_', ' ')).SubItems.Add(scenario.scenarioLine);
            }

            this.Text = "Editing map " + map.mapName;
            bEdit = true;
        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void OnClick_OK(object sender, EventArgs e)
        {
            if (textBox_map.Text == "")
            {
                MessageBox.Show("Map is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listView_scenarios.Items.Count == 0)
            {
                MessageBox.Show("Scenario list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((Form_AddMod)Owner).AddMap(new MapType(textBox_map.Text, MapType.mapCat.Custom, scenarioList), bEdit);
            Close();
        }

        /* ------------------ SCENARIO ADD/ EDIT ------------------ */
        public void AddScenario(ScenarioType scenario, bool edit = false)
        {
            if (edit)
            {
                scenarioList.RemoveAt(selectedScenarioIndex);
                scenarioList.Insert(selectedScenarioIndex, scenario);

                listView_scenarios.Items.RemoveAt(selectedScenarioIndex);
                listView_scenarios.Items.Insert(selectedScenarioIndex, new ListViewItem(scenario.scenarioCategory.ToString().Replace('_', ' ')));
                listView_scenarios.Items[selectedScenarioIndex].SubItems.Add(scenario.scenarioLine);
            }
            else
            {
                scenarioList.Add(scenario);
                listView_scenarios.Items.Add(scenario.scenarioCategory.ToString().Replace('_', ' ')).SubItems.Add(scenario.scenarioLine);
            }
        }


        private void OnClick_DeleteScenario(object sender, EventArgs e)
        {
            if (listView_scenarios.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            int index = listView_scenarios.SelectedIndices[0];

            scenarioList.RemoveAt(index);
            listView_scenarios.Items.RemoveAt(index);
        }

        private void OnClick_EditScenario(object sender, EventArgs e)
        {
            if (listView_scenarios.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            selectedScenarioIndex = listView_scenarios.SelectedIndices[0];
            selectedScenario = scenarioList[selectedScenarioIndex];

            Form_AddScenario dialog = new Form_AddScenario();
            dialog.Owner = this;
            dialog.LoadScenario(selectedScenario);
            dialog.ShowDialog();
        }

        private void OnClick_AddScenario(object sender, EventArgs e)
        {
            Form_AddScenario dialog = new Form_AddScenario();
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        /* cannot have spaces in mapname */
    }
}

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
    public partial class Form_AddMod : Form
    {
        List<MutatorType> mutators;
        MutatorType selectedMutator;
        List<MapType> maps;
        MapType selectedMap;
        int selectedMutatorIndex;
        int selectedMapIndex;

        bool bEdit;

        public Form_AddMod()
        {
            InitializeComponent();
            this.Text = "Add Mutator Mod";
            listView_customMutators.Items.Clear();
            mutators = new List<MutatorType>();
            maps = new List<MapType>();
        }

        /* Mod ID Input Filter */
        private void ID_Filter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // intercept if it's not a digit or a control character.

            /* if current count is 6 and above and key isn't a control character, ignore that too. */
            if (textBox_modID.TextLength > 6 && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /* For editing mod */
        public void LoadMod(ModType mod)
        {
            this.Text = "Editing " + mod.modDesc;

            textBox_modID.Text = mod.modID.ToString();
            textBox_modDesc.Text = mod.modDesc;

            mutators = new List<MutatorType>(mod.mutators);
            maps = new List<MapType>(mod.maps);

            foreach (MutatorType mutator in mod.mutators)
                listView_customMutators.Items.Add(mutator.mutatorName).SubItems.Add(mutator.mutatorDescription);

            // remember to load in maps as well.
            foreach (MapType map in mod.maps)
            {
                string scenarios = "";

                foreach (ScenarioType scenario in map.scenarioList)
                {
                    if (scenarios != "")
                        scenarios += ", ";

                    scenarios += scenario.scenarioCategory.ToString().Replace('_',' ');
                }

                listView_customMaps.Items.Add(map.scenarioName).SubItems.Add(scenarios);
            }

            bEdit = true;
        }

        private void OnClick_Ok(object sender, EventArgs e)
        {
            if (textBox_modID.Text == "")
            {
                MessageBox.Show("Mod ID is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listView_customMutators.Items.Count == 0 && listView_customMaps.Items.Count == 0)
            {
                MessageBox.Show("Must have at least 1 Mutator OR Map!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModType mutatorMod = new ModType(int.Parse(textBox_modID.Text), textBox_modDesc.Text, mutators.ToArray(), maps.ToArray());

            ((Form_ModManager)Owner).AddMod(mutatorMod, bEdit);
            Close();
        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            Close();
        }

        /* ------------------ MUTATOR ADD/ EDIT ------------------ */
        public void AddMutator(MutatorType mutator, bool edit = false)
        {
            if (edit)
            {
                bool enabled = mutators[selectedMutatorIndex].enabled; // store enabled state

                mutators.RemoveAt(selectedMutatorIndex);
                mutators.Insert(selectedMutatorIndex, mutator);

                mutators[selectedMutatorIndex].enabled = enabled; // restore enabled state

                listView_customMutators.Items.RemoveAt(selectedMutatorIndex);
                listView_customMutators.Items.Insert(selectedMutatorIndex, new ListViewItem(mutator.mutatorName));
                listView_customMutators.Items[selectedMutatorIndex].SubItems.Add(mutator.mutatorDescription);
            }
            else
            {
                mutators.Add(mutator);
                listView_customMutators.Items.Add(mutator.mutatorName).SubItems.Add(mutator.mutatorDescription);
            }
        }

        private void OnClick_AddMutator(object sender, EventArgs e)
        {
            Form_AddMutator dialog = new Form_AddMutator();
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        private void OnClick_DeleteMutator(object sender, EventArgs e)
        {
            if (listView_customMutators.SelectedIndices.Count == 0) // if I didn't select anything
                return;


            int index = listView_customMutators.SelectedIndices[0];

            mutators.RemoveAt(index);
            listView_customMutators.Items.RemoveAt(index);
        }

        private void OnClick_EditMutator(object sender, EventArgs e)
        {
            if (listView_customMutators.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            selectedMutatorIndex = listView_customMutators.SelectedIndices[0];
            selectedMutator = mutators[selectedMutatorIndex];

            Form_AddMutator dialog = new Form_AddMutator();
            dialog.Owner = this;
            dialog.LoadMutator(selectedMutator);
            dialog.ShowDialog();

        }

        /* ------------------ MAPS ADD/ EDIT ------------------ */
        public void AddMap(MapType map, bool edit = false)
        {
            string scenarios = "";

            foreach (ScenarioType scenario in map.scenarioList)
            {
                if (scenarios != "")
                    scenarios += ", ";

                scenarios += scenario.scenarioCategory.ToString().Replace('_', ' ');
            }

            if (edit)
            {
                maps.RemoveAt(selectedMapIndex);
                maps.Insert(selectedMapIndex, map);

                listView_customMaps.Items.RemoveAt(selectedMapIndex);
                listView_customMaps.Items.Insert(selectedMapIndex, new ListViewItem(map.scenarioName));
                listView_customMaps.Items[selectedMapIndex].SubItems.Add(scenarios);
            }
            else
            {
                maps.Add(map);
                listView_customMaps.Items.Add(map.scenarioName).SubItems.Add(scenarios);
            }
        }

        private void OnClick_DeleteMap(object sender, EventArgs e)
        {
            if (listView_customMaps.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            int index = listView_customMaps.SelectedIndices[0];

            maps.RemoveAt(index);
            listView_customMaps.Items.RemoveAt(index);
        }

        private void OnClick_EditMap(object sender, EventArgs e)
        {
            if (listView_customMaps.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            selectedMapIndex = listView_customMaps.SelectedIndices[0];
            selectedMap = maps[selectedMapIndex];

            Form_AddMap dialog = new Form_AddMap();
            dialog.Owner = this;
            dialog.LoadMap(selectedMap);
            dialog.ShowDialog();
        }

        private void OnClick_AddMap(object sender, EventArgs e)
        {
            Form_AddMap dialog = new Form_AddMap();
            dialog.Owner = this;
            dialog.ShowDialog();
        }
    }
}

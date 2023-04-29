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
    public partial class Form_ModManager : Form
    {
        List<ModType> modMutatorList;

        int selectedIndex;
        ModType selectedMod;

        public Form_ModManager()
        {
            InitializeComponent();
            this.Text = "Add / Manage Mods";
        }

        private void OnClick_AddMutatorMod(object sender, EventArgs e)
        {
            Form_AddMod dialog = new Form_AddMod();
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        public void AddMod(ModType newMod, bool edit = false)
        {
            if (edit)
            {
                bool enabled = listView_mutMods.Items[selectedIndex].Checked; // store enabled state

                modMutatorList.RemoveAt(selectedIndex);
                modMutatorList.Insert(selectedIndex, newMod);

                listView_mutMods.Items.RemoveAt(selectedIndex);
                listView_mutMods.Items.Insert(selectedIndex, new ListViewItem(newMod.modID.ToString()));
                listView_mutMods.Items[selectedIndex].SubItems.Add(newMod.modDesc);
                listView_mutMods.Items[selectedIndex].Checked = enabled; // restore enabled state
            }
            else
            {
                listView_mutMods.Items.Add(newMod.modID.ToString()).SubItems.Add(newMod.modDesc);
                modMutatorList.Add(newMod);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            modMutatorList = ((Form_Main)Owner).modList;

            ListViewItem item;

            foreach (ModType mod in modMutatorList)
            {
                item = listView_mutMods.Items.Add(mod.modID.ToString());
                item.SubItems.Add(mod.modDesc);
                item.Checked = mod.enabled;
            }
        }

        private void OnClick_Save(object sender, EventArgs e)
        {

            ListView.CheckedIndexCollection selected = listView_mutMods.CheckedIndices;

            /* reset everything to unselected */
            foreach (ModType mod in modMutatorList)
                mod.enabled = false;

            /* set the ones we want */
            foreach (int index in selected)
                modMutatorList[index].enabled = true;

            /* save the mutator list back */
            ((Form_Main)Owner).modList = modMutatorList;

            /* update main mutator & Mod list */
            ((Form_Main)Owner).ModMutatorMapUpdate();
            
            Close();
        }

        private void OnClick_Close(object sender, EventArgs e)
        {
            Close();
        }

        private void OnClick_DelMutatorMod(object sender, EventArgs e)
        {
            if (listView_mutMods.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            int index = listView_mutMods.SelectedIndices[0];

            modMutatorList.RemoveAt(index);
            listView_mutMods.Items.RemoveAt(index);
        }

        private void OnClick_EditMutatorMod(object sender, EventArgs e)
        {
            if (listView_mutMods.SelectedIndices.Count == 0) // if I didn't select anything
                return;

            selectedIndex = listView_mutMods.SelectedIndices[0];
            selectedMod = modMutatorList[selectedIndex];

            Form_AddMod dialog = new Form_AddMod();
            dialog.Owner = this;
            dialog.LoadMod(selectedMod);
            dialog.ShowDialog();
        }
    }
}

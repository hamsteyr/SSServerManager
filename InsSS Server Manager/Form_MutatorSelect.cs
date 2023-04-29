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
    public partial class Form_MutatorSelect : Form
    {
        List<MutatorType> mutatorList;

        public Form_MutatorSelect()
        {
            InitializeComponent();
            this.Text = "Select Mutators";
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadMutators();
        }

        private void LoadMutators()
        {
            listView_mutators.Items.Clear();

            mutatorList = ((Form_Main)Owner).mutatorList;

            foreach (MutatorType mutator in mutatorList)
            {
                ListViewItem item = listView_mutators.Items.Add(mutator.mutatorName);
                item.SubItems.Add(mutator.mutatorDescription);
                item.Checked = mutator.enabled;
                item.Group = listView_mutators.Groups[(int)mutator.category];
            }
        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void OnClick_Save(object sender, EventArgs e)
        {
            ListView.CheckedIndexCollection selected = listView_mutators.CheckedIndices;
            
            /* reset everything to unselected */
            foreach (MutatorType mut in mutatorList)
                mut.enabled = false;

            /* set the ones we want */
            foreach (int index in selected)
                mutatorList[index].enabled = true;

            /* save the mutator list back */
            ((Form_Main)Owner).mutatorList = mutatorList;
            
            Close();
        }
    }
}

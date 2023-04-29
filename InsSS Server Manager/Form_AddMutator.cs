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
    public partial class Form_AddMutator : Form
    {
        bool bEdit = false;

        public Form_AddMutator()
        {
            InitializeComponent();
            this.Text = "Add Mutator";
        }

        public void LoadMutator(MutatorType mutator)
        {
            textBox_mutator.Text = mutator.mutatorName;
            textBox_Description.Text = mutator.mutatorDescription;

            this.Text = "Editing Mutator " + mutator.mutatorName;
            bEdit = true;
        }

        private void OnClick_OK(object sender, EventArgs e)
        {
            if (textBox_mutator.Text == "")
            {
                MessageBox.Show("Mutator is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((Form_AddMod)Owner).AddMutator(new MutatorType(textBox_mutator.Text, textBox_Description.Text, MutatorType.mutatorCat.Custom), bEdit);
            Close();
        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void MutatorCheck(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}

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
    public partial class Form_AddScenario : Form
    {
        bool bEdit = false;

        public Form_AddScenario()
        {
            InitializeComponent();
            this.Text = "Add Map";
            PopulateScenarioType();
        }

        private void PopulateScenarioType()
        {
            comboBox_scenarioType.Items.Clear();

            foreach (string scenarioName in Enum.GetNames(typeof(ScenarioType.scenarioCat)))
            {
                comboBox_scenarioType.Items.Add(scenarioName.Replace('_', ' '));
            }

            comboBox_scenarioType.SelectedIndex = 0; // default
        }

        public void LoadScenario(ScenarioType scenario)
        {
            textBox_scenarioLine.Text = scenario.scenarioLine;
            comboBox_scenarioType.SelectedIndex = (int)scenario.scenarioCategory;

            this.Text = "Editing Scenario";
            bEdit = true;
        }

        private void OnClick_OK(object sender, EventArgs e)
        {
            if (textBox_scenarioLine.Text == "")
            {
                MessageBox.Show("Scenario Line is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ((Form_AddMap)Owner).AddScenario(new ScenarioType(textBox_scenarioLine.Text, (ScenarioType.scenarioCat)comboBox_scenarioType.SelectedIndex), bEdit);
            Close();
        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}

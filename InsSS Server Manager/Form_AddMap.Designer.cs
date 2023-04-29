
namespace InsSS_Server_Manager
{
    partial class Form_AddMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Checkpoint Insurgents",
            "Scenario=Scenario_PowerPlant_CS_Checkpoint_Security_B"}, -1);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView_scenarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_map = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView_scenarios);
            this.groupBox3.Location = new System.Drawing.Point(12, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 156);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scenarios (e.g. Scenario_Precinct_Survival. Must not start with \"Scenario=\") - Ri" +
    "ght Click for more Options";
            // 
            // listView_scenarios
            // 
            this.listView_scenarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_scenarios.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_scenarios.FullRowSelect = true;
            this.listView_scenarios.GridLines = true;
            this.listView_scenarios.HideSelection = false;
            this.listView_scenarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView_scenarios.Location = new System.Drawing.Point(6, 19);
            this.listView_scenarios.MultiSelect = false;
            this.listView_scenarios.Name = "listView_scenarios";
            this.listView_scenarios.Size = new System.Drawing.Size(651, 130);
            this.listView_scenarios.TabIndex = 0;
            this.listView_scenarios.UseCompatibleStateImageBehavior = false;
            this.listView_scenarios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Scenario";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Scenario Line";
            this.columnHeader2.Width = 480;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_map);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map (e.g. Precinct)";
            // 
            // textBox_map
            // 
            this.textBox_map.Location = new System.Drawing.Point(6, 19);
            this.textBox_map.Name = "textBox_map";
            this.textBox_map.Size = new System.Drawing.Size(338, 20);
            this.textBox_map.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteScenarioToolStripMenuItem,
            this.editScenarioToolStripMenuItem,
            this.addScenarioToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 70);
            // 
            // deleteScenarioToolStripMenuItem
            // 
            this.deleteScenarioToolStripMenuItem.Name = "deleteScenarioToolStripMenuItem";
            this.deleteScenarioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteScenarioToolStripMenuItem.Text = "Delete Scenario";
            this.deleteScenarioToolStripMenuItem.Click += new System.EventHandler(this.OnClick_DeleteScenario);
            // 
            // editScenarioToolStripMenuItem
            // 
            this.editScenarioToolStripMenuItem.Name = "editScenarioToolStripMenuItem";
            this.editScenarioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editScenarioToolStripMenuItem.Text = "Edit Scenario";
            this.editScenarioToolStripMenuItem.Click += new System.EventHandler(this.OnClick_EditScenario);
            // 
            // addScenarioToolStripMenuItem
            // 
            this.addScenarioToolStripMenuItem.Name = "addScenarioToolStripMenuItem";
            this.addScenarioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addScenarioToolStripMenuItem.Text = "Add Scenario";
            this.addScenarioToolStripMenuItem.Click += new System.EventHandler(this.OnClick_AddScenario);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClick_Cancel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 39;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClick_OK);
            // 
            // Form_AddMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_AddMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddMap";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView_scenarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_map;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScenarioToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
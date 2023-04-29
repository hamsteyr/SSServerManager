
namespace InsSS_Server_Manager
{
    partial class Form_AddMod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_modID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_modDesc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView_customMutators = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu_Mutator = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMutatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMuitatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMutatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView_customMaps = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu_Scenario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenu_Mutator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenu_Scenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_modID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mod ID";
            // 
            // textBox_modID
            // 
            this.textBox_modID.Location = new System.Drawing.Point(6, 19);
            this.textBox_modID.Name = "textBox_modID";
            this.textBox_modID.Size = new System.Drawing.Size(100, 20);
            this.textBox_modID.TabIndex = 0;
            this.textBox_modID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_Filter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_modDesc);
            this.groupBox2.Location = new System.Drawing.Point(130, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mod Description";
            // 
            // textBox_modDesc
            // 
            this.textBox_modDesc.Location = new System.Drawing.Point(6, 19);
            this.textBox_modDesc.Name = "textBox_modDesc";
            this.textBox_modDesc.Size = new System.Drawing.Size(300, 20);
            this.textBox_modDesc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView_customMutators);
            this.groupBox3.Location = new System.Drawing.Point(12, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 156);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Mutator(s) - Right Click for more Options";
            // 
            // listView_customMutators
            // 
            this.listView_customMutators.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_customMutators.ContextMenuStrip = this.contextMenu_Mutator;
            this.listView_customMutators.FullRowSelect = true;
            this.listView_customMutators.GridLines = true;
            this.listView_customMutators.HideSelection = false;
            this.listView_customMutators.Location = new System.Drawing.Point(6, 19);
            this.listView_customMutators.MultiSelect = false;
            this.listView_customMutators.Name = "listView_customMutators";
            this.listView_customMutators.Size = new System.Drawing.Size(651, 130);
            this.listView_customMutators.TabIndex = 0;
            this.listView_customMutators.UseCompatibleStateImageBehavior = false;
            this.listView_customMutators.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mutator";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mutator Description";
            this.columnHeader2.Width = 480;
            // 
            // contextMenu_Mutator
            // 
            this.contextMenu_Mutator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMutatorToolStripMenuItem,
            this.addMuitatorToolStripMenuItem,
            this.addMutatorToolStripMenuItem});
            this.contextMenu_Mutator.Name = "contextMenuStrip1";
            this.contextMenu_Mutator.Size = new System.Drawing.Size(154, 70);
            // 
            // deleteMutatorToolStripMenuItem
            // 
            this.deleteMutatorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteMutatorToolStripMenuItem.Name = "deleteMutatorToolStripMenuItem";
            this.deleteMutatorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteMutatorToolStripMenuItem.Text = "Delete Mutator";
            this.deleteMutatorToolStripMenuItem.Click += new System.EventHandler(this.OnClick_DeleteMutator);
            // 
            // addMuitatorToolStripMenuItem
            // 
            this.addMuitatorToolStripMenuItem.Name = "addMuitatorToolStripMenuItem";
            this.addMuitatorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addMuitatorToolStripMenuItem.Text = "Edit Mutator";
            this.addMuitatorToolStripMenuItem.Click += new System.EventHandler(this.OnClick_EditMutator);
            // 
            // addMutatorToolStripMenuItem
            // 
            this.addMutatorToolStripMenuItem.Name = "addMutatorToolStripMenuItem";
            this.addMutatorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addMutatorToolStripMenuItem.Text = "Add Mutator";
            this.addMutatorToolStripMenuItem.Click += new System.EventHandler(this.OnClick_AddMutator);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClick_Ok);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 39;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnClick_Cancel);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView_customMaps);
            this.groupBox4.Location = new System.Drawing.Point(12, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(664, 156);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Map(s) - Right Click for more Options";
            // 
            // listView_customMaps
            // 
            this.listView_customMaps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView_customMaps.ContextMenuStrip = this.contextMenu_Scenario;
            this.listView_customMaps.FullRowSelect = true;
            this.listView_customMaps.GridLines = true;
            this.listView_customMaps.HideSelection = false;
            this.listView_customMaps.Location = new System.Drawing.Point(6, 19);
            this.listView_customMaps.MultiSelect = false;
            this.listView_customMaps.Name = "listView_customMaps";
            this.listView_customMaps.Size = new System.Drawing.Size(651, 130);
            this.listView_customMaps.TabIndex = 0;
            this.listView_customMaps.UseCompatibleStateImageBehavior = false;
            this.listView_customMaps.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Map";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Map Scenarios";
            this.columnHeader4.Width = 480;
            // 
            // contextMenu_Scenario
            // 
            this.contextMenu_Scenario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteScenarioToolStripMenuItem,
            this.editScenarioToolStripMenuItem,
            this.addScenarioToolStripMenuItem});
            this.contextMenu_Scenario.Name = "contextMenu_Scenario";
            this.contextMenu_Scenario.Size = new System.Drawing.Size(135, 70);
            // 
            // deleteScenarioToolStripMenuItem
            // 
            this.deleteScenarioToolStripMenuItem.Name = "deleteScenarioToolStripMenuItem";
            this.deleteScenarioToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteScenarioToolStripMenuItem.Text = "Delete Map";
            this.deleteScenarioToolStripMenuItem.Click += new System.EventHandler(this.OnClick_DeleteMap);
            // 
            // editScenarioToolStripMenuItem
            // 
            this.editScenarioToolStripMenuItem.Name = "editScenarioToolStripMenuItem";
            this.editScenarioToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editScenarioToolStripMenuItem.Text = "Edit Map";
            this.editScenarioToolStripMenuItem.Click += new System.EventHandler(this.OnClick_EditMap);
            // 
            // addScenarioToolStripMenuItem
            // 
            this.addScenarioToolStripMenuItem.Name = "addScenarioToolStripMenuItem";
            this.addScenarioToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addScenarioToolStripMenuItem.Text = "Add Map";
            this.addScenarioToolStripMenuItem.Click += new System.EventHandler(this.OnClick_AddMap);
            // 
            // Form_AddMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 429);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_AddMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddMod";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenu_Mutator.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenu_Scenario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_modID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_modDesc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView_customMutators;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Mutator;
        private System.Windows.Forms.ToolStripMenuItem deleteMutatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMuitatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMutatorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView_customMaps;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Scenario;
        private System.Windows.Forms.ToolStripMenuItem deleteScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScenarioToolStripMenuItem;
    }
}
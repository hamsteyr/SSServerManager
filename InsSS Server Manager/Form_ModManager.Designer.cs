
namespace InsSS_Server_Manager
{
    partial class Form_ModManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModManager));
            this.listView_mutMods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_mutMods
            // 
            this.listView_mutMods.CheckBoxes = true;
            this.listView_mutMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_mutMods.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_mutMods.FullRowSelect = true;
            this.listView_mutMods.HideSelection = false;
            this.listView_mutMods.Location = new System.Drawing.Point(6, 19);
            this.listView_mutMods.MultiSelect = false;
            this.listView_mutMods.Name = "listView_mutMods";
            this.listView_mutMods.Size = new System.Drawing.Size(373, 365);
            this.listView_mutMods.TabIndex = 0;
            this.listView_mutMods.UseCompatibleStateImageBehavior = false;
            this.listView_mutMods.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "mod.io ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mod Name";
            this.columnHeader2.Width = 272;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteModToolStripMenuItem,
            this.editModToolStripMenuItem,
            this.addModToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 70);
            // 
            // deleteModToolStripMenuItem
            // 
            this.deleteModToolStripMenuItem.Name = "deleteModToolStripMenuItem";
            this.deleteModToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deleteModToolStripMenuItem.Text = "Delete Mod";
            this.deleteModToolStripMenuItem.Click += new System.EventHandler(this.OnClick_DelMutatorMod);
            // 
            // editModToolStripMenuItem
            // 
            this.editModToolStripMenuItem.Name = "editModToolStripMenuItem";
            this.editModToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editModToolStripMenuItem.Text = "Edit Mod";
            this.editModToolStripMenuItem.Click += new System.EventHandler(this.OnClick_EditMutatorMod);
            // 
            // addModToolStripMenuItem
            // 
            this.addModToolStripMenuItem.Name = "addModToolStripMenuItem";
            this.addModToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.addModToolStripMenuItem.Text = "Add Mod";
            this.addModToolStripMenuItem.Click += new System.EventHandler(this.OnClick_AddMutatorMod);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_mutMods);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Mod(s) - Right Click for more Options, Check to Enable";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 31;
            this.button2.Text = "Save && Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClick_Save);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClick_Close);
            // 
            // Form_ModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ModManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModsForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_mutMods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addModToolStripMenuItem;
    }
}
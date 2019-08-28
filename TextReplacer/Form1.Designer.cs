namespace TextReplacer
{
    partial class TextReplacer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextReplacer));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.inFileTab = new System.Windows.Forms.TabPage();
			this.inEditorTab = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tabControl.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tabControl.Controls.Add(this.inFileTab);
			this.tabControl.Controls.Add(this.inEditorTab);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(786, 463);
			this.tabControl.TabIndex = 0;
			// 
			// inFileTab
			// 
			this.inFileTab.Location = new System.Drawing.Point(4, 22);
			this.inFileTab.Margin = new System.Windows.Forms.Padding(0);
			this.inFileTab.Name = "inFileTab";
			this.inFileTab.Size = new System.Drawing.Size(778, 437);
			this.inFileTab.TabIndex = 0;
			this.inFileTab.Text = "In File(s)";
			this.inFileTab.UseVisualStyleBackColor = true;
			// 
			// inEditorTab
			// 
			this.inEditorTab.Location = new System.Drawing.Point(4, 22);
			this.inEditorTab.Name = "inEditorTab";
			this.inEditorTab.Padding = new System.Windows.Forms.Padding(3);
			this.inEditorTab.Size = new System.Drawing.Size(778, 437);
			this.inEditorTab.TabIndex = 1;
			this.inEditorTab.Text = "In Editor";
			this.inEditorTab.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.replaceModeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigurationToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveConfigurationToolStripMenuItem
			// 
			this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
			this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
			this.saveConfigurationToolStripMenuItem.Text = "Save Configuration           Ctrl+S";
			this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
			this.saveAsToolStripMenuItem.Text = "Save Configuration As      Ctrl+Shift+S";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
			this.openToolStripMenuItem.Text = "Open Configuration          Ctrl+O";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// recentToolStripMenuItem
			// 
			this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
			this.recentToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
			this.recentToolStripMenuItem.Text = "Recent Configurations";
			// 
			// replaceModeToolStripMenuItem
			// 
			this.replaceModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inFilesToolStripMenuItem,
            this.inEditorToolStripMenuItem});
			this.replaceModeToolStripMenuItem.Name = "replaceModeToolStripMenuItem";
			this.replaceModeToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.replaceModeToolStripMenuItem.Text = "Replace Mode";
			// 
			// inFilesToolStripMenuItem
			// 
			this.inFilesToolStripMenuItem.Name = "inFilesToolStripMenuItem";
			this.inFilesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.inFilesToolStripMenuItem.Text = "In File(s)";
			this.inFilesToolStripMenuItem.Click += new System.EventHandler(this.inFilesToolStripMenuItem_Click);
			// 
			// inEditorToolStripMenuItem
			// 
			this.inEditorToolStripMenuItem.Name = "inEditorToolStripMenuItem";
			this.inEditorToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.inEditorToolStripMenuItem.Text = "In Editor";
			this.inEditorToolStripMenuItem.Click += new System.EventHandler(this.inEditorToolStripMenuItem_Click);
			// 
			// ofd
			// 
			this.ofd.FileName = "openFileDialog1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
			this.exitToolStripMenuItem.Text = "Exit                                       Alt+F4";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
			// 
			// TextReplacer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "TextReplacer";
			this.Text = "TextReplacer";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextReplacer_KeyDown);
			this.tabControl.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inFileTab;
        private System.Windows.Forms.TabPage inEditorTab;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}


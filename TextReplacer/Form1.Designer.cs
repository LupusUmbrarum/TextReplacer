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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inFileTab = new System.Windows.Forms.TabPage();
            this.inEditorTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.inFileTab);
            this.tabControl.Controls.Add(this.inEditorTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 461);
            this.tabControl.TabIndex = 0;
            // 
            // inFileTab
            // 
            this.inFileTab.Location = new System.Drawing.Point(4, 22);
            this.inFileTab.Name = "inFileTab";
            this.inFileTab.Padding = new System.Windows.Forms.Padding(3);
            this.inFileTab.Size = new System.Drawing.Size(776, 435);
            this.inFileTab.TabIndex = 0;
            this.inFileTab.Text = "In File(s)";
            this.inFileTab.UseVisualStyleBackColor = true;
            // 
            // inEditorTab
            // 
            this.inEditorTab.Location = new System.Drawing.Point(4, 22);
            this.inEditorTab.Name = "inEditorTab";
            this.inEditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.inEditorTab.Size = new System.Drawing.Size(776, 435);
            this.inEditorTab.TabIndex = 1;
            this.inEditorTab.Text = "In Editor";
            this.inEditorTab.UseVisualStyleBackColor = true;
            // 
            // TextReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Name = "TextReplacer";
            this.Text = "TextReplacer";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inFileTab;
        private System.Windows.Forms.TabPage inEditorTab;
    }
}


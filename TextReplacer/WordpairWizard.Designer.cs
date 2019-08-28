namespace TextReplacer
{
    partial class WordPairWizard
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
			this.incrementalTab = new System.Windows.Forms.TabPage();
			this.okButton = new System.Windows.Forms.Button();
			this.addPairsButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.stepNumTextBox = new System.Windows.Forms.TextBox();
			this.startNumTextBox = new System.Windows.Forms.TextBox();
			this.endNumTextBox = new System.Windows.Forms.TextBox();
			this.targetTextTextBox = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.incrementalTab.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// incrementalTab
			// 
			this.incrementalTab.Controls.Add(this.okButton);
			this.incrementalTab.Controls.Add(this.addPairsButton);
			this.incrementalTab.Controls.Add(this.label2);
			this.incrementalTab.Controls.Add(this.label10);
			this.incrementalTab.Controls.Add(this.label9);
			this.incrementalTab.Controls.Add(this.label8);
			this.incrementalTab.Controls.Add(this.label7);
			this.incrementalTab.Controls.Add(this.label6);
			this.incrementalTab.Controls.Add(this.label5);
			this.incrementalTab.Controls.Add(this.label4);
			this.incrementalTab.Controls.Add(this.label3);
			this.incrementalTab.Controls.Add(this.label1);
			this.incrementalTab.Controls.Add(this.stepNumTextBox);
			this.incrementalTab.Controls.Add(this.startNumTextBox);
			this.incrementalTab.Controls.Add(this.endNumTextBox);
			this.incrementalTab.Controls.Add(this.targetTextTextBox);
			this.incrementalTab.Location = new System.Drawing.Point(4, 22);
			this.incrementalTab.Name = "incrementalTab";
			this.incrementalTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.incrementalTab.Size = new System.Drawing.Size(307, 237);
			this.incrementalTab.TabIndex = 0;
			this.incrementalTab.Text = "Incremental";
			this.incrementalTab.UseVisualStyleBackColor = true;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(118, 202);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 24);
			this.okButton.TabIndex = 45;
			this.okButton.Text = "Ok";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// addPairsButton
			// 
			this.addPairsButton.Location = new System.Drawing.Point(200, 160);
			this.addPairsButton.Name = "addPairsButton";
			this.addPairsButton.Size = new System.Drawing.Size(75, 24);
			this.addPairsButton.TabIndex = 45;
			this.addPairsButton.Text = "Add Pairs";
			this.addPairsButton.UseVisualStyleBackColor = true;
			this.addPairsButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 44;
			this.label2.Text = "from 14 to 17";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 61);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(290, 13);
			this.label10.TabIndex = 44;
			this.label10.Text = "will indicate that the numbers will increase by one each time,";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(298, 13);
			this.label9.TabIndex = 43;
			this.label9.Text = "box, and 17 in the End box. Finally, put 1 in the Step box, this ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(307, 13);
			this.label8.TabIndex = 42;
			this.label8.Text = "\"HG017\" put HG0<_num_> in the Replace box, 14 in the Begin";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(307, 13);
			this.label7.TabIndex = 41;
			this.label7.Text = "For example: to replace \"HG014\" with \"HG015\", \"HG016\", and";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(291, 13);
			this.label6.TabIndex = 31;
			this.label6.Text = "Note: wherever you want to replace a number, put <_num_>";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "Step";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(165, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 39;
			this.label4.Text = "End:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 38;
			this.label3.Text = "Begin:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Replace:";
			// 
			// stepNumTextBox
			// 
			this.stepNumTextBox.Location = new System.Drawing.Point(69, 162);
			this.stepNumTextBox.Name = "stepNumTextBox";
			this.stepNumTextBox.Size = new System.Drawing.Size(86, 20);
			this.stepNumTextBox.TabIndex = 34;
			this.stepNumTextBox.Click += new System.EventHandler(this.genericOnClick);
			this.stepNumTextBox.Enter += new System.EventHandler(this.genericOnFocus);
			this.stepNumTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
			// 
			// startNumTextBox
			// 
			this.startNumTextBox.Location = new System.Drawing.Point(69, 136);
			this.startNumTextBox.Name = "startNumTextBox";
			this.startNumTextBox.Size = new System.Drawing.Size(86, 20);
			this.startNumTextBox.TabIndex = 32;
			this.startNumTextBox.Click += new System.EventHandler(this.genericOnClick);
			this.startNumTextBox.Enter += new System.EventHandler(this.genericOnFocus);
			this.startNumTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
			// 
			// endNumTextBox
			// 
			this.endNumTextBox.Location = new System.Drawing.Point(200, 136);
			this.endNumTextBox.Name = "endNumTextBox";
			this.endNumTextBox.Size = new System.Drawing.Size(86, 20);
			this.endNumTextBox.TabIndex = 33;
			this.endNumTextBox.Click += new System.EventHandler(this.genericOnClick);
			this.endNumTextBox.Enter += new System.EventHandler(this.genericOnFocus);
			this.endNumTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
			// 
			// targetTextTextBox
			// 
			this.targetTextTextBox.Location = new System.Drawing.Point(69, 110);
			this.targetTextTextBox.Name = "targetTextTextBox";
			this.targetTextTextBox.Size = new System.Drawing.Size(86, 20);
			this.targetTextTextBox.TabIndex = 30;
			this.targetTextTextBox.Click += new System.EventHandler(this.genericOnClick);
			this.targetTextTextBox.Enter += new System.EventHandler(this.genericOnFocus);
			this.targetTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.incrementalTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(315, 263);
			this.tabControl1.TabIndex = 28;
			// 
			// WordPairWizard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 263);
			this.Controls.Add(this.tabControl1);
			this.MaximumSize = new System.Drawing.Size(331, 302);
			this.MinimumSize = new System.Drawing.Size(331, 302);
			this.Name = "WordPairWizard";
			this.Text = "WordPairWizard";
			this.incrementalTab.ResumeLayout(false);
			this.incrementalTab.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage incrementalTab;
        private System.Windows.Forms.Button addPairsButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepNumTextBox;
        private System.Windows.Forms.TextBox startNumTextBox;
        private System.Windows.Forms.TextBox endNumTextBox;
        private System.Windows.Forms.TextBox targetTextTextBox;
        private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label2;
	}
}
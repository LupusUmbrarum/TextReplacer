namespace TextReplacer
{
    partial class ReplaceInFileView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.addFilesButton = new System.Windows.Forms.Button();
			this.replaceTextButton = new System.Windows.Forms.Button();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.clearWordPairButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.targetTextTextBox = new System.Windows.Forms.TextBox();
			this.newTextTextBox = new System.Windows.Forms.TextBox();
			this.addWordPairButton = new System.Windows.Forms.Button();
			this.wordPairPanel = new System.Windows.Forms.Panel();
			this.clearFilesButton = new System.Windows.Forms.Button();
			this.filePathPanel = new System.Windows.Forms.Panel();
			this.wizardButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.createNewCheckBox = new System.Windows.Forms.CheckBox();
			this.byGroupCheckBox = new System.Windows.Forms.CheckBox();
			this.onCreateCheckBox = new System.Windows.Forms.CheckBox();
			this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// addFilesButton
			// 
			this.addFilesButton.Location = new System.Drawing.Point(20, 17);
			this.addFilesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addFilesButton.Name = "addFilesButton";
			this.addFilesButton.Size = new System.Drawing.Size(100, 31);
			this.addFilesButton.TabIndex = 14;
			this.addFilesButton.Text = "Add File(s)";
			this.addFilesButton.UseVisualStyleBackColor = true;
			this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
			// 
			// replaceTextButton
			// 
			this.replaceTextButton.Location = new System.Drawing.Point(901, 491);
			this.replaceTextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.replaceTextButton.Name = "replaceTextButton";
			this.replaceTextButton.Size = new System.Drawing.Size(112, 31);
			this.replaceTextButton.TabIndex = 13;
			this.replaceTextButton.Text = "Replace Text";
			this.replaceTextButton.UseVisualStyleBackColor = true;
			this.replaceTextButton.Click += new System.EventHandler(this.replaceTextButton_Click);
			// 
			// ofd
			// 
			this.ofd.Multiselect = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(533, 55);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(228, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "Word Pairs (TargetText->NewText)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 55);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 24;
			this.label3.Text = "Files";
			// 
			// clearWordPairButton
			// 
			this.clearWordPairButton.Location = new System.Drawing.Point(932, 14);
			this.clearWordPairButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.clearWordPairButton.Name = "clearWordPairButton";
			this.clearWordPairButton.Size = new System.Drawing.Size(81, 31);
			this.clearWordPairButton.TabIndex = 23;
			this.clearWordPairButton.Text = "Clear";
			this.clearWordPairButton.UseVisualStyleBackColor = true;
			this.clearWordPairButton.Click += new System.EventHandler(this.clearWordPairButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(673, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 17);
			this.label2.TabIndex = 22;
			this.label2.Text = "with:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(476, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Replace:";
			// 
			// targetTextTextBox
			// 
			this.targetTextTextBox.Location = new System.Drawing.Point(551, 16);
			this.targetTextTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.targetTextTextBox.Name = "targetTextTextBox";
			this.targetTextTextBox.Size = new System.Drawing.Size(113, 22);
			this.targetTextTextBox.TabIndex = 18;
			this.targetTextTextBox.Click += new System.EventHandler(this.onTargetBoxClick);
			this.targetTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
			// 
			// newTextTextBox
			// 
			this.newTextTextBox.Location = new System.Drawing.Point(720, 16);
			this.newTextTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.newTextTextBox.Name = "newTextTextBox";
			this.newTextTextBox.Size = new System.Drawing.Size(113, 22);
			this.newTextTextBox.TabIndex = 19;
			this.newTextTextBox.Click += new System.EventHandler(this.onNewTextBoxClick);
			this.newTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
			// 
			// addWordPairButton
			// 
			this.addWordPairButton.Location = new System.Drawing.Point(843, 14);
			this.addWordPairButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addWordPairButton.Name = "addWordPairButton";
			this.addWordPairButton.Size = new System.Drawing.Size(81, 31);
			this.addWordPairButton.TabIndex = 21;
			this.addWordPairButton.Text = "Add";
			this.addWordPairButton.UseVisualStyleBackColor = true;
			this.addWordPairButton.Click += new System.EventHandler(this.addWordPairButton_Click);
			// 
			// wordPairPanel
			// 
			this.wordPairPanel.AutoScroll = true;
			this.wordPairPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.wordPairPanel.Location = new System.Drawing.Point(533, 79);
			this.wordPairPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.wordPairPanel.Name = "wordPairPanel";
			this.wordPairPanel.Size = new System.Drawing.Size(479, 399);
			this.wordPairPanel.TabIndex = 17;
			// 
			// clearFilesButton
			// 
			this.clearFilesButton.Location = new System.Drawing.Point(129, 17);
			this.clearFilesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.clearFilesButton.Name = "clearFilesButton";
			this.clearFilesButton.Size = new System.Drawing.Size(100, 31);
			this.clearFilesButton.TabIndex = 16;
			this.clearFilesButton.Text = "Clear";
			this.clearFilesButton.UseVisualStyleBackColor = true;
			this.clearFilesButton.Click += new System.EventHandler(this.clearFilesButton_Click);
			// 
			// filePathPanel
			// 
			this.filePathPanel.AllowDrop = true;
			this.filePathPanel.AutoScroll = true;
			this.filePathPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.filePathPanel.Location = new System.Drawing.Point(21, 79);
			this.filePathPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.filePathPanel.Name = "filePathPanel";
			this.filePathPanel.Size = new System.Drawing.Size(479, 200);
			this.filePathPanel.TabIndex = 15;
			this.filePathPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.filePathPanel_DragDrop);
			this.filePathPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.filePathPanel_DragEnter);
			// 
			// wizardButton
			// 
			this.wizardButton.Location = new System.Drawing.Point(25, 491);
			this.wizardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.wizardButton.Name = "wizardButton";
			this.wizardButton.Size = new System.Drawing.Size(100, 28);
			this.wizardButton.TabIndex = 36;
			this.wizardButton.Text = "Wizard";
			this.wizardButton.UseVisualStyleBackColor = true;
			this.wizardButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 283);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 17);
			this.label5.TabIndex = 37;
			this.label5.Text = "Options";
			// 
			// toolTip1
			// 
			this.toolTip1.Tag = "";
			// 
			// createNewCheckBox
			// 
			this.createNewCheckBox.AutoSize = true;
			this.createNewCheckBox.Location = new System.Drawing.Point(20, 303);
			this.createNewCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.createNewCheckBox.Name = "createNewCheckBox";
			this.createNewCheckBox.Size = new System.Drawing.Size(146, 21);
			this.createNewCheckBox.TabIndex = 41;
			this.createNewCheckBox.Text = "Create New File(s)";
			this.createNewCheckBox.UseVisualStyleBackColor = true;
			this.createNewCheckBox.CheckedChanged += new System.EventHandler(this.createNewCheckBox_CheckedChanged);
			// 
			// byGroupCheckBox
			// 
			this.byGroupCheckBox.AutoSize = true;
			this.byGroupCheckBox.Enabled = false;
			this.byGroupCheckBox.Location = new System.Drawing.Point(227, 303);
			this.byGroupCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.byGroupCheckBox.Name = "byGroupCheckBox";
			this.byGroupCheckBox.Size = new System.Drawing.Size(136, 21);
			this.byGroupCheckBox.TabIndex = 42;
			this.byGroupCheckBox.Text = "Create By Group";
			this.byGroupCheckBox.UseVisualStyleBackColor = true;
			this.byGroupCheckBox.CheckedChanged += new System.EventHandler(this.byGroupCheckBox_CheckedChanged);
			// 
			// onCreateCheckBox
			// 
			this.onCreateCheckBox.AutoSize = true;
			this.onCreateCheckBox.Enabled = false;
			this.onCreateCheckBox.Location = new System.Drawing.Point(227, 331);
			this.onCreateCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.onCreateCheckBox.Name = "onCreateCheckBox";
			this.onCreateCheckBox.Size = new System.Drawing.Size(222, 21);
			this.onCreateCheckBox.TabIndex = 43;
			this.onCreateCheckBox.Text = "Name File Manually On Create";
			this.onCreateCheckBox.UseVisualStyleBackColor = true;
			this.onCreateCheckBox.CheckedChanged += new System.EventHandler(this.onCreateCheckBox_CheckedChanged);
			// 
			// matchCaseCheckBox
			// 
			this.matchCaseCheckBox.AutoSize = true;
			this.matchCaseCheckBox.Location = new System.Drawing.Point(20, 386);
			this.matchCaseCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.matchCaseCheckBox.Name = "matchCaseCheckBox";
			this.matchCaseCheckBox.Size = new System.Drawing.Size(104, 21);
			this.matchCaseCheckBox.TabIndex = 41;
			this.matchCaseCheckBox.Text = "Match Case";
			this.matchCaseCheckBox.UseVisualStyleBackColor = true;
			this.matchCaseCheckBox.CheckedChanged += new System.EventHandler(this.matchCaseCheckedChanged);
			// 
			// ReplaceInFileView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.onCreateCheckBox);
			this.Controls.Add(this.byGroupCheckBox);
			this.Controls.Add(this.matchCaseCheckBox);
			this.Controls.Add(this.createNewCheckBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.wizardButton);
			this.Controls.Add(this.addFilesButton);
			this.Controls.Add(this.replaceTextButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.clearWordPairButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.targetTextTextBox);
			this.Controls.Add(this.newTextTextBox);
			this.Controls.Add(this.addWordPairButton);
			this.Controls.Add(this.wordPairPanel);
			this.Controls.Add(this.clearFilesButton);
			this.Controls.Add(this.filePathPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ReplaceInFileView";
			this.Size = new System.Drawing.Size(1035, 535);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFilesButton;
        private System.Windows.Forms.Button replaceTextButton;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearWordPairButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetTextTextBox;
        private System.Windows.Forms.TextBox newTextTextBox;
        private System.Windows.Forms.Button addWordPairButton;
        private System.Windows.Forms.Panel wordPairPanel;
        private System.Windows.Forms.Button clearFilesButton;
        private System.Windows.Forms.Panel filePathPanel;
        private System.Windows.Forms.Button wizardButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox createNewCheckBox;
        private System.Windows.Forms.CheckBox byGroupCheckBox;
        private System.Windows.Forms.CheckBox onCreateCheckBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
    }
}

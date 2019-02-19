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
            this.SuspendLayout();
            // 
            // addFilesButton
            // 
            this.addFilesButton.Location = new System.Drawing.Point(15, 14);
            this.addFilesButton.Name = "addFilesButton";
            this.addFilesButton.Size = new System.Drawing.Size(75, 25);
            this.addFilesButton.TabIndex = 14;
            this.addFilesButton.Text = "Add File(s)";
            this.addFilesButton.UseVisualStyleBackColor = true;
            this.addFilesButton.Click += new System.EventHandler(this.addFilesButton_Click);
            // 
            // replaceTextButton
            // 
            this.replaceTextButton.Location = new System.Drawing.Point(676, 399);
            this.replaceTextButton.Name = "replaceTextButton";
            this.replaceTextButton.Size = new System.Drawing.Size(84, 25);
            this.replaceTextButton.TabIndex = 13;
            this.replaceTextButton.Text = "Replace Text";
            this.replaceTextButton.UseVisualStyleBackColor = true;
            this.replaceTextButton.Click += new System.EventHandler(this.replaceTextButton_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofile";
            this.ofd.Multiselect = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Word Pairs (TargetText->NewText)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Files";
            // 
            // clearWordPairButton
            // 
            this.clearWordPairButton.Location = new System.Drawing.Point(699, 11);
            this.clearWordPairButton.Name = "clearWordPairButton";
            this.clearWordPairButton.Size = new System.Drawing.Size(61, 25);
            this.clearWordPairButton.TabIndex = 23;
            this.clearWordPairButton.Text = "Clear";
            this.clearWordPairButton.UseVisualStyleBackColor = true;
            this.clearWordPairButton.Click += new System.EventHandler(this.clearWordPairButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "with:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Replace:";
            // 
            // targetTextTextBox
            // 
            this.targetTextTextBox.Location = new System.Drawing.Point(413, 13);
            this.targetTextTextBox.Name = "targetTextTextBox";
            this.targetTextTextBox.Size = new System.Drawing.Size(86, 20);
            this.targetTextTextBox.TabIndex = 18;
            this.targetTextTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.generalPreviewKeyDown);
            // 
            // newTextTextBox
            // 
            this.newTextTextBox.Location = new System.Drawing.Point(540, 13);
            this.newTextTextBox.Name = "newTextTextBox";
            this.newTextTextBox.Size = new System.Drawing.Size(86, 20);
            this.newTextTextBox.TabIndex = 19;
            this.newTextTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.generalPreviewKeyDown);
            // 
            // addWordPairButton
            // 
            this.addWordPairButton.Location = new System.Drawing.Point(632, 11);
            this.addWordPairButton.Name = "addWordPairButton";
            this.addWordPairButton.Size = new System.Drawing.Size(61, 25);
            this.addWordPairButton.TabIndex = 21;
            this.addWordPairButton.Text = "Add";
            this.addWordPairButton.UseVisualStyleBackColor = true;
            this.addWordPairButton.Click += new System.EventHandler(this.addWordPairButton_Click);
            // 
            // wordPairPanel
            // 
            this.wordPairPanel.AutoScroll = true;
            this.wordPairPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPairPanel.Location = new System.Drawing.Point(400, 64);
            this.wordPairPanel.Name = "wordPairPanel";
            this.wordPairPanel.Size = new System.Drawing.Size(360, 325);
            this.wordPairPanel.TabIndex = 17;
            // 
            // clearFilesButton
            // 
            this.clearFilesButton.Location = new System.Drawing.Point(97, 14);
            this.clearFilesButton.Name = "clearFilesButton";
            this.clearFilesButton.Size = new System.Drawing.Size(75, 25);
            this.clearFilesButton.TabIndex = 16;
            this.clearFilesButton.Text = "Clear";
            this.clearFilesButton.UseVisualStyleBackColor = true;
            this.clearFilesButton.Click += new System.EventHandler(this.clearFilesButton_Click);
            // 
            // filePathPanel
            // 
            this.filePathPanel.AutoScroll = true;
            this.filePathPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filePathPanel.Location = new System.Drawing.Point(16, 64);
            this.filePathPanel.Name = "filePathPanel";
            this.filePathPanel.Size = new System.Drawing.Size(360, 325);
            this.filePathPanel.TabIndex = 15;
            // 
            // ReplaceInEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "ReplaceInEditorView";
            this.Size = new System.Drawing.Size(776, 435);
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
    }
}

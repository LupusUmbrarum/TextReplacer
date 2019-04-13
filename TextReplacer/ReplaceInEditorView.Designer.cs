namespace TextReplacer
{
    partial class ReplaceInEditorView
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.replaceTextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clearWordPairButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.targetTextTextBox = new System.Windows.Forms.TextBox();
            this.newTextTextBox = new System.Windows.Forms.TextBox();
            this.addWordPairButton = new System.Windows.Forms.Button();
            this.wordPairPanel = new System.Windows.Forms.Panel();
            this.wizardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.AcceptsTab = true;
            this.richTextBox.Location = new System.Drawing.Point(410, 3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(363, 429);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            this.richTextBox.Click += new System.EventHandler(this.genericOnClick);
            // 
            // replaceTextButton
            // 
            this.replaceTextButton.Location = new System.Drawing.Point(320, 399);
            this.replaceTextButton.Name = "replaceTextButton";
            this.replaceTextButton.Size = new System.Drawing.Size(84, 25);
            this.replaceTextButton.TabIndex = 26;
            this.replaceTextButton.Text = "Replace Text";
            this.replaceTextButton.UseVisualStyleBackColor = true;
            this.replaceTextButton.Click += new System.EventHandler(this.replaceTextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Word Pairs (TargetText->NewText)";
            // 
            // clearWordPairButton
            // 
            this.clearWordPairButton.Location = new System.Drawing.Point(343, 11);
            this.clearWordPairButton.Name = "clearWordPairButton";
            this.clearWordPairButton.Size = new System.Drawing.Size(61, 25);
            this.clearWordPairButton.TabIndex = 33;
            this.clearWordPairButton.Text = "Clear";
            this.clearWordPairButton.UseVisualStyleBackColor = true;
            this.clearWordPairButton.Click += new System.EventHandler(this.clearWordPairButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "with:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Replace:";
            // 
            // targetTextTextBox
            // 
            this.targetTextTextBox.Location = new System.Drawing.Point(57, 13);
            this.targetTextTextBox.Name = "targetTextTextBox";
            this.targetTextTextBox.Size = new System.Drawing.Size(86, 20);
            this.targetTextTextBox.TabIndex = 28;
            this.targetTextTextBox.Click += new System.EventHandler(this.genericOnClick);
            this.targetTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
            // 
            // newTextTextBox
            // 
            this.newTextTextBox.Location = new System.Drawing.Point(184, 13);
            this.newTextTextBox.Name = "newTextTextBox";
            this.newTextTextBox.Size = new System.Drawing.Size(86, 20);
            this.newTextTextBox.TabIndex = 29;
            this.newTextTextBox.Click += new System.EventHandler(this.genericOnClick);
            this.newTextTextBox.TextChanged += new System.EventHandler(this.newTextTextBox_TextChanged);
            this.newTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.generalKeyDown);
            // 
            // addWordPairButton
            // 
            this.addWordPairButton.Location = new System.Drawing.Point(276, 11);
            this.addWordPairButton.Name = "addWordPairButton";
            this.addWordPairButton.Size = new System.Drawing.Size(61, 25);
            this.addWordPairButton.TabIndex = 31;
            this.addWordPairButton.Text = "Add";
            this.addWordPairButton.UseVisualStyleBackColor = true;
            this.addWordPairButton.Click += new System.EventHandler(this.addWordPairButton_Click);
            // 
            // wordPairPanel
            // 
            this.wordPairPanel.AutoScroll = true;
            this.wordPairPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordPairPanel.Location = new System.Drawing.Point(29, 63);
            this.wordPairPanel.Name = "wordPairPanel";
            this.wordPairPanel.Size = new System.Drawing.Size(358, 325);
            this.wordPairPanel.TabIndex = 27;
            // 
            // wizardButton
            // 
            this.wizardButton.Location = new System.Drawing.Point(19, 399);
            this.wizardButton.Name = "wizardButton";
            this.wizardButton.Size = new System.Drawing.Size(75, 23);
            this.wizardButton.TabIndex = 35;
            this.wizardButton.Text = "Wizard";
            this.wizardButton.UseVisualStyleBackColor = true;
            this.wizardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReplaceInEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wizardButton);
            this.Controls.Add(this.replaceTextButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearWordPairButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetTextTextBox);
            this.Controls.Add(this.newTextTextBox);
            this.Controls.Add(this.addWordPairButton);
            this.Controls.Add(this.wordPairPanel);
            this.Controls.Add(this.richTextBox);
            this.Name = "ReplaceInEditorView";
            this.Size = new System.Drawing.Size(776, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button replaceTextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearWordPairButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetTextTextBox;
        private System.Windows.Forms.TextBox newTextTextBox;
        private System.Windows.Forms.Button addWordPairButton;
        private System.Windows.Forms.Panel wordPairPanel;
        private System.Windows.Forms.Button wizardButton;
    }
}

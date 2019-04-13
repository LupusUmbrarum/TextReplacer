using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplacer
{
    public partial class ReplaceInEditorView : UserControl, WizardFriendly
    {
        private List<WordPair> pairs = new List<WordPair>();

        public ReplaceInEditorView()
        {
            InitializeComponent();

            wordPairPanel.HorizontalScroll.Enabled = false;
            wordPairPanel.HorizontalScroll.Maximum = 0;
            wordPairPanel.AutoScroll = false;
            wordPairPanel.VerticalScroll.Visible = true;
            wordPairPanel.AutoScroll = true;
        }

        private void addWordPairButton_Click(object sender, EventArgs e)
        {
            addWordPair(targetTextTextBox.Text, newTextTextBox.Text, false);
        }

        private void clearWordPairButton_Click(object sender, EventArgs e)
        {
            wordPairPanel.Controls.Clear();
            pairs.Clear();
        }

        private void replaceTextButton_Click(object sender, EventArgs e)
        {
            replaceText();
        }

        private void replaceText()
        {
            if (richTextBox.Text.Length <= 0 || pairs.Count <= 0)
            {
                return;
            }

            foreach (WordPair pair in pairs)
            {
                string[] lines = richTextBox.Lines;

                for (int x = 0; x < lines.Length; x++)
                {
                    while (lines[x].Contains(pair.target))
                    {
                        // replace
                        string cline = lines[x];
                        int tlen = pair.target.Length;
                        string a = cline.Substring(0, cline.IndexOf(pair.target));
                        string b = cline.Substring(cline.IndexOf(pair.target) + pair.target.Length);

                        lines[x] = a + pair.newText + b;
                    }
                }

                richTextBox.Lines = lines;
            }

            MessageBox.Show("Finished");
        }

        void WizardFriendly.addWordPair_Wizard(string targetText, string newText)
        {
            addWordPair(targetText, newText, true);
        }

        void WizardFriendly.removeWordPair_Wizard(WordPair wp)
        {
            int location = 0;

            for (int i = 0; i < pairs.Count; i++)
            {
                if (pairs[i] == wp)
                {
                    wordPairPanel.Controls.Remove(wp.panel);
                    location = i;
                }
            }

            for (; location < pairs.Count; location++)
            {
                pairs[location].panel.SetBounds(pairs[location].panel.Location.X, (location > 0 ? location - 1 : location) * pairs[location].panel.Height, pairs[location].panel.Width, pairs[location].panel.Height);
            }

            pairs.Remove(wp);
        }

        void WizardFriendly.addFile_Wizard(string path)
        {

        }

        void WizardFriendly.removeFile_Wizard(VisualFile vf)
        {

        }

        void addWordPair(string targetText, string newText, bool fromWizard)
        {
            if(targetText.Length <= 0 || newText.Length <= 0)
            {
                return;
            }

            if (!newText.Contains(targetText))
            {
                WordPair wp = new WordPair(targetText, newText);

                wp.MakeVisual(ref wordPairPanel, this);

                pairs.Add(wp);
            }
            else
            {
                MessageBox.Show("The new text cannot contain the old text", "Error");
            }

            if (!fromWizard)
            {
                targetTextTextBox.Text = "";
                newTextTextBox.Text = "";
                targetTextTextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordPairWizard wpw = new WordPairWizard(this);
            wpw.ShowDialog();
        }

        private void generalKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addWordPair(targetTextTextBox.Text, newTextTextBox.Text, false);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void genericOnClick(object sender, EventArgs e)
        {
            try
            {
                ((TextBox)sender).SelectAll();
                ((TextBox)sender).Focus();
            }
            catch(InvalidCastException icex)
            {
                ((RichTextBox)sender).SelectAll();
                ((RichTextBox)sender).Focus();
                icex.GetBaseException();
            }
            catch(Exception ex) { ex.GetBaseException(); }
        }

        private void newTextTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }// end class ReplaceInEditorView
}// end namespace TextReplacer

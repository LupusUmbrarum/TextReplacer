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
        }

        private void addWordPairButton_Click(object sender, EventArgs e)
        {
            addWordPair();
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

        private void generalPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addWordPair();
            }
        }

        private void addWordPair()
        {
            if (targetTextTextBox.Text.Length > 0 && newTextTextBox.Text.Length > 0)
            {
                WordPair wp = new WordPair(targetTextTextBox.Text, newTextTextBox.Text);
                pairs.Add(wp);
                Label l = new Label();
                l.Text = wp.target + " -> " + wp.newText;
                l.Width = l.Text.Length * 10;
                int count = wordPairPanel.Controls.Count;
                l.SetBounds(l.Bounds.X, count * l.Height + 15, l.Width, l.Height);
                wordPairPanel.Controls.Add(l);

                targetTextTextBox.Text = "";
                newTextTextBox.Text = "";
                targetTextTextBox.Focus();
            }
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
            WordPair wp = new WordPair(targetText, newText);
            pairs.Add(wp);
            Label l = new Label();
            l.Text = wp.target + " -> " + wp.newText;
            l.Width = l.Text.Length * 10;
            int count = wordPairPanel.Controls.Count;
            l.SetBounds(l.Bounds.X, count * l.Height + 15, l.Width, l.Height);
            wordPairPanel.Controls.Add(l);
        }

        void WizardFriendly.removeWordPair_Wizard(WordPair wp)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordPairWizard wpw = new WordPairWizard(this);
            wpw.ShowDialog();
        }
    }// end class ReplaceInEditorView
}// end namespace TextReplacer

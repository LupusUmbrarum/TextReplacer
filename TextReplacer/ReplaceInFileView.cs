using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextReplacer
{
    public partial class ReplaceInFileView : UserControl, WizardFriendly
    {
        private List<string> files = new List<string>();
        private List<WordPair> pairs = new List<WordPair>();

        public ReplaceInFileView()
        {
            InitializeComponent();
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in ofd.FileNames)
                {
                    try
                    {
                        Label nl = new Label();
                        nl.Text = file;
                        nl.Width = nl.Text.Length * 10;
                        int count = filePathPanel.Controls.Count;
                        int h = nl.Height;
                        nl.SetBounds(nl.Location.X, count * h + 15, nl.Width, nl.Height);
                        filePathPanel.Controls.Add(nl);
                        files.Add(file);
                    }
                    catch (Exception ex) { ex.GetBaseException(); }
                }
            }
        }

        private void clearFilesButton_Click(object sender, EventArgs e)
        {
            filePathPanel.Controls.Clear();
            files.Clear();
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
            if (files.Count <= 0 || pairs.Count <= 0)
            {
                return;
            }

            foreach (WordPair pair in pairs)
            {
                foreach (String file in files)
                {
                    try
                    {
                        string extension = file.Substring(file.LastIndexOf('.'));

                        if (extension == ".docx" || extension == ".doc")
                        {
                            object fileName = Path.Combine(System.Windows.Forms.Application.StartupPath, "file");

                            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: false);

                            aDoc.Activate();
                            wordDocFindAndReplace(wordApp, pair.target, pair.newText);
                            aDoc.Save();
                        }

                        string[] lines = File.ReadAllLines(file);

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

                        File.WriteAllLines(file, lines);
                    }
                    catch (Exception ex) { ex.GetBaseException(); }
                }
            }

            MessageBox.Show("Finished");
        }

        private void wordDocFindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceText)
        {
            // options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            // execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
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

        private void button1_Click(object sender, EventArgs e)
        {
            WordPairWizard wpw = new WordPairWizard(this);
            wpw.ShowDialog();
        }

        private void createNewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            byGroupCheckBox.Enabled = !createNewCheckBox.Checked;
            onCreateCheckBox.Enabled = !createNewCheckBox.Checked;
        }

        private void byGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void onCreateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

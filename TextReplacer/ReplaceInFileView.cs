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

        bool createNew = false, byGroup = false, nameOnCreate = false, matchCase = false;

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
                addWordPair(targetTextTextBox.Text, newTextTextBox.Text, false);
            }
        }
        
        private void replaceText()
        {
            if (files.Count <= 0 || pairs.Count <= 0)
            {
                return;
            }

            if(createNew)
            {
                if(byGroup)
                {
                    // create a copy of the wordpair list
                    List<WordPair> sortedPairs = pairs;

                    // sort the pairs by groupnumber
                    for(int i = 0; i < sortedPairs.Count - 1; i++)
                    {
                        for(int j = i; j < sortedPairs.Count - i - 1; j++)
                        {
                            if(sortedPairs[j].groupNum > sortedPairs[j + 1].groupNum)
                            {
                                WordPair temp = sortedPairs[j];
                                sortedPairs[j] = sortedPairs[j + 1];
                                sortedPairs[j + 1] = temp;
                            }
                        }
                    }

                    // go through the list of sorted pairs
                    while(sortedPairs.Count > 0)
                    {
                        int groupNum = sortedPairs[0].groupNum;

                        List<WordPair> subGroup = new List<WordPair>();

                        // populate the subGroup with wordpairs that have the same groupnumber
                        for (int i = 0; i < sortedPairs.Count; i++)
                        {
                            if(groupNum == sortedPairs[i].groupNum)
                            {
                                subGroup.Add(sortedPairs[i]);
                                sortedPairs.RemoveAt(i);
                                i--;
                            }
                        }

                        for(int i = 0; i < subGroup.Count; i++)
                        {
                            WordPair pair = subGroup[i];

                            foreach (String file in files)
                            {
                                try
                                {
                                    string extension = file.Substring(file.LastIndexOf('.'));

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

                                    if(nameOnCreate)
                                    {
                                        //open sfd
                                        //use path to File.writealllines
                                    }
                                    else
                                    {
                                        File.WriteAllLines(file + groupNum.ToString(), lines);
                                    }
                                }
                                catch (Exception ex) { ex.GetBaseException(); }
                            }
                        }
                    }
                }
            }

            foreach (WordPair pair in pairs)
            {
                foreach (String file in files)
                {
                    try
                    {
                        string extension = file.Substring(file.LastIndexOf('.'));

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
            int location = 0;

            for(int i = 0; i < pairs.Count; i++)
            {
                if(pairs[i] == wp)
                {
                    wordPairPanel.Controls.Remove(wp.panel);
                    location = i;
                }
            }

            for(;location < pairs.Count; location++)
            {
                pairs[location].panel.SetBounds(pairs[location].panel.Location.X, (location > 0 ? location-1 : location) * pairs[location].panel.Height, pairs[location].panel.Width, pairs[location].panel.Height);
            }

            pairs.Remove(wp);
        }

        void addWordPair(string targetText, string newText, bool fromWizard)
        {
            WordPair wp = new WordPair(targetTextTextBox.Text, newTextTextBox.Text);

            wp.MakeVisual(ref wordPairPanel, this);

            if(!fromWizard)
            {
                targetTextTextBox.Text = "";
                newTextTextBox.Text = "";
                targetTextTextBox.Focus();
            }
        }

        void WizardFriendly.addFile_Wizard(string path)
        {

        }

        void WizardFriendly.removeFile_Wizard(VisualFile vf)
        {

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
            createNew = createNewCheckBox.Checked;
        }

        private void byGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            byGroup = byGroupCheckBox.Checked;
        }

        private void onCreateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nameOnCreate = onCreateCheckBox.Checked;
        }

        private void matchCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            matchCase = matchCaseCheckBox.Checked;
        }
    }
}

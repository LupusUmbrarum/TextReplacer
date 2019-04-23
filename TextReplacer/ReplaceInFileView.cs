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
        private List<VisualFile> files = new List<VisualFile>();
        private List<WordPair> pairs = new List<WordPair>();

        bool createNew = false, byGroup = false, nameOnCreate = false, matchCase = false;

        public ReplaceInFileView()
        {
            InitializeComponent();

            filePathPanel.HorizontalScroll.Enabled = false;
            filePathPanel.HorizontalScroll.Maximum = 0;
            filePathPanel.AutoScroll = false;
            filePathPanel.VerticalScroll.Visible = true;
            filePathPanel.AutoScroll = true;

            wordPairPanel.HorizontalScroll.Enabled = false;
            wordPairPanel.HorizontalScroll.Maximum = 0;
            wordPairPanel.AutoScroll = false;
            wordPairPanel.VerticalScroll.Visible = true;
            wordPairPanel.AutoScroll = true;
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in ofd.FileNames)
                {
                    try
                    {
                        VisualFile vf = new VisualFile(file);
                        vf.MakeVisual(ref filePathPanel, this, ofd);
                        files.Add(vf);
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

            foreach(WordPair pair in pairs)
            {
                if((matchCase && pair.newText.Contains(pair.target)) || pair.newText.ToUpper().Contains(pair.target.ToUpper()))
                {
                    MessageBox.Show("The new text cannot contain the old text", "Error");
                    return;
                }
            }

            if(createNew)
            {
                if(byGroup)
                {
                    // create a copy of the wordpair list
                    WordPair[] sortedPairs = pairs.ToArray();


                    // sort the pairs by groupnumber
                    for(int i = 0; i < sortedPairs.Length - 1; i++)
                    {
                        for(int j = i; j < sortedPairs.Length - i - 1; j++)
                        {
                            if(sortedPairs[j].groupNum > sortedPairs[j + 1].groupNum)
                            {
                                WordPair temp = sortedPairs[j];
                                sortedPairs[j] = sortedPairs[j + 1];
                                sortedPairs[j + 1] = temp;
                            }
                        }
                    }

                    List<WordPair> sortedList = sortedPairs.ToList<WordPair>();

                    // go through the list of sorted pairs
                    while(sortedList.Count > 0)
                    {
                        int groupNum = sortedList[0].groupNum;

                        List<WordPair> subGroup = new List<WordPair>();

                        // populate the subGroup with wordpairs that have the same groupnumber
                        for (int i = 0; i < sortedList.Count; i++)
                        {
                            if(groupNum == sortedList[i].groupNum)
                            {
                                subGroup.Add(sortedList[i]);
                                sortedList.RemoveAt(i);
                                i--;
                            }
                        }
                        
                        foreach (VisualFile file in files)
                        {
                            string[] lines = File.ReadAllLines(file.path);

                            for (int i = 0; i < subGroup.Count; i++)
                            {
                                WordPair pair = subGroup[i];

                                try
                                {
                                    string extension = file.path.Substring(file.path.LastIndexOf('.'));

                                    for (int x = 0; x < lines.Length; x++)
                                    {
                                        if(matchCase)
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
                                        else
                                        {
                                            while (lines[x].ToUpper().Contains(pair.target.ToUpper()))
                                            {
                                                // replace
                                                string cline = lines[x];
                                                int tlen = pair.target.Length;
                                                string a = cline.ToUpper().Substring(0, cline.ToUpper().IndexOf(pair.target.ToUpper()));
                                                string b = cline.ToUpper().Substring(cline.ToUpper().IndexOf(pair.target.ToUpper()) + pair.target.Length);

                                                lines[x] = a + pair.newText + b;
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex) { ex.GetBaseException(); }
                            }

                            if (nameOnCreate && file.path.Substring(file.path.Length - 4) == ".txt")
                            {
                                try
                                {
                                    File.WriteAllLines(SaveOnCreate(file.path), lines);
                                }
                                catch(Exception ex) { ex.GetBaseException(); }
                            }
                            else
                            {
                                try
                                {
                                    File.WriteAllLines(file.path.Insert(file.path.Length - 4, groupNum.ToString()), lines);
                                }
                                catch(Exception ex) { ex.GetBaseException(); }
                            }
                        }
                    }
                }
                else
                {
                    // change every word pair in every file without creating an output file
                    for(int i = 0; i < files.Count; i++)
                    {
                        string file = files[i].path;

                        string[] lines = File.ReadAllLines(file);

                        foreach (WordPair pair in pairs)
                        {
                            try
                            {
                                string extension = file.Substring(file.LastIndexOf('.'));

                                for (int x = 0; x < lines.Length; x++)
                                {
                                    if (matchCase)
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
                                    else
                                    {
                                        while (lines[x].ToUpper().Contains(pair.target.ToUpper()))
                                        {
                                            // replace
                                            string cline = lines[x];
                                            int tlen = pair.target.Length;
                                            string a = cline.ToUpper().Substring(0, cline.ToUpper().IndexOf(pair.target.ToUpper()));
                                            string b = cline.ToUpper().Substring(cline.ToUpper().IndexOf(pair.target.ToUpper()) + pair.target.Length);

                                            lines[x] = a + pair.newText + b;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex) { ex.GetBaseException(); }
                        }

                        if (nameOnCreate && file.Substring(file.Length - 4) == ".txt")
                        {
                            try
                            {
                                File.WriteAllLines(SaveOnCreate(file), lines);
                            }
                            catch (Exception ex) { ex.GetBaseException(); }
                        }
                        else
                        {
                            try
                            {
                                File.WriteAllLines(file.Insert(file.Length - 4, i.ToString()), lines);
                            }
                            catch (Exception ex) { ex.GetBaseException(); }
                        }
                    }
                }
            }
            else
            {
                // change every word pair in every file without creating an output file
                foreach (WordPair pair in pairs)
                {
                    foreach (VisualFile file in files)
                    {
                        try
                        {
                            string extension = file.path.Substring(file.path.LastIndexOf('.'));

                            string[] lines = File.ReadAllLines(file.path);

                            for (int x = 0; x < lines.Length; x++)
                            {
                                if (matchCase)
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
                                else
                                {
                                    while (lines[x].ToUpper().Contains(pair.target.ToUpper()))
                                    {
                                        // replace
                                        string cline = lines[x];
                                        int tlen = pair.target.Length;
                                        string a = cline.ToUpper().Substring(0, cline.ToUpper().IndexOf(pair.target.ToUpper()));
                                        string b = cline.ToUpper().Substring(cline.ToUpper().IndexOf(pair.target.ToUpper()) + pair.target.Length);

                                        lines[x] = a + pair.newText + b;
                                    }
                                }
                            }

                            try
                            {
                                File.WriteAllLines(file.path, lines);
                            }
                            catch(Exception ex) { ex.GetBaseException(); }
                        }
                        catch (Exception ex) { ex.GetBaseException(); }
                    }
                }
            }

            MessageBox.Show("Finished");
        }

        string SaveOnCreate(string str)
        {
            sfd.FileName = str;

            sfd.Filter = "Text Documents (*.txt)|*.txt";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName;
            }

            return str;
        }

        void WizardFriendly.addWordPair_Wizard(string targetText, string newText)
        {
            addWordPair(targetText, newText, true);
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
            if(!newText.Contains(targetText))
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

        void WizardFriendly.addFile_Wizard(string path)
        {

        }

        void WizardFriendly.removeFile_Wizard(VisualFile vf)
        {
            int location = 0;

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i] == vf)
                {
                    filePathPanel.Controls.Remove(vf.panel);
                    location = i;
                }
            }

            for (; location < files.Count; location++)
            {
                files[location].panel.SetBounds(files[location].panel.Location.X, (location > 0 ? location - 1 : location) * files[location].panel.Height, files[location].panel.Width, files[location].panel.Height);
            }

            files.Remove(vf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordPairWizard wpw = new WordPairWizard(this);
            wpw.ShowDialog();
        }

        private void createNewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            byGroupCheckBox.Enabled = createNewCheckBox.Checked;
            onCreateCheckBox.Enabled = createNewCheckBox.Checked;
            createNew = createNewCheckBox.Checked;
        }

        private void generalKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addWordPair();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void onNewTextBoxClick(object sender, EventArgs e)
        {
            newTextTextBox.SelectAll();
            newTextTextBox.Focus();
        }

        private void matchCaseCheckedChanged(object sender, EventArgs e)
        {
            matchCase = matchCaseCheckBox.Checked;
        }

        private void onTargetBoxClick(object sender, EventArgs e)
        {
            targetTextTextBox.SelectAll();
            targetTextTextBox.Focus();
        }

        private void byGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            byGroup = byGroupCheckBox.Checked;
        }

        private void onCreateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nameOnCreate = onCreateCheckBox.Checked;
        }
    }
}

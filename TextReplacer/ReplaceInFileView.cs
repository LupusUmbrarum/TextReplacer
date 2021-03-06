﻿using System;
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
    public partial class ReplaceInFileView : UserControl, WizardFriendly, Configurable
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
			addFiles();
        }

		public void addFiles()
		{
			ofd.Multiselect = true;
			ofd.Title = "Open File(s)";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				foreach (String file in ofd.FileNames)
				{
					addVisualFile(file);
				}
			}
		}

        private void clearFilesButton_Click(object sender, EventArgs e)
        {
			if (files.Count > 0 && !confirmAction("Are you sure you want to clear the list of Files?", "Confirm"))
			{
				return;
			}

			filePathPanel.Controls.Clear();
            files.Clear();
        }

        private void addWordPairButton_Click(object sender, EventArgs e)
        {
            addWordPair();
        }

        private void clearWordPairButton_Click(object sender, EventArgs e)
        {
			if(pairs.Count > 0 && !confirmAction("Are you sure you want to clear the list of Word Pairs?", "Confirm"))
			{
				return;
			}

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
			// check to see if the number of pairs or the number of files is less than zero.
			// If so, exit
            if (files.Count <= 0 || pairs.Count <= 0)
            {
                return;
            }

			// check to see if the file has been moved or deleted since adding
			foreach(VisualFile cfile in files)
			{
				if(!File.Exists(cfile.path))
				{
					MessageBox.Show("The file \"" + cfile.path + "\" has either been moved or no longer exists. \nPlease remove from files.", "Error");
					return;
				}
			}

			// check to see if any of the wordpairs' new text contains the old text (so we 
			// don't have any infinite loops caused by overwriting changes)
            foreach(WordPair pair in pairs)
            {
                if((matchCase && pair.newText.Contains(pair.target)) || pair.newText.ToUpper().Contains(pair.target.ToUpper()))
                {
                    MessageBox.Show("The new text cannot contain the old text", "Error");
                    return;
                }
            }

			// TODO: check to see if the target of any wordpair equals the source of a wordpair, 
			// so as to avoid infinite loops. Should also be checked in the addwordpair sections

			int numChanges = 0;

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

									replaceTextByLine(ref numChanges, lines, pair);
								}
                                catch (Exception ex) { ex.GetBaseException(); }
                            }

                            if (nameOnCreate /*&& file.path.Substring(file.path.Length - 4) == ".txt"*/)
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
                    // change every word pair in every file without creating a new output file
                    for(int i = 0; i < files.Count; i++)
                    {
                        string file = files[i].path;

                        string[] lines = File.ReadAllLines(file);

                        foreach (WordPair pair in pairs)
                        {
                            try
                            {
								replaceTextByLine(ref numChanges, lines, pair);
							}
                            catch (Exception ex) { ex.GetBaseException(); }
                        }

                        if (nameOnCreate /*&& file.Substring(file.Length - 4) == ".txt"*/)
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
                // change every word pair in every file without creating a new output file
                foreach (WordPair pair in pairs)
                {
                    foreach (VisualFile file in files)
                    {
                        try
                        {
                            string[] lines = File.ReadAllLines(file.path);

							replaceTextByLine(ref numChanges, lines, pair);

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

            MessageBox.Show("Finished\n" + numChanges.ToString() + " changes made.");
        }

		void replaceTextByPair()
		{

		}

		/// <summary>
		/// Does the actual replacing of text line by line
		/// </summary>
		/// <param name="numChanges"></param>
		/// <param name="lines"></param>
		/// <param name="pair"></param>
		void replaceTextByLine(ref int numChanges, string[] lines, WordPair pair)
		{
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
						string b = cline.Substring(cline.IndexOf(pair.target) + tlen);

						lines[x] = a + pair.newText + b;

						numChanges++;
					}
				}
				else
				{
					while (lines[x].ToUpper().Contains(pair.target.ToUpper()))
					{
						// replace
						string cline = lines[x];
						int tlen = pair.target.Length;
						string a = cline.Substring(0, cline.ToUpper().IndexOf(pair.target.ToUpper()));
						string b = cline.Substring(cline.ToUpper().IndexOf(pair.target.ToUpper()) + tlen);

						lines[x] = a + pair.newText + b;

						numChanges++;
					}
				}
			}
		}

        string SaveOnCreate(string str)
        {
            sfd.FileName = str.Substring(str.LastIndexOf('\\') + 1);

			string extraExtension = str.Substring(str.LastIndexOf(".") + 1);
			string capExtension = extraExtension.ToUpper();
			string fullExtraExtension = capExtension + " (*." + extraExtension + ")|*." + extraExtension;
			string normalExtension = "TXT (*.txt)|*.txt|All Files (*.*)|*.*";

			if(capExtension != "TXT")
			{
				sfd.Filter = fullExtraExtension + "|" + normalExtension;
				sfd.FilterIndex = 0;
			}
			else
			{
				sfd.Filter = normalExtension;
			}

			sfd.AddExtension = true;

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

        void addWordPair(string targetText, string newText, bool fromWizard, string groupNum = "0")
        {
            if(!newText.Contains(targetText))
            {
                WordPair wp = new WordPair(targetText, newText, groupNum);

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

		void addVisualFile(string file)
		{
			try
			{
				VisualFile vf = new VisualFile(file);
				vf.MakeVisual(ref filePathPanel, this, ofd);
				files.Add(vf);
			}
			catch (Exception ex) { ex.GetBaseException(); }
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
                files[location].panel.SetBounds(
					files[location].panel.Location.X, 
					// the Y position is the only one that should be updated
					// if the index (location) of the panel is greater than 0, use 
					// the previous panel's location. Otherwise, use this panel's location
					(location > 0 ? location - 1 : location) * files[location].panel.Height, 
					files[location].panel.Width, 
					files[location].panel.Height);
            }

			filePathPanel.Refresh();

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
            //newTextTextBox.SelectAll();
            //newTextTextBox.Focus();
        }

        private void matchCaseCheckedChanged(object sender, EventArgs e)
        {
            matchCase = matchCaseCheckBox.Checked;
        }

		private void filePathPanel_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			foreach(String file in fileList)
			{
				addVisualFile(file);
			}
		}

		private void filePathPanel_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void onTargetBoxClick(object sender, EventArgs e)
        {
            //targetTextTextBox.SelectAll();
            //targetTextTextBox.Focus();
        }

		private void onTargetBoxFocus(object sender, EventArgs e)
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

		private bool confirmAction(string message, string caption)
		{
			DialogResult res = MessageBox.Show(this, message, caption, MessageBoxButtons.YesNoCancel);

			if(res == DialogResult.Yes)
			{
				return true;
			}

			return false;
		}

		Configuration Configurable.getConfiguration()
		{
			Configuration conf = new Configuration();

			conf.options.createNewFiles = createNew;
			conf.options.createByGroup = byGroup;
			conf.options.createFileManuallyOnCreate = nameOnCreate;
			conf.options.matchCase = matchCase;

			conf.files = files.ToArray();

			conf.pairs = pairs.ToArray();

			conf.text = "";

			return conf;
		}

		void Configurable.setConfiguration(Configuration config)
		{
			clearConfiguration();

			if(config.options.createNewFiles)
			{
				createNew = true;
				createNewCheckBox.Checked = true;
			}

			if (config.options.createByGroup)
			{
				byGroup = true;
				byGroupCheckBox.Checked = true;
			}

			if (config.options.createFileManuallyOnCreate)
			{
				nameOnCreate = true;
				onCreateCheckBox.Checked = true;
			}

			if (config.options.matchCase)
			{
				matchCase = true;
				matchCaseCheckBox.Checked = true;
			}

			for(int i = 0; i < config.files.Length; i++)
			{
				addVisualFile(config.files[i].path);
			}

			for (int i = 0; i < config.pairs.Length; i++)
			{
				addWordPair(config.pairs[i].target, config.pairs[i].newText, true, config.pairs[i].group);
			}
		}

		void clearConfiguration()
		{
			wordPairPanel.Controls.Clear();
			pairs.Clear();

			filePathPanel.Controls.Clear();
			files.Clear();
		}
	}
}

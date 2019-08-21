using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplacer
{
    public partial class TextReplacer : Form
    {
        private string version = "v1.5";
		private ReplaceInFileView rifv;
		private ReplaceInEditorView riev;
		private string currentFile = "";

		public TextReplacer()
        {
            InitializeComponent();

            Text = "TextReplacer - " + version;

			rifv = new ReplaceInFileView();
			riev = new ReplaceInEditorView();

            inFileTab.Controls.Add(rifv);
            inEditorTab.Controls.Add(riev);

			MessageBox.Show(Properties.Settings.Default.recentFiles);
			Properties.Settings.Default["recentFiles"] = "test";
			Properties.Settings.Default.Save();
        }

		private void inFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// tab 0 should be in file(s)
			tabControl.SelectTab(0);
		}

		private void inEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// tab 1 should be in editor
			tabControl.SelectTab(1);
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ofd.Multiselect = true;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				foreach (String file in ofd.FileNames)
				{
					loadConfiguration(ofd.FileName);
				}
			}
		}

		private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(currentFile == "")
			{
				saveAs();
			}
			else
			{
				saveConfiguration(currentFile);
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveAs();
		}

		private void saveAs()
		{
			sfd.OverwritePrompt = true;
			sfd.AddExtension = true;
			sfd.Filter = "TRC (*.trc)|*.trc";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				saveConfiguration(sfd.FileName);
			}
		}

		private void saveConfiguration(string path)
		{
			// clear the file of previous text
			System.IO.File.WriteAllText(path, string.Empty);

			Configuration rifvConf, rievConf;

			rifvConf = ((Configurable)rifv).getConfiguration();
			rievConf = ((Configurable)riev).getConfiguration();

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
			{
				// write all the values for rifv first

				// write down the createNew option value
				file.WriteLine(rifvConf.options.createNewFiles);

				// write down the createByGroup option value
				file.WriteLine(rifvConf.options.createByGroup);

				// write down the createFileManually option value
				file.WriteLine(rifvConf.options.createFileManuallyOnCreate);

				// write down the matchCase option value
				file.WriteLine(rifvConf.options.matchCase);

				// write all the values of the paths used
				for(int i = 0; i < rifvConf.files.Length; i++)
				{
					file.WriteLine(rifvConf.files[i].path);
				}

				file.WriteLine("<|>--END OF FILES--<|>");

				// write all the values of the wordpairs used
				for (int i = 0; i < rifvConf.pairs.Length; i++)
				{
					file.WriteLine(rifvConf.pairs[i].target);
					file.WriteLine(rifvConf.pairs[i].newText);
					file.WriteLine(rifvConf.pairs[i].groupNum);
				}

				file.WriteLine("<|>--END OF RIFV--<|>");

				// write all the values for riev second

				// write down the createNew option value
				file.WriteLine(rievConf.options.createNewFiles);

				// write down the createByGroup option value
				file.WriteLine(rievConf.options.createByGroup);

				// write down the createFileManually option value
				file.WriteLine(rievConf.options.createFileManuallyOnCreate);

				// write down the matchCase option value
				file.WriteLine(rievConf.options.matchCase);

				// write down the richTextBox text
				file.WriteLine(rievConf.text);

				// write all the values for the wordpairs
				for (int i = 0; i < rievConf.pairs.Length; i++)
				{
					file.WriteLine(rievConf.pairs[i].target);
					file.WriteLine(rievConf.pairs[i].newText);
					file.WriteLine(rievConf.pairs[i].groupNum);
				}

				file.WriteLine("<|>--END OF RIEV--<|>");
			}

			currentFile = path;
		}

		private void loadConfiguration(string path)
		{
			try
			{
				Configuration rifvConf = new Configuration(), rievConf = new Configuration();

				// get all of the lines in the file
				string[] lines = File.ReadAllLines(path);

				int index = 0;

				string[] optionsArray = { "", "", "", "" };

				// get the rifv config

				// get the options
				for(int i = 0; i < 4; i++)
				{
					optionsArray[i] = lines[index++];
				}

				// set the options
				rifvConf.options.createNewFiles = optionsArray[0] == "True";
				rifvConf.options.createByGroup = optionsArray[1] == "True";
				rifvConf.options.createFileManuallyOnCreate = optionsArray[2] == "True";
				rifvConf.options.matchCase = optionsArray[3] == "True";

				// get the file paths
				List<VisualFile> vfs = new List<VisualFile>();

				while (lines[index] != "<|>--END OF FILES--<|>")
				{
					vfs.Add(new VisualFile(lines[index]));
					index++;
				}

				rifvConf.files = vfs.ToArray();
				index++;

				// get the wordpairs
				List<WordPair> wps = new List<WordPair>();

				while (lines[index] != "<|>--END OF RIFV--<|>")
				{
					wps.Add(new WordPair(lines[index], lines[index + 1], lines[index + 2].ToString()));
					index += 3;
				}

				rifvConf.pairs = wps.ToArray();
				index++;

				wps.Clear();

				// get the riev config

				// get the options
				for (int i = 0; i < 4; i++)
				{
					optionsArray[i] = lines[index++];
				}

				// set the options
				rievConf.options.createNewFiles = optionsArray[0] == "True";
				rievConf.options.createByGroup = optionsArray[1] == "True";
				rievConf.options.createFileManuallyOnCreate = optionsArray[2] == "True";
				rievConf.options.matchCase = optionsArray[3] == "True";

				// get the richTextBox lines
				rievConf.text = lines[index++];

				// get the wordpairs
				while (lines[index] != "<|>--END OF RIEV--<|>")
				{
					wps.Add(new WordPair(lines[index], lines[index + 1], lines[index + 2].ToString()));
					index += 3;
				}

				rievConf.pairs = wps.ToArray();

				((Configurable)rifv).setConfiguration(rifvConf);
				((Configurable)riev).setConfiguration(rievConf);
			}
			catch(Exception ex) { ex.ToString(); MessageBox.Show("Error reading file"); return; }
		}
	}
}

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
        private string version = "v1.4";
		private ReplaceInFileView rifv;
		private ReplaceInEditorView riev;

		public TextReplacer()
        {
            InitializeComponent();

            Text = "TextReplacer - " + version;

			rifv = new ReplaceInFileView();
			riev = new ReplaceInEditorView();

            inFileTab.Controls.Add(rifv);
            inEditorTab.Controls.Add(riev);
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

		}

		private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveConfiguration(string path)
		{

		}
	}
}

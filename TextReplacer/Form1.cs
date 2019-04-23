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
        private List<string> files = new List<string>();
        private List<WordPair> pairs = new List<WordPair>();

        private string version = "v1.0";

        public TextReplacer()
        {
            InitializeComponent();

            Text = "TextReplacer - " + version;

            inFileTab.Controls.Add(new ReplaceInFileView());
            inEditorTab.Controls.Add(new ReplaceInEditorView());
        }
    }
}

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
        private string version = "v1.3";

        public TextReplacer()
        {
            InitializeComponent();

            Text = "TextReplacer - " + version;

            inFileTab.Controls.Add(new ReplaceInFileView());
            inEditorTab.Controls.Add(new ReplaceInEditorView());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplacer
{
    public partial class WordPairWizard : Form
    {
        private WizardFriendly wf;

        public WordPairWizard(WizardFriendly wf) : this()
        {
            this.wf = wf;
        }

        public WordPairWizard()
        {
            InitializeComponent();
        }

        private void generalPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addWordPair();
            }
        }

        private void addWordPairButton_Click(object sender, EventArgs e)
        {
            addWordPair();
        }

        private void addWordPair()
        {
            if (targetTextTextBox.Text.Length > 0 && newTextTextBox.Text.Length > 0)
            {
                wf.addWordPair_Wizard(targetTextTextBox.Text, newTextTextBox.Text);
            }
        }
    }
}

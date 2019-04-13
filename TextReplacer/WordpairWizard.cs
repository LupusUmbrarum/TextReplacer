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

        private void addWordPairButton_Click(object sender, EventArgs e)
        {
            addWordPairs();
        }

        private void addWordPairs()
        {
            if(targetTextTextBox.Text.Length <= 0 || !targetTextTextBox.Text.Contains("<_num_>"))
            {
                MessageBox.Show("A replace target must be specified");
                return;
            }
            
            if(startNumTextBox.Text.Length <= 0)
            {
                MessageBox.Show("You must have a beginning number");
                return;
            }

            int index = 0;

            if(!int.TryParse(startNumTextBox.Text, out index))
            {
                MessageBox.Show("The beginning value must be a number");
                return;
            }

            if(endNumTextBox.Text.Length <= 0)
            {
                MessageBox.Show("You must have an end number");
                return;
            }

            int finalValue = 0;

            if(!int.TryParse(endNumTextBox.Text, out finalValue))
            {
                MessageBox.Show("The end value must be a number");
                return;
            }

            if(stepNumTextBox.Text.Length <= 0)
            {
                MessageBox.Show("You must include a step value");
                return;
            }

            int step = 0;

            if(!int.TryParse(stepNumTextBox.Text, out step))
            {
                MessageBox.Show("The step value must be a number");
                return;
            }

            string preText = "", postText = "", midText = "";

            preText = targetTextTextBox.Text.Substring(0, targetTextTextBox.Text.IndexOf("<_num_>"));
            postText = targetTextTextBox.Text.Substring(targetTextTextBox.Text.IndexOf("<_num_>") + 7);

            string target = preText + index.ToString() + postText;

            if(index < finalValue)
            {
                index += step;
                for(; index <= finalValue; index += step)
                {
                    midText = index.ToString();
                    wf.addWordPair_Wizard(target, preText + midText + postText);
                }
            }
            else
            {
                index -= step;
                for(; index >= finalValue; index -= step)
                {
                    midText = index.ToString();
                    wf.addWordPair_Wizard(target, preText + midText + postText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addWordPairs();
        }

        private void generalKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            else
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (targetTextTextBox.Text == "")
            {
                targetTextTextBox.Focus();
                return;
            }

            if (startNumTextBox.Text == "")
            {
                startNumTextBox.Focus();
                return;
            }

            if (endNumTextBox.Text == "")
            {
                endNumTextBox.Focus();
                return;
            }

            if (stepNumTextBox.Text == "")
            {
                stepNumTextBox.Focus();
                return;
            }

            addWordPairs();
        }

        private void genericOnClick(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
            ((TextBox)sender).Focus();
        }
    }
}

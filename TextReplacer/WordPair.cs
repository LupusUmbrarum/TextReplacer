using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplacer
{
    public class WordPair
    {
        public int groupNum;
        public string target, newText, group;
        public Panel panel;
        TextBox targetBox, newBox, groupBox;
        Button remove;
        WizardFriendly parent;
        bool beenMadeVisual = false;

        public WordPair(string target, string newText, string group = "0")
        {
            this.target = target;
            this.newText = newText;
            this.group = group;

            if(!int.TryParse(group, out groupNum))
            {
                MessageBox.Show("Group number must be numeric", "Error");
            }
        }

        public void MakeVisual(ref Panel owningPanel, WizardFriendly parent)
        {
            if(beenMadeVisual)
            {
                return;
            }

            this.parent = parent;

            int count = owningPanel.Controls.Count;

            panel = new Panel();
            panel.BackColor = Color.Gray;
            panel.SetBounds(0, count * 25, owningPanel.Width - 21, 25);

            groupBox = new TextBox();
            groupBox.TextAlign = HorizontalAlignment.Left;
            groupBox.Text = group;
            groupBox.SetBounds(5, panel.Height / 2 - groupBox.Height / 2, 25, groupBox.Height);
            groupBox.TextChanged += editGroup;
            //groupBox.Click += this.onGroupBoxFocus;
            panel.Controls.Add(groupBox);

            targetBox = new TextBox();
            targetBox.SetBounds(groupBox.Location.X + groupBox.Width + 10, panel.Height / 2 - targetBox.Height / 2, owningPanel.Width / 3, targetBox.Height);
            targetBox.Text = target;
            targetBox.TextChanged += this.editWords;
            //targetBox.Click += this.onTargetBoxFocus;
            panel.Controls.Add(targetBox);

            Label arrow = new Label();
            arrow.Text = " -> ";
            arrow.SetBounds(targetBox.Location.X + targetBox.Width, panel.Height / 2 - arrow.Height / 2 + 2, 20, arrow.Height);
            panel.Controls.Add(arrow);

            newBox = new TextBox();
            newBox.SetBounds(arrow.Location.X + arrow.Width, panel.Height / 2 - newBox.Height / 2, owningPanel.Width / 3, newBox.Height);
            newBox.Text = newText;
            newBox.TextChanged += this.editWords;
            //newBox.Click += this.onNewBoxFocus;
            panel.Controls.Add(newBox);

            remove = new Button();
            int removeHeight = 25;
            remove.SetBounds(panel.Width - 30, panel.Height / 2 - removeHeight / 2 - 1, 25, removeHeight);
            remove.BackgroundImageLayout = ImageLayout.Stretch;
            remove.BackgroundImage = Properties.Resources.x_image2;
            remove.Click += new EventHandler(this.removeButtonHandler);
            panel.Controls.Add(remove);

            owningPanel.Controls.Add(panel);

            beenMadeVisual = true;
        }

        void removeButtonHandler(object sender, EventArgs e)
        {
            if(parent == null)
            {
                return;
            }

            parent.removeWordPair_Wizard(this);
        }

        void editWords(object sender, EventArgs e)
        {
            target = targetBox.Text;
            newText = newBox.Text;
        }

        void editGroup(object sender, EventArgs e)
        {
            if(groupBox.Text.Length > 0)
            {
                if (!int.TryParse(groupBox.Text, out groupNum))
                {
                    MessageBox.Show("Group number must be numeric", "Error");
                    groupBox.Text = group;
                }
                else
                {
                    group = groupNum.ToString();
                }
            }
        }

        void onGroupBoxFocus(object sender, EventArgs e)
        {
            groupBox.SelectAll();
            groupBox.Focus();
        }

        void onTargetBoxFocus(object sender, EventArgs e)
        {
            targetBox.SelectAll();
            targetBox.Focus();
        }

        void onNewBoxFocus(object sender, EventArgs e)
        {
            newBox.SelectAll();
            newBox.Focus();
        }
    }
}

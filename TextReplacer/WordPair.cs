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
        public string target, newText, group;
        Panel panel;
        TextBox targetBox, newBox, groupBox;
        Button remove;
        WizardFriendly parent;
        bool beenMadeVisual = false;

        public WordPair(string target, string newText, string group = "0")
        {
            this.target = target;
            this.newText = newText;
            this.group = group;
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
            panel.SetBounds(0, count * 25, owningPanel.Width - 4, 25);

            groupBox = new TextBox();
            groupBox.TextAlign = HorizontalAlignment.Left;
            groupBox.Text = group;
            groupBox.SetBounds(5, panel.Height / 2 - groupBox.Height / 2, 25, groupBox.Height);
            panel.Controls.Add(groupBox);

            targetBox = new TextBox();
            targetBox.SetBounds(groupBox.Location.X + groupBox.Width + 10, panel.Height / 2 - targetBox.Height / 2, owningPanel.Width / 4, targetBox.Height);
            targetBox.Text = target;
            panel.Controls.Add(targetBox);

            Label arrow = new Label();
            arrow.Text = " -> ";
            arrow.SetBounds(targetBox.Location.X + targetBox.Width, panel.Height / 2 - arrow.Height / 2 + 2, 20, arrow.Height);
            panel.Controls.Add(arrow);

            newBox = new TextBox();
            newBox.SetBounds(arrow.Location.X + arrow.Width, panel.Height / 2 - newBox.Height / 2, owningPanel.Width / 4, newBox.Height);
            newBox.Text = newText;
            panel.Controls.Add(newBox);

            owningPanel.Controls.Add(panel);

            beenMadeVisual = true;
        }
    }
}

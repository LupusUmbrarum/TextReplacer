using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplacer
{
    public class VisualFile
    {
        public string path;
        public Panel panel;
        TextBox pathBox;
        Button remove;
        WizardFriendly parent;
        bool beenMadeVisual = false;

        public VisualFile(string path)
        {
            this.path = path;
        }

        public void MakeVisual(ref Panel owningPanel, WizardFriendly parent)
        {
            if (beenMadeVisual)
            {
                return;
            }

            this.parent = parent;

            int count = owningPanel.Controls.Count;

            panel = new Panel();
            panel.BackColor = Color.Gray;
            panel.SetBounds(0, count * 25, owningPanel.Width - 4, 25);

            pathBox = new TextBox();
            pathBox.SetBounds(5, panel.Height / 2 - pathBox.Height / 2, owningPanel.Width / 3, pathBox.Height);
            pathBox.Text = path;
            //targetBox.TextChanged += this.editWords;
            panel.Controls.Add(pathBox);

            remove = new Button();
            int removeHeight = 25;
            remove.SetBounds(panel.Width - 30, panel.Height / 2 - removeHeight / 2 - 1, 25, removeHeight);
            remove.BackgroundImageLayout = ImageLayout.Stretch;
            remove.BackgroundImage = Properties.Resources.x_image2;
            //remove.Click += new EventHandler(this.removeButtonHandler);
            panel.Controls.Add(remove);

            owningPanel.Controls.Add(panel);

            beenMadeVisual = true;
        }
    }
}

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
        OpenFileDialog ofd;
		ToolTip tt;

        public VisualFile(string path)
        {
            this.path = path;
        }

        public void MakeVisual(ref Panel owningPanel, WizardFriendly parent, OpenFileDialog ofd)
        {
            if (beenMadeVisual)
            {
                return;
            }

            this.ofd = ofd;

            this.parent = parent;

            int count = owningPanel.Controls.Count;

            panel = new Panel();
            panel.BackColor = Color.Gray;
            panel.SetBounds(0, count * 25, owningPanel.Width - 21, 25);

            pathBox = new TextBox();
            pathBox.SetBounds(5, panel.Height / 2 - pathBox.Height / 2, panel.Width * 7 / 8, pathBox.Height);
            pathBox.Text = path;
			//pathBox.Click += new EventHandler(this.editPath);
			pathBox.DoubleClick += new EventHandler(this.editPath);
            panel.Controls.Add(pathBox);

            remove = new Button();
            int removeHeight = 25;
            remove.SetBounds(panel.Width - 30, panel.Height / 2 - removeHeight / 2 - 2, 25, removeHeight);
            remove.BackgroundImageLayout = ImageLayout.Stretch;
            remove.BackgroundImage = Properties.Resources.x_image2;
            remove.Click += new EventHandler(this.removeButtonHandler);
            panel.Controls.Add(remove);

            owningPanel.Controls.Add(panel);

			setPosition();

			tt = new ToolTip();

			tt.SetToolTip(pathBox, "Double-click to show OpenFileDialog.");

			beenMadeVisual = true;
        }

        private void editPath(object sender, EventArgs e)
        {
            OpenFileDialog tofd = new OpenFileDialog();

            if(ofd != null)
            {
                tofd.FileName = ofd.FileName;
            }

            tofd.Multiselect = false;

            if (tofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.path = tofd.FileName;
                    pathBox.Text = path;
                }
                catch (Exception ex) { ex.GetBaseException(); }
            }

			setPosition();
        }

        private void removeButtonHandler(object sender, EventArgs e)
        {
            parent.removeFile_Wizard(this);
        }

		private void setPosition()
		{
			pathBox.SelectionStart = pathBox.Text.Length - 1;
		}
    }
}

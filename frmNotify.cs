using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win10Toast
{
    public partial class frmNotify : Form
    {
        NotifyInfo info;
        int X, Y;
        int increment = 0;

        public frmNotify(NotifyInfo info)
        {
            InitializeComponent();

            this.info = info;
        }

        private void tmInfo_Tick(object sender, EventArgs e)
        {
            tmClose.Enabled = true;
            tmInfo.Enabled = false;
        }

        private void frmNotify_Load(object sender, EventArgs e)
        {
            picInfo.Visible = false;
            lblInfo.Visible = false;
            lblLink.Visible = false;
            lblClose.Visible = false;
            lblTitle.Visible = false;

        }

        private void tmClose_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(100);
                this.Opacity = 1 - 0.1 * i;
            }

            this.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            tmInfo.Enabled = false;
            tmClose.Enabled = false;
            this.Close();
        }

        private void frmNotify_Shown(object sender, EventArgs e)
        {
            ShowInfo();

            picInfo.Visible = true;
            lblInfo.Visible = true;
            lblLink.Visible = true;
            lblClose.Visible = true;
            lblTitle.Visible = true;

            lblInfo.Text = info.Description;
            lblLink.Text = info.Link;
            lblTitle.Text = info.Title;
            picInfo.Image = info.Image;
        }

        private void ShowInfo()
        {
            SetSettings();

            this.Location = new Point(X, Y);

            if (info.Direction == ShowDirection.Horizontal)
            {
                for (int i = 0; i < 5; i++)
                {
                    System.Threading.Thread.Sleep(10 + i * 3);
                    this.Left = this.Left + increment;
                }

                //System.Threading.Thread.Sleep(400);
                //this.Left = this.Left + 1;
                tmInfo.Enabled = true;

            }
            else if (info.Direction == ShowDirection.Vertical)
            {
                for (int i = 0; i < 4; i++)
                {
                    System.Threading.Thread.Sleep(10 + i * 3);
                    this.Top = this.Top + increment;
                }

                //System.Threading.Thread.Sleep(400);
                //this.Top = this.Top + 1;
                tmInfo.Enabled = true;

            }
        }
      
        private void SetSettings()
        {
            switch (info.Position)
            {
                case ShowPosition.BottomRight:
                    if (info.Direction == ShowDirection.Horizontal)
                    {
                        X = Screen.PrimaryScreen.WorkingArea.Size.Width;
                        Y = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
                        increment = -100;
                    }
                    else if (info.Direction == ShowDirection.Vertical)
                    {
                        X = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width;
                        Y = Screen.PrimaryScreen.WorkingArea.Size.Height;
                        increment = -40;
                    }
                    break;
                case ShowPosition.TopRight:
                    if (info.Direction == ShowDirection.Horizontal)
                    {
                        X = Screen.PrimaryScreen.WorkingArea.Size.Width;
                        increment = -100;
                    }
                    else if (info.Direction == ShowDirection.Vertical)
                    {
                        X = Screen.PrimaryScreen.WorkingArea.Size.Width - this.Width;
                        Y = -1 * this.Height;
                        increment = 40;
                    }
                    break;
                case ShowPosition.TopLeft:
                    if (info.Direction == ShowDirection.Horizontal)
                    {
                        X = -1 * this.Width;
                        increment = 100;
                    }
                    else if (info.Direction == ShowDirection.Vertical)
                    {
                        Y = -1 * this.Height;
                        increment = 40;
                    }
                    break;
                case ShowPosition.BottomLeft:
                    if (info.Direction == ShowDirection.Horizontal)
                    {
                        X = -1 * this.Width;
                        Y = Screen.PrimaryScreen.WorkingArea.Size.Height - this.Height;
                        increment = 100;
                    }
                    else if (info.Direction == ShowDirection.Vertical)
                    {
                        Y = Screen.PrimaryScreen.WorkingArea.Size.Height;
                        increment = -40;
                    }
                    break;
            }
        }
    }
}

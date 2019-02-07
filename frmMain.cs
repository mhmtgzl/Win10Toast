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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShowDirection direction = ShowDirection.Vertical;

            if (rdHorizontal.Checked)
            {
                direction = ShowDirection.Horizontal;
            }


            ShowPosition position = ShowPosition.BottomRight;

            if (rdTopRight.Checked)
            {
                position = ShowPosition.TopRight;
            }
            else if (rdTopLeft.Checked)
            {
                position = ShowPosition.TopLeft;
            }
            else if (rdBottomLeft.Checked)
            {
                position = ShowPosition.BottomLeft;
            }

            Image image = Properties.Resources.info;

            if (rdQuestion.Checked)
            {
                image = Properties.Resources.question;
            }
            else if (rdError.Checked)
            {
                image = Properties.Resources.error;
            }
            else if (rdWarning.Checked)
            {
                image = Properties.Resources.warning;
            }

            frmNotify frm = new frmNotify(new NotifyInfo()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Image =  image,
                Link = "",
                Position = position,
                WaitingTime = Convert.ToInt32(txtTime.Text),
                Direction = direction
            });

            frm.Show();
        }
    }
}

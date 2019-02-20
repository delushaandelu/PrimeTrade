using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;


namespace PrimeTrade
{
    public partial class frmAdminHome : MetroForm
    {
        public frmAdminHome()
        {
            InitializeComponent();

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;

                    Mdi.BackColor = System.Drawing.Color.Gray;
                }
                catch (Exception a)
                {
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmAdminAddUser form = new frmAdminAddUser("Add");
            form.MdiParent = this;
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmAdminViewUsers form = new frmAdminViewUsers();
            form.MdiParent = this;
            form.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmAdminChangePassword form = new frmAdminChangePassword();
            form.MdiParent = this;
            form.Show();
        }
    }
}

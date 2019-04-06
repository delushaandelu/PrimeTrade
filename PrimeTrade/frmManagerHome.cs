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
    public partial class frmManagerHome : MetroForm
    {
        private int childFormNumber = 0;

        public frmManagerHome()
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

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmManagerStockManagement form = new frmManagerStockManagement("BRAND");
            form.MdiParent = this;
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmManagerStockBasicData form = new frmManagerStockBasicData();
            form.MdiParent = this;
            form.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmManagerViewStock form = new frmManagerViewStock();
            form.MdiParent = this;
            form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Configuration;
using MetroFramework;
using MetroFramework.Fonts;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace PrimeTrade
{
    public partial class frmManagerPoints : MetroForm
    {
        public frmManagerPoints()
        {
            InitializeComponent();
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

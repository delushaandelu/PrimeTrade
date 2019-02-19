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
    public partial class frmStartup : MetroForm
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep(); // or progressBar1.Value++;
            if (progressBar1.Value == 100)  // check with the value
            {
                new frmUserlogin().Show();
                timer1.Stop();
                this.Hide();
            }
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 2;
            timer1.Start();  // start the timer
        }
    }
}

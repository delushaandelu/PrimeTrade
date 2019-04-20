﻿using System;
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
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace PrimeTrade
{
    public partial class FrmDistibuterHome : MetroForm
    {
        public FrmDistibuterHome(string userid)
        {
            InitializeComponent();
            lblstatus.Text = userid;
        }

        private void approvedPromotionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDistributerNewPromotins form = new FrmDistributerNewPromotins(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }

        private void myPromotionTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistributerMyPromotionTasks form = new frmDistributerMyPromotionTasks(lblstatus.Text);
            form.MdiParent = this;
            form.Show();
        }
    }
}

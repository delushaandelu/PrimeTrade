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
using MySql.Data.MySqlClient;

namespace PrimeTrade
{
    public partial class frmManagerStockManagement : MaterialForm
    {
        public frmManagerStockManagement()
        {
            InitializeComponent();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            if (txtstockname.Text == "" || txtqty.Text == "" || txtreorder.Text == "" || txtreorder.Text == "" || cmbcatogery.Text == "" || cmbbrand.Text == "" || cmbmanufactor.Text  == "" || cmbstate.Text  == "" || cmbpromocode.Text == "" )
            {
                MessageBox.Show("Please fill up all the fields.", "Empty Fields Detected !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlParameter[] pera = new MySqlParameter[10];
                pera[0] = new MySqlParameter("stockname", MySqlDbType.VarChar);
                pera[0].Value = txtstockname.Text;

                pera[1] = new MySqlParameter("catogery", MySqlDbType.VarChar);
                pera[1].Value = cmbcatogery.Text;

                pera[2] = new MySqlParameter("brand", MySqlDbType.VarChar);
                pera[2].Value = cmbbrand.Text;

                pera[3] = new MySqlParameter("qty", MySqlDbType.VarChar);
                pera[3].Value = txtqty.Text;

                pera[4] = new MySqlParameter("manufator", MySqlDbType.VarChar);
                pera[4].Value = cmbmanufactor.Text;

                pera[5] = new MySqlParameter("mandate", MySqlDbType.VarChar);
                pera[5].Value = dtpmandate.Text;

                pera[6] = new MySqlParameter("expdate", MySqlDbType.VarChar);
                pera[6].Value = dtpexpdate.Text;

                pera[7] = new MySqlParameter("state", MySqlDbType.VarChar);
                pera[7].Value = cmbstate.Text;

                pera[8] = new MySqlParameter("reorder", MySqlDbType.VarChar);
                pera[8].Value = txtreorder.Text;

                pera[9] = new MySqlParameter("promocode", MySqlDbType.VarChar);
                pera[9].Value = cmbpromocode.Text;

                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "stock_add_new";

                command.Parameters.AddRange(pera);
                connect.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    connect.Close();
                    MessageBox.Show("New stock item added.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearn_form();
                }
                else
                {
                    connect.Close();
                    MessageBox.Show("Can not add new stock item.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void clearn_form()
        {
            txtstockid.ResetText();
            txtstockname.ResetText();
            cmbcatogery.ResetText();
            cmbmanufactor.ResetText();
            cmbbrand.ResetText();
            cmbstate.ResetText();
            dtpmandate.ResetText();
            dtpexpdate.ResetText();
            txtqty.ResetText();
            txtreorder.ResetText();
            cmbpromocode.ResetText();
        }
    }
}

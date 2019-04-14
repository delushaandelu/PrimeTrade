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
    public partial class frmManagerViewAllAreaDistRecords : MaterialForm
    {
        public frmManagerViewAllAreaDistRecords()
        {
            InitializeComponent();
            viewDistributers();
            viewProviance();
            viewArea();
            viewAllRecords();
        }
        MySqlConnection connect = new MySqlConnection(connections.classConnection.ConnectNow("GoogleCloude"));

        public void viewAllRecords()
        {
            listView3.Items.Clear();
            listView3.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_distributer_area`.`recid`, `tbl_user`.`firstname`,`tb_area`.`areaname`,`tb_area`.`province`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`joindate` FROM `base`.`tb_distributer_area`, `base`.`tbl_user`, `base`.`tb_area` where `base`.`tb_distributer_area`.`userid` = `base`.`tbl_user`.`idtbl_user` and `base`.`tb_distributer_area`.`areaid` = `tb_area`.`areaid`;", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["recid"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listView3.Items.Add(listItem);
            }
            
        }

        public void viewDistributers()
        {
            
            connect.Open();

            string query = "SELECT `tbl_user`.`firstname` FROM `base`.`tbl_user` WHERE `tbl_user`.`role` = 'DISTRIBUTER'";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbDistributers.Items.Add(reader.GetString("firstname"));
                    }
                }
                connect.Close();
            }
            
        }

        public void viewArea()
        {

            connect.Open();

            string query = "SELECT  distinct `tb_area`.`areaname` FROM `base`.`tb_area`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbarea.Items.Add(reader.GetString("areaname"));
                    }
                }
                connect.Close();
            }

        }

        public void viewProviance()
        {

            connect.Open();

            string query = "SELECT  `tb_area`.`province` FROM `base`.`tb_area`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbprovince.Items.Add(reader.GetString("province"));
                    }
                }
                connect.Close();
            }

        }

        
        private void cmbDistributers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            listView3.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_distributer_area`.`recid`, `tbl_user`.`firstname`,`tb_area`.`areaname`,`tb_area`.`province`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`joindate` FROM `base`.`tb_distributer_area`, `base`.`tbl_user`, `base`.`tb_area` where `base`.`tb_distributer_area`.`userid` = `base`.`tbl_user`.`idtbl_user` and `base`.`tb_distributer_area`.`areaid` = `tb_area`.`areaid` and `tbl_user`.`firstname` LIKE '%" + cmbDistributers.Text + "%' ;", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["recid"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listView3.Items.Add(listItem);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewAllRecords();
            cmbprovince.ResetText();
            cmbarea.ResetText();
            cmbDistributers.ResetText();
        }

        private void cmbarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            listView3.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_distributer_area`.`recid`, `tbl_user`.`firstname`,`tb_area`.`areaname`,`tb_area`.`province`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`joindate` FROM `base`.`tb_distributer_area`, `base`.`tbl_user`, `base`.`tb_area` where `base`.`tb_distributer_area`.`userid` = `base`.`tbl_user`.`idtbl_user` and `base`.`tb_distributer_area`.`areaid` = `tb_area`.`areaid` and `tb_area`.`areaname` LIKE '%" + cmbarea.Text + "%' ;", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["recid"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listView3.Items.Add(listItem);
            }
        }

        private void cmbprovince_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            listView3.View = View.Details;

            MySqlDataAdapter dAdpter = new MySqlDataAdapter("SELECT `tb_distributer_area`.`recid`, `tbl_user`.`firstname`,`tb_area`.`areaname`,`tb_area`.`province`,`tbl_user`.`email`,`tbl_user`.`address`,`tbl_user`.`telephone`,`tbl_user`.`joindate` FROM `base`.`tb_distributer_area`, `base`.`tbl_user`, `base`.`tb_area` where `base`.`tb_distributer_area`.`userid` = `base`.`tbl_user`.`idtbl_user` and `base`.`tb_distributer_area`.`areaid` = `tb_area`.`areaid` and `tb_area`.`province` LIKE '%" + cmbprovince.Text + "%';", connect);

            DataTable dTable = new DataTable();
            dAdpter.Fill(dTable);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                DataRow dRow = dTable.Rows[i];
                ListViewItem listItem = new ListViewItem(dRow["recid"].ToString());
                listItem.SubItems.Add(dRow["firstname"].ToString());
                listItem.SubItems.Add(dRow["areaname"].ToString());
                listItem.SubItems.Add(dRow["province"].ToString());
                listItem.SubItems.Add(dRow["email"].ToString());
                listItem.SubItems.Add(dRow["address"].ToString());
                listItem.SubItems.Add(dRow["telephone"].ToString());
                listItem.SubItems.Add(dRow["joindate"].ToString());
                listView3.Items.Add(listItem);
            }
        }
    }
}

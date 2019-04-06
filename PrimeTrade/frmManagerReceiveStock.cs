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
    public partial class frmManagerReceiveStock : MaterialForm
    {
        public frmManagerReceiveStock(string stock_id, int quantity, int newstock, string item, string cat, string brand, string man)
        {
            InitializeComponent();

            lblitem.Text = stock_id;
            lblitemname.Text = item;
            lblcatagory.Text = cat;
            lblbrand.Text = brand;
            lblmanufactor.Text = man;
            lblstock.Text = quantity.ToString();
            lblnewstock.Text = newstock.ToString();

            int stock;
            int newqty;
            int total;


            int.TryParse(lblstock.Text, out stock);
            int.TryParse(lblnewstock.Text, out newqty);
            total = stock + newqty;

            lbltotalstock.Text = total.ToString();
        }
    }
}

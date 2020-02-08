using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string constring, qrystring;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void getproducts_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            qrystring = "Select ProductName from Products";
            sqlcmd = new SqlCommand(qrystring, sqlcon);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                listproducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}

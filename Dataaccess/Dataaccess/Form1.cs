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

namespace Dataaccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString; 

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            qryString = "select Products from Products";
                sqlCmd = new SqlCommand(qryString, sqlCon);
               

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source = BLT10136\\SQLEXPRESS2014;Intial Catalog=Northwind;Intergrated ecurity=True;";
            sqlCon = new SqlConnection(conString);

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(113, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            constring = "data source = BLT10136\\SQLEXPRESS2014;Initial Catalog =Northwind;Integrated Security =True";
            sqlcon = new SqlConnection(constring);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlCon.Open();

            qryString = "select productname from products";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader();

            while(dr.Read())
            {
               listBox1.Items.Add(dr["Productname"]);

            }
            dr.Close();
            sqlCon.Close();


        }
    }
}

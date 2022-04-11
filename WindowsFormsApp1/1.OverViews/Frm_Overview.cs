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

namespace WindowsFormsApp1._1.OverViews
{
    public partial class Frm_Overview : Form
    {
        public Frm_Overview()
        {
            InitializeComponent();
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {
            //step 1.sqlConnected
            //step 2.sqlCommand
            //step 3.sqlDataReader
            //step 4. UI Control
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                MessageBox.Show(dataReader["ProductName"].ToString());


                conn.Close();
                //MessageBox.Show("Successfuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

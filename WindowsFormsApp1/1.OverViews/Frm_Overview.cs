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
            tabControl1.SelectedIndex= 1;//show the tab

        }
        private void btnConnected_Click(object sender, EventArgs e)
        {
            //step 1.sqlConnected
            //step 2.sqlCommand
            //step 3.sqlDataReader
            //step 4. UI Control
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Products", conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                this.lbShow.Items.Clear();
                while (dataReader.Read())
                {
                    string s = $"{dataReader["ProductName"],-40} {dataReader["UnitPrice"]:c2}";
                    this.lbShow.Items.Add(s);
                };
                //  MessageBox.Show(dataReader["ProductName"].ToString());
                //MessageBox.Show("Successfuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                if (conn != null) {
                    conn.Close();
                }
            }

        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Products", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.dataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
            }

        private void btnDisconnectCategories_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=NorthWind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Products where UnitPrice>30 order by UnitPrice", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView.DataSource = ds.Tables[0];
               }
        private void btnDisconnectedAws_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Production.ProductPhoto", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView.DataSource = ds.Tables[0];
        }
        private void btnTableAdapterProduct_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dataGridView1.DataSource = this.nwDataSet1.Products;
        }

        private void btnTableAdapterCategor_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.dataGridView1.DataSource = this.nwDataSet1.Categories;
        }

        
    }
    }
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class InventorySummary : Form
    {
        Connectionclass conn = new Connectionclass();
        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;



        public InventorySummary()
        {
            InitializeComponent();
            combo();
        }


        void combo()
        {
            conn.dbcon();

            cmd = new SqlCommand("Select * from Products");
            cmd.Connection = Connectionclass.con;
            SqlDataReader dr;
            try
            {

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    long set = dr.GetInt64(0);
                    txtsearch.Items.Add(set);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();     
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //back
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Main display = new Main();
                display.ShowDialog();
                this.Close();

            }
        }

        private void summary_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);


            try
            {

                conn.dbcon();

                cmd = new SqlCommand("SELECT Product_ID, Product_Name, Unit_Measure,  sum(Quantity)as QuantityOnHand from stockcard  Group by Product_ID, Product_Name, Unit_Measure Order by Product_ID ASC ");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "summary");
                dt = ds.Tables["summary"];

                data.DataSource = ds.Tables["summary"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }

        }

   

        private void txtsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT Product_ID, Product_Name, Unit_Measure,  sum(Quantity)as QuantityOnHand from stockcard where Product_ID = '"+txtsearch.Text+"' Group by Product_ID, Product_Name, Unit_Measure Order by Product_ID ASC ");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                data.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }


        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT Product_ID, Product_Name, Unit_Measure,  sum(Quantity)as QuantityOnHand from stockcard where Product_ID like '" + txtsearch.Text + "%' Group by Product_ID, Product_Name, Unit_Measure Order by Product_ID ASC ");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
 

namespace WindowsFormsApplication1
{
    public partial class StockCard : Form
    {


        Connectionclass conn = new Connectionclass();

        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;



        public StockCard()
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
                    comboprodID.Items.Add(set);
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();      
        }


        private void StockCard_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);



            try
            {

                conn.dbcon();

                cmd = new SqlCommand("SELECT SupplierOrCustomer_Name as 'Supplier or Customer Name', TransactionDate as 'Transaction Date', TRANS as 'Transaction', CostOrPrice, Quantity from stockcard ");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "stock");
                dt = ds.Tables["stock"];

                data.DataSource = ds.Tables["stock"];
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

        private void comboprodID_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT SupplierOrCustomer_Name, TRANSACTIONDATE, TRANS, CostOrPrice, Quantity from stockcard where Product_ID ='" + comboprodID.Text + "'");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                data.DataSource = dt;
                SqlCommand cm = new SqlCommand("select Product_Name, Unit_Measure, sum(Quantity) from stockcard where Product_ID =  '" + comboprodID.Text + "' group by Product_Name, Unit_Measure");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR1 = cm.ExecuteReader();
                if (DR1.Read())
                {
                    txtprodname.Text = DR1.GetValue(0).ToString();
                    txtunitmeas.Text = DR1.GetValue(1).ToString();
                }
                else
                {
                    txtprodname.Text = "";
                    txtunitmeas.Text = "";
                }
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

        private void comboprodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT SupplierOrCustomer_Name, TRANSACTIONDATE, TRANS, CostOrPrice, Quantity from stockcard where Product_ID Like '" + comboprodID.Text + "%'");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                data.DataSource = dt;
                SqlCommand cm = new SqlCommand("select Product_Name, Unit_Measure, sum(Quantity) from stockcard where Product_ID =  '" + comboprodID.Text + "' group by Product_Name, Unit_Measure");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR1 = cm.ExecuteReader();
                if (DR1.Read())
                {
                    txtprodname.Text = DR1.GetValue(0).ToString();
                    txtunitmeas.Text = DR1.GetValue(1).ToString();
                }
                else
                {
                    txtprodname.Text = "";
                    txtunitmeas.Text = "";
                }
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

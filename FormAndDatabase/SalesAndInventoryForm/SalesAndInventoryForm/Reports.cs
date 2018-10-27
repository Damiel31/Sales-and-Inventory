using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class Reports : Form
    {
        Connectionclass conn = new Connectionclass();
       
        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;

        public Reports()
        {

            InitializeComponent();
            DateTime today = DateTime.Today;
            date.Text = DateTime.Now.ToString();
            comboprod();
            combomonth();
            comboyear();
            
            
        }
        void comboprod()
        {

            conn.dbcon();
            cmd = new SqlCommand("Select Distinct Sale_Date from reportsales");
            cmd.Connection = Connectionclass.con;
            SqlDataReader dr;
            try
            {

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DateTime set = dr.GetDateTime(0);
                    txtdate.Items.Add(set);
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
        void combomonth()
        {

            conn.dbcon();
            cmd = new SqlCommand("select Distinct Month( Sale_Date ),YEAR(Sale_Date) from reportsales");
            cmd.Connection = Connectionclass.con;
            SqlDataReader dr;
            try
            {

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int set = dr.GetInt32(0);
                    int seta = dr.GetInt32(1);
                    if (set <= 9)
                    {
                        txtdatemonth.Items.Add(seta + "-0" + set);
                    }
                    else
                    {
                   
                        txtdatemonth.Items.Add(seta + "-" + set);
                    }

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
        void comboyear()
        {

            conn.dbcon();
            cmd = new SqlCommand("select Distinct YEAR ( Sale_Date ) from reportsales");
            cmd.Connection = Connectionclass.con;
            SqlDataReader dr;
            try
            {

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int set = dr.GetInt32(0);
                    txtyear.Items.Add(set);
                    

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

      



        private void Reports_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Main_KeyDown);

          
            
            ////Sales Sales Sales
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT C.CustomerName , S.Sale_Date ,P.Product_ID, P.Product_Name, P.Unit_Measure, SD.Discount, SD.Price, SD.Quantity FROM Customers C INNER JOIN Sales S ON C.Customer_ID = S.Customer_ID INNER JOIN SalesDetails SD ON S.Sale_No = SD.Sale_No INNER JOIN Products P ON SD.Product_ID = P.Product_ID");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "sales");
                dt = ds.Tables["sales"];
              
                datagrid.DataSource = ds.Tables["sales"];
                datagrid.ReadOnly = false;
                datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }
            ////end of Sales Sales Sales
            ///
            ////start Sum Sales Sales
            try
            {
                conn.dbcon();
                SqlCommand cmda = new SqlCommand("SELECT SUM(((SD.Price * (SD.Discount/100))- SD.Price) * (-1 * SD.Quantity)) as Total FROM SalesDetails SD  INNER JOIN Products P ON SD.Product_ID = P.Product_ID");
                cmda.Connection = Connectionclass.con;
                SqlDataReader sda = cmda.ExecuteReader();
                if (sda.Read())
                {
                    txtgrandtotal.Text = sda.GetValue(0).ToString();
                    
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
            //// end of sum Sales Sales
            ///

            ////Start of orders orders
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT SU.Supplier_Name, O.Order_Date , P.Product_ID, P.Product_Name, P.Unit_Measure, OD.Cost, OD.Quantity FROM Suppliers SU INNER JOIN Orders O ON SU.Supplier_ID = O.Supplier_ID INNER JOIN OrderDetails OD ON O.Order_No = OD.Order_No INNER JOIN Products P ON OD.Product_ID = P.Product_ID");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "order");
                dt = ds.Tables["order"];
                
                data.DataSource = ds.Tables["order"];
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
            ////end of orders orders
            ///
            ////Start of sum orders orders
            
            try
            {
                conn.dbcon();
                SqlCommand cmdas = new SqlCommand("select sum(CostOrPrice *  Quantity) from stockcard where Trans = 'Order'");
                cmdas.Connection = Connectionclass.con;
                SqlDataReader sda = cmdas.ExecuteReader();
                if (sda.Read())
                {
                    txtexpenses.Text = sda.GetValue(0).ToString();

                }
            }
            finally
            {
                conn.Closecon();
            }
            ////end of sum orders orders
            ///

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Main display = new Main();
                display.ShowDialog();
                this.Close();
            }
        }

        

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();      
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.dbcon();
            try
            {
                cmd = new SqlCommand("select * from DailySales where Sale_Date like '" + date.Text + "%'");
                cmd.Connection = Connectionclass.con;
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
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

        private void btnback_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
        }

        private void txtdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT * from reportsales where Sale_Date = '" + txtdate.Text + "'order by Sale_Date DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                salesreport.DataSource = dt;
               SqlCommand cm = new SqlCommand("select SUM(((Price * (R.Discount/100))- Price) * (-1 * Quantity)) as Total from reportsales R where Sale_Date = '"+txtdate.Text+"'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR1 = cm.ExecuteReader();
                if (DR1.Read())
                {
                    txttotal.Text = DR1.GetValue(0).ToString();
                   
                }
                else
                {
                    
                    txttotal.Clear();
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

       

        private void txtdatemonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT * from reportsales where Sale_Date Like '" + txtdatemonth.Text + "%'order by Sale_Date DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                salesreport.DataSource = dt;
                SqlCommand cm = new SqlCommand("select SUM(((Price * (R.Discount/100))- Price) * (-1 * Quantity)) as Total from reportsales R where Sale_Date Like '" + txtdatemonth.Text + "%'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR1 = cm.ExecuteReader();
                if (DR1.Read())
                {
                    txttotal.Text = DR1.GetValue(0).ToString();


                }
                else
                {
                   
                        txttotal.Clear();
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

        private void txtyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT * from reportsales where Sale_Date Like '" + txtyear.Text + "%' order by Sale_Date DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                salesreport.DataSource = dt;
                SqlCommand cm = new SqlCommand("select SUM(((Price * (R.Discount/100))- Price) * (-1 * Quantity)) as Total from reportsales R where Sale_Date Like '" + txtyear.Text + "%'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR1 = cm.ExecuteReader();
                if (DR1.Read())
                {
                    txttotal.Text = DR1.GetValue(0).ToString();
                }
                else
                {
                    
                        txttotal.Clear();
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

        private void txtdate_MouseClick(object sender, MouseEventArgs e)
        {
            txtdatemonth.SelectedIndex = -1;
            txtyear.SelectedIndex = -1;
            salesreport.DataSource = null;
            salesreport.Rows.Clear();
        }

        private void txtdatemonth_MouseClick(object sender, MouseEventArgs e)
        {
            txtdate.SelectedIndex = -1;
            txtyear.SelectedIndex = -1;
            salesreport.DataSource = null;
            salesreport.Rows.Clear();

        }

        private void txtyear_MouseClick(object sender, MouseEventArgs e)
        {
            txtdate.SelectedIndex = -1;
            txtdatemonth.SelectedIndex = -1;
            salesreport.DataSource = null;
            salesreport.Rows.Clear();
        }

        /*private void txtcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT * from reportsales where Customer_ID = '" + txtcustid.Text + "' and Sale_Date = '"+txtdate.Text+"'");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                salesreport.DataSource = dt;
                SqlCommand cm = new SqlCommand("select SUM(((Price * (Discount/100))- Price) * (-1 * Quantity)) as Total from reportsales where Customer_ID = '" + txtcustid.Text + "'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR1 = cm.ExecuteReader();
                if (DR1.Read())
                {
                    txttotal.Text = DR1.GetValue(0).ToString();


                }
                else
                {
                    txttotal.Clear();
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

        }*/

        
        
       


    }
}

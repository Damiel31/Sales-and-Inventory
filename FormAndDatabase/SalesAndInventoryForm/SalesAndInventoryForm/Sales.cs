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
    public partial class Sales : Form
    {
        Connectionclass conn = new Connectionclass();

        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;

        public Sales()
        {
            
            InitializeComponent();

            DateTime today = DateTime.Today;
            txtsalesdate.Text = DateTime.Now.ToString();
            
            combo();
            combosale();

        }
        void combo()
        {
            conn.dbcon();
            try
            {
                cmd = new SqlCommand("Select * from Customers");
                cmd.Connection = Connectionclass.con;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    long set = dr.GetInt64(0);
                    txtcustid.Items.Add(set);
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
        void combosale()
        {
            conn.dbcon();
            try
            {
              
                cmd = new SqlCommand("Select * from Products");
                cmd.Connection = Connectionclass.con;
                SqlDataReader drr;
                drr = cmd.ExecuteReader();
                while (drr.Read())
                {
                    long se = drr.GetInt64(0);
                    txtprodcode.Items.Add(se);
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
      


        private void Sales_Load(object sender, EventArgs e)
        {
            

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            try
            {
                conn.dbcon();

                cmd = new SqlCommand("select SD.Sale_No, S.Customer_ID, SD.Product_ID, SD.Price, SD.Quantity , SD.Discount from Sales S inner join SalesDetails SD on S.Sale_No = SD.Sale_No order by SD.Sale_No DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Sales");
                dt = ds.Tables["Sales"];
                data.DataSource = ds.Tables["Sales"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtsalesdate.Text = DateTime.Now.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
            }

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //ADD SALES
            if (e.KeyData == Keys.F1)
            {
                this.Hide();
                addsales display = new addsales();
                display.ShowDialog();
               
                /*if (txtcustid.Text == "" || txtprodcode.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
                {
                    MessageBox.Show("All fields cannot be EMPTY!", "Error");
                    return;
                }
                int left = Convert.ToInt32(txtleftitem.Text);
                if (left == 0)
                {
                    MessageBox.Show("Please be warned! \nthe product you selected maybe out numbered Please contact Supplier", "Warning!");
                    return;
                }
                if (left < 0)
                {
                    MessageBox.Show("There is no Item Left", "Warning!");
                    return;

                }

                try
                {
                    conn.dbcon();
                    SqlCommand cm = new SqlCommand("INSERT INTO Sales (Sale_Date, Customer_ID) " + "Values ('" + txtsalesdate.Text + "', '" + txtcustid.Text + "' )");
                    cm.Connection = Connectionclass.con;
                    cm.ExecuteNonQuery();
                    cmd = new SqlCommand("INSERT INTO SalesDetails (Product_ID, Price, Quantity) " + "Values ( '" + txtprodcode.Text + "','" + txtprice.Text + "', '" + txtquantity.Text + "')");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    int lefta = Convert.ToInt32(txtleftitem.Text);
                    if (lefta <= 10)
                    {
                        MessageBox.Show("Please be warned! \nthe product you selected maybe out numbered \nPlease contact Supplier!", "Warning!");

                    }
                    MessageBox.Show("Saved Successfully", "Saving");


                    txtquantity.Text = "";
                    txtprodcode.SelectedIndex = -1;
                    txtcustid.SelectedIndex = -1;
                    txtinfocustname.Clear();
                    txtleftitem.Clear();
                    txtquantity.Clear();
                    txtinfoprod.Clear();
                    txtdiscount.Clear();
                    txtprice.Clear();
                    txtTotal.Text = "0.00";



                    //refresh
                  
                    cmd = new SqlCommand("SELECT * from SalesDetails");
                    cmd.Connection = Connectionclass.con;
                    sda = new SqlDataAdapter(cmd);
                    cmb = new SqlCommandBuilder(sda);
                    ds = new DataSet();
                    sda.Fill(ds, "Sales");
                    dt = ds.Tables["Sales"];

                    data.DataSource = ds.Tables["Sales"];
                    data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DateTime dta = DateTime.Now;
                    txtsalesdate.Text = DateTime.Now.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    conn.Closecon();
                }*/

            }
            //UPDATE SALES
            if (e.KeyData == Keys.F2)
            {


                ////UPDATE
                bool error = true;
                bool error1 = true;
                bool error2 = true;
                string id = txtcustid.Text;
                string pcode = txtprodcode.Text;
                string qty = txtquantity.Text;
                //Start TXTCustid Constraints
                foreach (char c in id)
                {
                    if (!Char.IsNumber(c))
                    {
                        error = false;
                        break;
                    }
                }

                if (error == false)
                {
                    MessageBox.Show("The Customer ID you entered does'nt exist in the RECORD", "Error");
                    return;
                }
                ///end of txtCUSTID Constraints
                ///
                ///Start of txtprodcode Constraints
                foreach (char c in pcode)
                {
                    if (!Char.IsNumber(c))
                    {
                        error1 = false;
                        break;
                    }
                }

                if (error1 == false)
                {
                    MessageBox.Show("The Product Code you entered does'nt exist in the RECORD", "Error");
                    return;
                }
                ///end of txtprodcode Constraints
                ///
                ///Start of txtquantity Constraints
                foreach (char c in qty)
                {
                    if (!Char.IsNumber(c))
                    {
                        error2 = false;
                        break;
                    }
                }
                if (error2 == false)
                {
                    MessageBox.Show("Invalid Input Please Checked Quantity Field for INCORRECT input", "Error");
                    return;
                }
                ///end of txtquantity Constraints



                if (txtprodcode.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
                {
                    MessageBox.Show("No Such Record To Update", "Error");
                    return;
                }

                try
                {
                    conn.dbcon();
                    cmb = new SqlCommandBuilder(sda);
                    sda.Update(ds, "Sales");
                    cmd = new SqlCommand("Update SalesDetails set Product_ID  = '" + txtprodcode.Text + "' , Price = '" + txtprice.Text + "',Quantity = '" + txtquantity.Text + "', Discount = '" + txtdiscount.Text + "'  where Sale_No = '" + txtsaleno.Text + "'");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Update Sales set Customer_ID  = '" + txtcustid.Text + "' where Sale_No = '" + txtsaleno.Text + "'");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "Update");

                    txtcustid.Enabled = true;
                    ////clear

                    txtquantity.Text = "";
                    txtprodcode.SelectedIndex = -1;
                    txtcustid.SelectedIndex = -1;
                    txtinfocustname.Clear();

                    txtquantity.Clear();
                    txtinfoprod.Clear();
                    txtdiscount.Clear();
                    txtprice.Clear();
                    txtTotal.Text = "0.00";
                    txtquantity.ReadOnly = true;
                    txtdiscount.ReadOnly = true;
                    //refresh

                    cmd = new SqlCommand("select SD.Sale_No, S.Customer_ID, SD.Product_ID, SD.Price, SD.Quantity , SD.Discount from Sales S inner join SalesDetails SD on S.Sale_No = SD.Sale_No order by SD.Sale_No DESC");
                    cmd.Connection = Connectionclass.con;
                    sda = new SqlDataAdapter(cmd);
                    cmb = new SqlCommandBuilder(sda);
                    ds = new DataSet();
                    sda.Fill(ds, "Sales");
                    dt = ds.Tables["Sales"];
                    data.DataSource = ds.Tables["Sales"];
                    data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DateTime dta = DateTime.Now;
                    txtsalesdate.Text = DateTime.Now.ToString();
                }
                catch
                {

                }
                finally
                {
                    conn.Closecon();
                    txtcustid.Enabled = false;
                    txtprodcode.Enabled = false;

                }

                ///product Left
                try
                {
                    conn.dbcon();
                    SqlCommand tot = new SqlCommand("Select sum(Quantity) from stockcard where Product_ID like '" + txtprodcode.Text + "%'");
                    tot.Connection = Connectionclass.con;
                    SqlDataReader DR1 = tot.ExecuteReader();
                    if (DR1.Read())
                    {
                        txtleftitem.Text = DR1.GetValue(0).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    conn.Closecon();
                    txtleftitem.Clear();
                }
            }

            //BACK
            if (e.KeyData == Keys.Escape)
            {

                this.Hide();
                Main display = new Main();
                display.ShowDialog();
                this.Close();
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            ////UPDATE
            bool error = true;
            bool error1 = true;
            bool error2 = true;
            string id = txtcustid.Text;
            string pcode = txtprodcode.Text;
            string qty = txtquantity.Text;
            //Start TXTCustid Constraints
            foreach (char c in id)
            {
                if (!Char.IsNumber(c))
                {
                    error = false;
                    break;
                }
            }

            if (error == false)
            {
                MessageBox.Show("The Customer ID you entered does'nt exist in the RECORD", "Error");
                return;
            }
            ///end of txtCUSTID Constraints
            ///
            ///Start of txtprodcode Constraints
            foreach (char c in pcode)
            {
                if (!Char.IsNumber(c))
                {
                    error1 = false;
                    break;
                }
            }

            if (error1 == false)
            {
                MessageBox.Show("The Product Code you entered does'nt exist in the RECORD", "Error");
                return;
            }
            ///end of txtprodcode Constraints
            ///
            ///Start of txtquantity Constraints
            foreach (char c in qty)
            {
                if (!Char.IsNumber(c))
                {
                    error2 = false;
                    break;
                }
            }
            if (error2 == false)
            {
                MessageBox.Show("Invalid Input Please Checked Quantity Field for INCORRECT input", "Error");
                return;
            }
            ///end of txtquantity Constraints

            
          
            if (txtprodcode.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("No Such Record To Update", "Error");
                return;
            }

            try
            {
                conn.dbcon();
                cmb = new SqlCommandBuilder(sda);
                sda.Update(ds, "Sales");
                cmd = new SqlCommand("Update SalesDetails set Product_ID  = '" + txtprodcode.Text + "' , Price = '" + txtprice.Text + "',Quantity = '" + txtquantity.Text + "', Discount = '"+txtdiscount.Text+"'  where Sale_No = '" + txtsaleno.Text + "'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Update Sales set Customer_ID  = '" + txtcustid.Text + "' where Sale_No = '" + txtsaleno.Text + "'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Update");

                txtcustid.Enabled = true;
                ////clear
             
                txtquantity.Text = "";
                txtprodcode.SelectedIndex = -1;
                txtcustid.SelectedIndex = -1;
                txtinfocustname.Clear();
                
                txtquantity.Clear();
                txtinfoprod.Clear();
                txtdiscount.Clear();
                txtprice.Clear();
                txtTotal.Text = "0.00";
                txtquantity.ReadOnly = true;
                txtdiscount.ReadOnly = true;
               
                //refresh

                cmd = new SqlCommand("select SD.Sale_No, S.Customer_ID, SD.Product_ID, SD.Price, SD.Quantity , SD.Discount from Sales S inner join SalesDetails SD on S.Sale_No = SD.Sale_No order by SD.Sale_No DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Sales");
                dt = ds.Tables["Sales"];
                data.DataSource = ds.Tables["Sales"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtsalesdate.Text = DateTime.Now.ToString();
            }
            catch 
            {
                
            }
            finally
            {
                conn.Closecon();
                txtcustid.Enabled = false;
                txtprodcode.Enabled = false;

            }

            ///product Left
            try
            {
                conn.dbcon();
                SqlCommand tot = new SqlCommand("Select sum(Quantity) from stockcard where Product_ID like '" + txtprodcode.Text + "%'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR1 = tot.ExecuteReader();
                if (DR1.Read())
                {
                    txtleftitem.Text = DR1.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
                txtleftitem.Clear();              
            }
        }

      
        private void txtprodcode_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                conn.dbcon();
                SqlCommand cm = new SqlCommand("select Product_Name, Description, Price , Product_ID, Discount from Products where Product_ID like  '" + txtprodcode.Text + "%'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR3 = cm.ExecuteReader();
                if (DR3.Read())
                {

                    txtinfoprod.Text = DR3.GetValue(0).ToString() + ",  " + DR3.GetValue(1).ToString() + ", Price P" + DR3.GetValue(2).ToString();
                    txtprice.Text = DR3.GetValue(2).ToString();
                    txtdiscount.Text = DR3.GetValue(4).ToString();
                    
                }
            }
            catch
            {
               
            }
            finally
            {
                conn.Closecon();
            }

           
            try
            {
                conn.dbcon();
                SqlCommand tot = new SqlCommand("Select sum(Quantity) from stockcard where Product_ID like '" + txtprodcode.Text + "%'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR1 = tot.ExecuteReader();
                if (DR1.Read())
                {
                    txtleftitem.Text = DR1.GetValue(0).ToString();
                }
            }
            catch
            {
             
            }
            finally
            {
                conn.Closecon();

            }
           
            }
        

        

        private void txtcustid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                SqlCommand tot = new SqlCommand("Select CustomerName from Customers where Customer_ID like '" + txtcustid.Text + "%'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR2 = tot.ExecuteReader();
                if (DR2.Read())
                {
                    txtinfocustname.Text = DR2.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
            }
        }

        private void txtquantity_TextChanged_1(object sender, EventArgs e)
        {
            calculate();
        }

        

        private void btnaddsale_Click(object sender, EventArgs e)
        {

            this.Hide();
           addsales display = new addsales();
            display.ShowDialog();

            /*
            if (txtcustid.Text == "" || txtprodcode.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("All fields cannot be EMPTY!","Error");
                return;
            }
            int left = Convert.ToInt32(txtleftitem.Text);
            if(left == 0)
            {
                MessageBox.Show("Please be warned! \nthe product you selected maybe out numbered Please contact Supplier", "Warning!");
                return;
            }
            if (left < 0)
            {
                MessageBox.Show("There is no Item Left", "Warning!");
                return;
                
            }
          
            try
            {

                conn.dbcon();
                SqlCommand cm = new SqlCommand("INSERT INTO Sales (Sale_Date, Customer_ID) " + "Values ('" + txtsalesdate.Text + "', '" + txtcustid.Text + "' )");
                cm.Connection = Connectionclass.con;
                cm.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO SalesDetails (Product_ID, Price, Quantity) " + "Values ( '" + txtprodcode.Text + "','" + txtprice.Text + "', '" +txtquantity.Text +"')");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                int lefta = Convert.ToInt32(txtleftitem.Text);
                if (lefta <= 10)
                {
                    MessageBox.Show("Please be warned! \nthe product you selected maybe out numbered \nPlease contact Supplier!", "Warning!");

                }
                MessageBox.Show("Saved Successfully", "Saving");
              
              
                txtquantity.Text = "";
                txtprodcode.SelectedIndex = -1;
                txtcustid.SelectedIndex = -1;
                txtinfocustname.Clear();
                txtleftitem.Clear();
                txtquantity.Clear();
                txtinfoprod.Clear();
                txtdiscount.Clear();
                txtprice.Clear();
                txtTotal.Text = "0.00";
                
             
               
                //refresh
                
                cmd = new SqlCommand("SELECT * from SalesDetails");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Sales");
                dt = ds.Tables["Sales"];
           
                data.DataSource = ds.Tables["Sales"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtsalesdate.Text = DateTime.Now.ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
            }*/

           
        }

        private void data_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = data.SelectedRows[0];
            txtsaleno.Text = dr.Cells[0].Value.ToString();
            txtcustid.Text = dr.Cells[1].Value.ToString();
            txtprodcode.Text = dr.Cells[2].Value.ToString();
            txtprice.Text = dr.Cells[3].Value.ToString();
            txtquantity.Text = dr.Cells[4].Value.ToString();
            txtdiscount.Text = dr.Cells[5].Value.ToString();
            txtprice.ReadOnly = true;
            txtcustid.Enabled = true;
            txtprodcode.Enabled = true;
            txtquantity.ReadOnly = false;
            
          

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtquantity.Text = "";
            txtprodcode.SelectedIndex = -1;
            txtcustid.SelectedIndex = -1;
            txtinfocustname.Clear();
            txtleftitem.Clear();
            txtquantity.Clear();
            txtinfoprod.Clear();
            txtdiscount.Clear();
            txtprice.Clear();
            txtTotal.Text = "0.00";
            txtcustid.Enabled = false;
            txtquantity.ReadOnly = true;
            txtprodcode.Enabled = false;
            

        }

        private void txtprodcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                SqlCommand cm = new SqlCommand("select Product_Name, Description, Price , Product_ID from Products where Product_ID = '" + txtprodcode.Text + "'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR3 = cm.ExecuteReader();
                if (DR3.Read())
                {

                    txtinfoprod.Text = DR3.GetValue(0).ToString() + ",  " + DR3.GetValue(1).ToString() + ", Price P" + DR3.GetValue(2).ToString();
                    txtprice.Text = DR3.GetValue(2).ToString();

                }
                else
                {
                    txtinfoprod.Clear();
                    txtprice.Clear();
                }

            }
            catch 
            {
                
            }
            finally
            {
                conn.Closecon();
            }





            try
            {
                conn.dbcon();
                cmd = new SqlCommand("select Discount from Products where Product_ID = '" + txtprodcode.Text + "'");
                cmd.Connection = Connectionclass.con;
                SqlDataReader DR1 = cmd.ExecuteReader();
                if (DR1.Read())
                {
                    txtdiscount.Text = DR1.GetValue(0).ToString();
                }
                else
                {
                    txtdiscount.Clear();
                }
            }
            catch 
            {
               
            }
            finally
            {
                conn.Closecon();


            }

            try
            {
                conn.dbcon();
                SqlCommand tot = new SqlCommand("Select sum(Quantity) from stockcard where Product_ID = '" + txtprodcode.Text + "'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR1 = tot.ExecuteReader();
                if (DR1.Read())
                {
                    txtleftitem.Text = DR1.GetValue(0).ToString();
                }
                else
                {
                    txtleftitem.Clear();
                }
                
            }
            catch 
            {
               
            }
            finally
            {
                conn.Closecon();

            }
           
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            double a = 0, b = 0, demo;
            if (double.TryParse(txtprice.Text, out demo))
                a = double.Parse(txtprice.Text);
            if (double.TryParse(txtquantity.Text, out demo))
                b = double.Parse(txtquantity.Text); 

            double s = a * b;
            txtTotal.Text = s.ToString("0.00"); 
        }

       

      

      

      


        

     

       

      

       

    }
}

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
    public partial class addsales : Form
    {
        Connectionclass cc = new Connectionclass();


        DataTable dt;
        
        
      
        SqlDataReader dr1;

        public addsales()
        {
           
            InitializeComponent();
            DateTime today = DateTime.Today;
            txtsalesdate.Text = DateTime.Now.ToString();
            combosale();
            combo();
        }
        void combo()
        {
            cc.dbcon();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Customers");
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
                cc.Closecon();
            }


        }
        void combosale()
        {
            cc.dbcon();
            try
            {

                SqlCommand cmd = new SqlCommand("Select * from Products");
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
                cc.Closecon();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (data.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Unable to Save, List is EMPTY", "Error");
                return;
            }
            
            
           
                try
                {
                    cc.dbcon();
                    SqlCommand cmd = new SqlCommand("select * from addsales");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();

                    dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        cc.dbcon();
                        cmd = new SqlCommand("INSERT INTO SalesDetails (Product_ID, Price, Quantity, Discount) " + "Values ( '" + dr1.GetValue(0).ToString() + "','" + dr1.GetValue(1).ToString() + "', '" + dr1.GetValue(2).ToString() + "' , '" + dr1.GetValue(3).ToString() + "')");
                        cmd.Connection = Connectionclass.con;
                        cmd.ExecuteNonQuery();
                        SqlCommand cm = new SqlCommand("INSERT INTO Sales (Sale_Date, Customer_ID) " + "Values ('" + txtsalesdate.Text + "', '" + txtcustid.Text + "' )");
                        cm.Connection = Connectionclass.con;
                        cm.ExecuteNonQuery();

                    }
                    MessageBox.Show("Saved Successfully", "Saving");

                    //clear
                    txtcustid.Enabled = true;
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
                    //end clear
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                   
                    cc.dbcon();
                    SqlCommand cmd = new SqlCommand("delete from addsales");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    //refresh
                   cmd = new SqlCommand("select proID as 'Product ID', price as Price, qty as Quantity, discount as Discount from addsales ");
                    cmd.Connection = Connectionclass.con;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "discount");
                    dt = ds.Tables["discount"];
                    data.DataSource = ds.Tables["discount"];
                    data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DateTime dta = DateTime.Now;
                    txtsalesdate.Text = DateTime.Now.ToString();
                    cc.Closecon();


                }
            


     



        }

        private void addsales_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            try
            {
                cc.dbcon();
              
                
                SqlCommand cmd = new SqlCommand("select proID as 'Product ID', price as Price, qty as Quantity, discount as Discount from addsales ");
                cmd.Connection = Connectionclass.con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "discount");
                dt = ds.Tables["discount"];
                data.DataSource = ds.Tables["discount"];
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
                cc.Closecon();
            }





        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Add to list
            if (e.KeyData == Keys.F1)
            {
                ///Add to list
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
                ///


                if (txtcustid.Text == "" || txtprodcode.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
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
                    cc.dbcon();

                    SqlCommand cmd = new SqlCommand("INSERT INTO addsales (proID, price, qty, discount) " + "Values ('" + txtprodcode.Text + "','" + txtprice.Text + "', '" + txtquantity.Text + "' , '" + txtdiscount.Text + "')");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Added to the LIST", "Adding");


                    txtquantity.Text = "";
                    this.txtcustid.Enabled = false;
                    txtprodcode.Text = null;
       
                    txtleftitem.Clear();
                    txtquantity.Clear();
                    txtinfoprod.Clear();
                    txtdiscount.Clear();
                    txtprice.Clear();
                    txtprodname.Clear();
                    txtTotal.Text = "0.00";
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    cc.Closecon();
                    
                }


                ////Refresh/Refresh/Refresh
                ////Refresh/Refresh/Refresh

                try
                {
                    cc.dbcon();


                    SqlCommand cmd = new SqlCommand("select proID as 'Product ID', price as Price, qty as Quantity, discount as Discount from addsales ");
                    cmd.Connection = Connectionclass.con;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "discount");
                    dt = ds.Tables["discount"];
                    data.DataSource = ds.Tables["discount"];
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
                    cc.Closecon();
                }
            
            
        
          }
            //BACK
            if (e.KeyData == Keys.Escape)
            {
                cc.dbcon();
                SqlCommand cmd = new SqlCommand("delete from addsales");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                cc.Closecon();


                this.Hide();
                Sales display = new Sales();
                display.ShowDialog();
                this.Close();
            }

            ///Save List
            if (e.KeyData == Keys.F2)
            {
                if (data.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Unable to Save, List is EMPTY", "Error");
                    return;
                }
                try
                {
                    cc.dbcon();
                    SqlCommand cmd = new SqlCommand("select * from addsales");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();

                    dr1 = cmd.ExecuteReader();
                    while (dr1.Read())
                    {
                        cc.dbcon();
                        cmd = new SqlCommand("INSERT INTO SalesDetails (Product_ID, Price, Quantity, Discount) " + "Values ( '" + dr1.GetValue(0).ToString() + "','" + dr1.GetValue(1).ToString() + "', '" + dr1.GetValue(2).ToString() + "' , '" + dr1.GetValue(3).ToString() + "')");
                        cmd.Connection = Connectionclass.con;
                        cmd.ExecuteNonQuery();
                        SqlCommand cm = new SqlCommand("INSERT INTO Sales (Sale_Date, Customer_ID) " + "Values ('" + txtsalesdate.Text + "', '" + txtcustid.Text + "' )");
                        cm.Connection = Connectionclass.con;
                        cm.ExecuteNonQuery();

                    }
                    MessageBox.Show("Saved Successfully", "Saving");


                    txtcustid.Enabled = true;
                    txtquantity.Text = "";
                    txtprodcode.SelectedIndex = -1;
                    txtcustid.SelectedIndex = -1;
                    txtprodname.Clear();
                    txtinfocustname.Clear();
                    txtleftitem.Clear();
                    txtquantity.Clear();
                    txtinfoprod.Clear();
                    txtdiscount.Clear();
                    txtprice.Clear();
                    txtTotal.Text = "0.00";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    txtcustid.SelectedIndex = -1;
                    cc.dbcon();
                    SqlCommand cmd = new SqlCommand("delete from addsales");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    //refresh
                    cmd = new SqlCommand("select proID as 'Product ID', price as Price, qty as Quantity, discount as Discount from addsales ");
                    cmd.Connection = Connectionclass.con;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "discount");
                    dt = ds.Tables["discount"];
                    data.DataSource = ds.Tables["discount"];
                    data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DateTime dta = DateTime.Now;
                    txtsalesdate.Text = DateTime.Now.ToString();
                    cc.Closecon();


                }

            }  
        }

        private void txtcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cc.dbcon();
                SqlCommand tot = new SqlCommand("Select CustomerName from Customers where Customer_ID = '" + txtcustid.Text + "'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR2 = tot.ExecuteReader();
                if (DR2.Read())
                {
                    txtinfocustname.Text = DR2.GetValue(0).ToString();
                }
                else
                {
                    txtinfocustname.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                cc.Closecon();
            }

        }

        private void txtprodcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Rows[0].Cells[2].ToString();
            
            try
            {
                cc.dbcon();
                SqlCommand cm = new SqlCommand("select Product_Name, Description, Price , Product_ID , Discount from Products where Product_ID =  '" + txtprodcode.Text + "'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR3 = cm.ExecuteReader();
                if (DR3.Read())
                {

                    txtinfoprod.Text = DR3.GetValue(0).ToString() + ",  " + DR3.GetValue(1).ToString() + ", Price P" + DR3.GetValue(2).ToString();
                    txtprice.Text = DR3.GetValue(2).ToString();
                    txtdiscount.Text = DR3.GetValue(4).ToString();
                    txtprodname.Text = DR3.GetValue(0).ToString();


                }
                else
                {
                    txtinfoprod.Clear();
                    txtdiscount.Clear();
                    txtprodname.Clear();
                    txtprice.Clear();
                }
            }
            catch
            {

            }
            finally
            {
                cc.Closecon();
            }

            try
            {
                cc.dbcon();
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
                cc.Closecon();

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            cc.dbcon();
            SqlCommand cmd = new SqlCommand("delete from addsales");
            cmd.Connection = Connectionclass.con;
            cmd.ExecuteNonQuery();
            cc.Closecon();

            this.Hide();
            Sales display = new Sales();
            display.ShowDialog();
            this.Close();
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            calculate();

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

        private void button1_Click(object sender, EventArgs e)
        {
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
            ///


            if (txtcustid.Text == "" || txtprodcode.Text == "" || txtdiscount.Text == "" || txtprice.Text == "" || txtquantity.Text == "")
            {
                MessageBox.Show("All fields cannot be EMPTY!","Error");
                return;
            }

           int left = Convert.ToInt32(txtleftitem.Text);
            int q = Convert.ToInt32(txtquantity.Text);
            if(left <= 0)
            {
                MessageBox.Show("There is no Item Left, Product Not Available", "Error");
                return;
               
            }

            if (q > left)
            {
                MessageBox.Show("Naunsa ka!! mamaligya kag product nga wala namay stock BUGO", "Error");
                return;

            }
           


            try
            {
                cc.dbcon();
              
                SqlCommand cmd = new SqlCommand("INSERT INTO addsales (proID, price, qty, discount) " + "Values ('" + txtprodcode.Text + "','" + txtprice.Text + "', '" + txtquantity.Text + "' , '"+txtdiscount.Text+"')");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();

                if (left <= 15)
                {

                    MessageBox.Show("Please be warned! \nthe product you selected maybe out numbered Please contact Supplier", "Warning!");
                   

                }
               
                MessageBox.Show("Successfully Added to the LIST", "Adding");


                txtquantity.Text = "";
                this.txtcustid.Enabled = false;
                txtprodcode.Text = null;

                txtleftitem.Clear();
                txtquantity.Clear();
                txtinfoprod.Clear();
                txtdiscount.Clear();
                txtprice.Clear();
                txtprodname.Clear();
                txtTotal.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                cc.Closecon();

            }


            ////Refresh/Refresh/Refresh
            ////Refresh/Refresh/Refresh

            try
            {
                cc.dbcon();


                SqlCommand cmd = new SqlCommand("select proID as 'Product ID', price as Price, qty as Quantity, discount as Discount from addsales ");
                cmd.Connection = Connectionclass.con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "discount");
                dt = ds.Tables["discount"];
                data.DataSource = ds.Tables["discount"];
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
                cc.Closecon();
            }


        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            txtcustid.Enabled = false;
        }


        private void txtprodcode_TextChanged(object sender, EventArgs e)
        {

            try
            {
                cc.dbcon();
                SqlCommand cm = new SqlCommand("select Product_Name, Description, Price , Product_ID , Discount from Products where Product_ID like  '" + txtprodcode.Text + "%'");
                cm.Connection = Connectionclass.con;
                SqlDataReader DR3 = cm.ExecuteReader();
                if (DR3.Read())
                {

                    txtinfoprod.Text = DR3.GetValue(0).ToString() + ",  " + DR3.GetValue(1).ToString() + ", Price P" + DR3.GetValue(2).ToString();
                    txtprice.Text = DR3.GetValue(2).ToString();
                    txtdiscount.Text = DR3.GetValue(4).ToString();
                    txtprodname.Text = DR3.GetValue(0).ToString();


                }
                else
                {
                    txtinfoprod.Clear();
                    txtdiscount.Clear();
                    txtprodname.Clear();
                    txtprice.Clear();
                }
            }
            catch
            {

            }
            finally
            {
                cc.Closecon();
            }

            try
            {
                cc.dbcon();
                SqlCommand tot = new SqlCommand("Select sum(Quantity) from stockcard where Product_ID like '" + txtprodcode.Text + "%'");
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
                cc.Closecon();

            }

        }

        private void txtcustid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cc.dbcon();
                SqlCommand tot = new SqlCommand("Select CustomerName from Customers where Customer_ID = '" + txtcustid.Text + "'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR2 = tot.ExecuteReader();
                if (DR2.Read())
                {
                    txtinfocustname.Text = DR2.GetValue(0).ToString();
                }
                else
                {
                    txtinfocustname.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                cc.Closecon();
            }


        }



    }
}

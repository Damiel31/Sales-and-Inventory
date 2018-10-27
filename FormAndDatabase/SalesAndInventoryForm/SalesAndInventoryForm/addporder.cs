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
    public partial class addporder : Form
    {
        Connectionclass conn = new Connectionclass();

        SqlCommand cmd;
        
        DataTable dt;

        public addporder()
        {

            InitializeComponent();
            DateTime dt = DateTime.Now;
            txtordersdate.Text = DateTime.Now.ToString();
            comboprod();
            combo();
        }


        void combo()
        {
            conn.dbcon();
            cmd = new SqlCommand("Select * from Suppliers");
            cmd.Connection = Connectionclass.con;
            SqlDataReader dr;
            try
            {

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    long set = dr.GetInt64(0);
                    combosupid.Items.Add(set);
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

        void comboprod()
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
                    txtprodid.Items.Add(set);
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










        private void btnsave_Click(object sender, EventArgs e)
        {
            bool error = true;
            bool error1 = true;
            bool error2 = true;
            string id = combosupid.Text;
            string pcode = txtprodid.Text;
            string qty = txtqty.Text;
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
                MessageBox.Show("The Supplier ID you entered does not exist in the RECORD", "Error");
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
                MessageBox.Show("The Product Code you entered does not exist in the RECORD", "Error");
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





            if (combosupid.Text == "" || txtprodid.Text == "" || txtqty.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("All fields cannot be empty", "Error");
                return;
            }
             try
            {
                conn.dbcon();

                cmd = new SqlCommand("INSERT INTO addorders (prodID, cost, qty) " + "Values ('" + txtprodid.Text + "','" + txtcost.Text + "', '" + txtqty.Text + "')");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();

                

                MessageBox.Show("Successfully Added to the LIST", "Adding");


                txtqty.Text = "";
                txtprodid.SelectedIndex = -1;


               
                txtqty.Clear();
                txtcost.Clear();
                txtprodname.Clear();
                txtTotal.Text = "0.00";
                txtunitmeas.Clear();
                combosupid.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();

            }


            ////Refresh/Refresh/Refresh
            ////Refresh/Refresh/Refresh

            try
            {
                conn.dbcon();


                cmd = new SqlCommand("select prodID as 'Product ID', cost as Price, qty as Quantity from addorders ");
                cmd.Connection = Connectionclass.con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "discount");
                dt = ds.Tables["discount"];
                data.DataSource = ds.Tables["discount"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtordersdate.Text = DateTime.Now.ToString();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders display = new Orders();
            display.ShowDialog();
        }

        private void combosupid_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                conn.dbcon();
                SqlCommand tot = new SqlCommand("Select Supplier_name from Suppliers where Supplier_ID like '" + combosupid.Text + "%'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR2 = tot.ExecuteReader();
                if (DR2.Read())
                {
                    txtsupname.Text = DR2.GetValue(0).ToString();
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

        private void txtprodid_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.dbcon();
            try
            {
                SqlCommand tot = new SqlCommand("Select Product_Name, Unit_Measure, Cost from Products where Product_ID = '" + txtprodid.Text + "'");
                tot.Connection = Connectionclass.con;
                SqlDataReader DR = tot.ExecuteReader();
                if (DR.Read())
                {
                    txtprodname.Text = DR.GetValue(0).ToString();
                    txtunitmeas.Text = DR.GetValue(1).ToString();
                    txtcost.Text = DR.GetValue(2).ToString();
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

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void addporder_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);


            try
            {
                conn.dbcon();


                SqlCommand cmd = new SqlCommand("select prodID as 'Product ID', cost as Price, qty as Quantity from addorders ");
                cmd.Connection = Connectionclass.con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "discount");
                dt = ds.Tables["discount"];
                data.DataSource = ds.Tables["discount"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtordersdate.Text = DateTime.Now.ToString();
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
            //add orders
            if (e.KeyData == Keys.F1)
            {

                bool error = true;
                bool error1 = true;
                bool error2 = true;
                string id = combosupid.Text;
                string pcode = txtprodid.Text;
                string qty = txtqty.Text;
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
                    MessageBox.Show("The Supplier ID you entered does not exist in the RECORD", "Error");
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
                    MessageBox.Show("The Product Code you entered does not exist in the RECORD", "Error");
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





                if (combosupid.Text == "" || txtprodid.Text == "" || txtqty.Text == "" || txtTotal.Text == "")
                {
                    MessageBox.Show("All fields cannot be empty", "Error");
                    return;
                }

                try
                {
                    conn.dbcon();
                    SqlCommand cm = new SqlCommand("INSERT INTO Orders (Order_Date, Supplier_ID) " + "Values ('" + txtordersdate.Text + "', '" + combosupid.Text + "' )");
                    cm.Connection = Connectionclass.con;
                    cm.ExecuteNonQuery();
                    cmd = new SqlCommand("INSERT INTO OrderDetails (Product_ID, Cost, Quantity) " + "Values ('" + txtprodid.Text + "', '" + txtcost.Text + "' , '" + txtqty.Text + "')");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfully", "Saving");
                    ///clear

                    txtqty.Clear();
                    txtprodid.SelectedIndex = -1;
                    combosupid.SelectedIndex = -1;
                    txtsupname.Clear();
                    txtprodname.Clear();
                    txtunitmeas.Clear();
                    txtcost.Clear();
                    txtTotal.Text = "0.00";


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

            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Orders display = new Orders();
                display.ShowDialog();
 
            }
        
        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            double a = 0, b = 0, demo;
            if (double.TryParse(txtcost.Text, out demo))
                a = double.Parse(txtcost.Text);
            if (double.TryParse(txtqty.Text, out demo))
                b = double.Parse(txtqty.Text);

            double s = a * b;
            txtTotal.Text = s.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(data.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Unable to Save, List is EMPTY", "Error");
                return;
            }



            try
            {
                conn.dbcon();
                SqlCommand cmd = new SqlCommand("select * from addorders");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    conn.dbcon();
                    cmd = new SqlCommand("INSERT INTO OrderDetails (Product_ID, Cost, Quantity) " + "Values ( '" + dr1.GetValue(0).ToString() + "','" + dr1.GetValue(1).ToString() + "', '" + dr1.GetValue(2).ToString() + "')");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    SqlCommand cm = new SqlCommand("INSERT INTO Orders (Order_Date, Supplier_ID) " + "Values ('" + txtordersdate.Text + "', '" + combosupid.Text + "' )");
                    cm.Connection = Connectionclass.con;
                    cm.ExecuteNonQuery();

                }
                MessageBox.Show("Saved Successfully", "Saving");


                combosupid.Enabled = true;
                txtqty.Text = "";
                txtprodid.SelectedIndex = -1;
                combosupid.SelectedIndex = -1;
                txtsupname.Clear();              
                txtqty.Clear();
                txtcost.Clear();
                txtunitmeas.Clear();
                txtTotal.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.dbcon();
                 cmd = new SqlCommand("delete from addorders");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                //refresh
                cmd = new SqlCommand("select prodID as 'Product ID', cost as Price, qty as Quantity from addorders ");
                cmd.Connection = Connectionclass.con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "discount");
                dt = ds.Tables["discount"];
                data.DataSource = ds.Tables["discount"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtordersdate.Text = DateTime.Now.ToString();
                conn.Closecon();


            }
            


     



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (data.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Unable to Save, List is EMPTY", "Error");
                return;
            }



            try
            {
                conn.dbcon();
                SqlCommand cmd = new SqlCommand("select * from addorders");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                SqlDataReader dr1;
                dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    conn.dbcon();
                    cmd = new SqlCommand("INSERT INTO OrderDetails (Product_ID, Cost, Quantity) " + "Values ( '" + dr1.GetValue(0).ToString() + "','" + dr1.GetValue(1).ToString() + "', '" + dr1.GetValue(2).ToString() + "')");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    SqlCommand cm = new SqlCommand("INSERT INTO Orders (Order_Date, Supplier_ID) " + "Values ('" + txtordersdate.Text + "', '" + combosupid.Text + "' )");
                    cm.Connection = Connectionclass.con;
                    cm.ExecuteNonQuery();

                }
                MessageBox.Show("Saved Successfully", "Saving");


                combosupid.Enabled = true;
                txtqty.Text = "";
                txtprodid.SelectedIndex = -1;
                combosupid.SelectedIndex = -1;
                txtsupname.Clear();
                txtqty.Clear();
                txtcost.Clear();
                txtunitmeas.Clear();
                txtTotal.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.dbcon();
                cmd = new SqlCommand("delete from addorders");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                //refresh
                cmd = new SqlCommand("select prodID as 'Product ID', cost as Price, qty as Quantity from addorders ");
                cmd.Connection = Connectionclass.con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder cmb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "discount");
                dt = ds.Tables["discount"];
                data.DataSource = ds.Tables["discount"];
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DateTime dta = DateTime.Now;
                txtordersdate.Text = DateTime.Now.ToString();
                conn.Closecon();


            }
            


        }


    }
}

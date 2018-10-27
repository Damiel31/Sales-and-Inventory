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
    public partial class Orders : Form
    {
        Connectionclass conn = new Connectionclass();

        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;



        public Orders()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            txtordersdate.Text = DateTime.Now.ToString();
            combo();
            comboprod();
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



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();      
        }

        private void ComputeAdd_Click(object sender, EventArgs e)
        {

            this.Hide();
            addporder disply = new addporder();
            disply.ShowDialog();

            /*if (combosupid.Text == "" || txtprodid.Text == "" || txtqty.Text == "" || txtTotal.Text == "")
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
                
                txtqty.Text = "";
                txtprodid.SelectedIndex = -1;
                combosupid.SelectedIndex = -1;
                txtsupname.Clear();
                txtprodname.Clear();
                txtunitmeas.Clear();
                txtTotal.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
                txtcost.Clear();
            }
            //refresh
            
            try
            {

                conn.dbcon();
                cmd = new SqlCommand("Select * from OrderDetails");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "OrderDt");
                dt = ds.Tables["OrderDt"];
                data.DataSource = ds.Tables["OrderDt"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtTotal.ReadOnly = true;
                txtordersdate.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }*/


        }

        private void Orders_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            try
            {
                conn.dbcon();

                cmd = new SqlCommand("select OD.Order_No, O.Supplier_ID, OD.Product_ID, OD.Cost, OD.Quantity from Orders O inner join OrderDetails OD on O.Order_No = OD.Order_No order by OD.Order_No DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "OrderDt");
                dt = ds.Tables["OrderDt"];

                data.DataSource = ds.Tables["OrderDt"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtTotal.ReadOnly = true;
                txtordersdate.ReadOnly = true;

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
            //add orders
            if (e.KeyData == Keys.F1)
            {

                this.Hide();
                addporder disply = new addporder();
                disply.ShowDialog();

               /* if (combosupid.Text == "" || txtprodid.Text == "" || txtqty.Text == "" || txtTotal.Text == "")
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
                    
                    txtqty.Text = "";
                    txtprodid.SelectedIndex = -1;
                    combosupid.SelectedIndex = -1;
                    txtsupname.Clear();
                    txtprodname.Clear();
                    txtunitmeas.Clear();
                    txtTotal.Text = "0.00";

                    ///refresh
                    cmd = new SqlCommand("Select * from OrderDetails");
                    cmd.Connection = Connectionclass.con;
                    sda = new SqlDataAdapter(cmd);
                    cmb = new SqlCommandBuilder(sda);
                    ds = new DataSet();
                    sda.Fill(ds, "OrderDt");
                    dt = ds.Tables["OrderDt"];
                 
                    data.DataSource = ds.Tables["OrderDt"];
                    data.ReadOnly = false;
                    data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    txtTotal.ReadOnly = true;
                    txtordersdate.ReadOnly = true;

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                finally
                {
                    conn.Closecon();
                    txtcost.Clear();
                }*/

            }
            ///update

            if (e.KeyData == Keys.Enter || e.KeyData == Keys.F2)
            {

                ////UPDATE
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








                if (txtprodid.Text == "" || txtqty.Text == "" || txtTotal.Text == "")
                {
                    MessageBox.Show("No such Record To Update", "Error");
                    return;
                }
                try
                {
                    conn.dbcon();
                    cmb = new SqlCommandBuilder(sda);
                    sda.Update(ds, "OrderDt");
                    cmd = new SqlCommand("Update OrderDetails set Product_ID  = '" + txtprodid.Text + "' , Cost = '" + txtcost.Text + "', Quantity = '" + txtqty.Text + "' where Order_No = '" + txtorderno.Text + "'");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Update Orders set Supplier_ID  = '" + combosupid.Text + "' where Order_No = '" + txtorderno.Text + "'");
                    cmd.Connection = Connectionclass.con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "Update");

                    ///clear
                    combosupid.SelectedIndex = -1;
                    txtprodid.SelectedIndex = -1;
                    txtprodname.Clear();
                    txtsupname.Clear();
                    txtunitmeas.Clear();
                    txtcost.Clear();
                    txtqty.Clear();
                    txtTotal.Text = "0.00";
                    combosupid.Enabled = false;
                    txtprodid.Enabled = false;
                    txtqty.ReadOnly = true;

                    //refresh

                    cmd = new SqlCommand("select OD.Order_No, O.Supplier_ID, OD.Product_ID, OD.Cost, OD.Quantity from Orders O inner join OrderDetails OD on O.Order_No = OD.Order_No order by OD.Order_No DESC");
                    cmd.Connection = Connectionclass.con;
                    sda = new SqlDataAdapter(cmd);
                    cmb = new SqlCommandBuilder(sda);
                    ds = new DataSet();
                    sda.Fill(ds, "OrderDt");
                    dt = ds.Tables["OrderDt"];

                    data.DataSource = ds.Tables["OrderDt"];
                    data.ReadOnly = false;
                    data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    txtTotal.ReadOnly = true;
                    txtordersdate.ReadOnly = true;
                    ComputeAdd.Enabled = true;

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
            //back
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Main display = new Main();
                display.ShowDialog();
                this.Close();
            }

            //add product or items
            if (e.KeyData == Keys.F3)
            {
                this.Hide();
                Item display = new Item();
                display.ShowDialog();
            }

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            ////UPDATE
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








            if ( txtprodid.Text == "" || txtqty.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("No such Record To Update", "Error");
                return;
            }
            try
            {
                conn.dbcon();
                cmb = new SqlCommandBuilder(sda);
                sda.Update(ds, "OrderDt");
                cmd = new SqlCommand("Update OrderDetails set Product_ID  = '" + txtprodid.Text + "' , Cost = '" + txtcost.Text + "', Quantity = '" + txtqty.Text + "' where Order_No = '" + txtorderno.Text + "'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Update Orders set Supplier_ID  = '" + combosupid.Text + "' where Order_No = '" + txtorderno.Text + "'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Update");

                ///clear
                combosupid.SelectedIndex = -1;
                txtprodid.SelectedIndex = -1;
                txtprodname.Clear();
                txtsupname.Clear();
                txtunitmeas.Clear();
                txtcost.Clear();
                txtqty.Clear();
                txtTotal.Text = "0.00";
                combosupid.Enabled = false;
                txtprodid.Enabled = false;
                txtqty.ReadOnly = true;

                //refresh

                cmd = new SqlCommand("select OD.Order_No, O.Supplier_ID, OD.Product_ID, OD.Cost, OD.Quantity from Orders O inner join OrderDetails OD on O.Order_No = OD.Order_No order by OD.Order_No DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "OrderDt");
                dt = ds.Tables["OrderDt"];
         
                data.DataSource = ds.Tables["OrderDt"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtTotal.ReadOnly = true;
                txtordersdate.ReadOnly = true;
                ComputeAdd.Enabled = true;

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

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {

                conn.dbcon();



              
                cmd = new SqlCommand("Select * from OrderDetails");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "OrderDt");
                dt = ds.Tables["OrderDt"];
        
                data.DataSource = ds.Tables["OrderDt"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtTotal.ReadOnly = true;
                txtordersdate.ReadOnly = true;

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

        private void button2_Click_2(object sender, EventArgs e)
        {

            try
            {

                conn.dbcon();

              
                cmd = new SqlCommand("Select * from OrderDetails");
                cmd.Connection = Connectionclass.con;

                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "OrderDt");
                dt = ds.Tables["OrderDt"];
               
                data.DataSource = ds.Tables["OrderDt"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                txtTotal.ReadOnly = true;
                txtordersdate.ReadOnly = true;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Item display = new Item();
            display.ShowDialog();
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

        private void data_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = data.SelectedRows[0];
            txtorderno.Text = dr.Cells[0].Value.ToString();
            combosupid.Text = dr.Cells[1].Value.ToString();
            txtprodid.Text = dr.Cells[2].Value.ToString();
            txtcost.Text = dr.Cells[3].Value.ToString();
            txtqty.Text = dr.Cells[4].Value.ToString();
            combosupid.Enabled = true;
            txtprodid.Enabled = true;
            txtqty.ReadOnly = false;
 
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


      

        
        
    }
}

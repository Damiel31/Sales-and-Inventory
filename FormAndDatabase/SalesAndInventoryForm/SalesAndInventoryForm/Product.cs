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
    public partial class Admin : Form
    {
        Connectionclass conn = new Connectionclass();

        DataSet ds, ds1;
        SqlDataAdapter sda, sda1;
        SqlCommandBuilder cmb,cmb1;
        SqlCommand cmd, cmd1;
        DataTable dt, dt1;

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           ///// start change information
         
            try
            {
                conn.dbcon();
              
                cmd = new SqlCommand("SELECT Product_ID, Product_Name, Cost, Price, Discount FROM Products order by Product_ID ASC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "prd");
                dt = ds.Tables["prd"];

                datachange.DataSource = ds.Tables["prd"];
              
                datachange.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
            }
            ///// end change information
            ///


            ///// start security access 
       
            try
            {
                conn.dbcon();
                cmd1 = new SqlCommand("SELECT * from userpass order by staffID ASC");
                cmd1.Connection = Connectionclass.con;
               
                sda1 = new SqlDataAdapter(cmd1);
                cmb1 = new SqlCommandBuilder(sda1);
                 ds1 = new DataSet();
                sda1.Fill(ds1, "security");
                dt1 = ds1.Tables["security"];

                dataaccess.DataSource = ds1.Tables["security"];
                dataaccess.ReadOnly = false;
                dataaccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
            }
            ///// end security access
            


         
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            conn.dbcon();
            try
            {
                cmd = new SqlCommand("Select Product_ID, Product_Name, Cost, Price, Discount from Products where Product_ID like '" + txtsearch.Text + "%'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                datachange.DataSource = dt;
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

        private void data_MouseClick(object sender, MouseEventArgs e)
        {

            DataGridViewRow dr = datachange.SelectedRows[0];
            txtprodid.Text = dr.Cells[0].Value.ToString();
            txtprodname.Text = dr.Cells[1].Value.ToString();
            txtcost.Text = dr.Cells[2].Value.ToString();
            txtprice.Text = dr.Cells[3].Value.ToString();
            txtdiscount.Text = dr.Cells[4].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {


            bool error = true;
            bool error1 = true;
            string price = txtprice.Text;
            string dis = txtdiscount.Text;
            //Start TXTprice Constraints
            char ch = ' ';
            for (int a = 0; a < price.Length; a++)
            {

                ch = price[a];

                if (ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9' || ch == '0')
                {
                    error = true;
                }
                else
                {
                    error = false;
                }
            }
            if (error == false)
            {
                MessageBox.Show("Invalid Input Please Checked Price Field for INCORRECT input", "Error");
                return;
            }
            ///end of txtprice Constraints
            ///
            //Start TXTdiscount Constraints
            foreach (char c in dis)
            {
                if (!Char.IsNumber(c))
                {
                    error1 = false;
                    break;
                }
            }
            if (error1 == false)
            {
                MessageBox.Show("Invalid Input Please Checked Discount Field for INCORRECT input", "Error");
                return;
            }
            ///end of txtdiscount Constraints
            ///

            if (txtprice.Text == "" || txtdiscount.Text == "")
            {
                MessageBox.Show("Price and Discount Field Cannot be Empty", "Error");
                return;
            }

           
            try
            {

                conn.dbcon();
                cmb = new SqlCommandBuilder(sda);
                sda.Update(ds, "prd");
                cmd = new SqlCommand("Update Products set Price  = '" + txtprice.Text + "' , Discount = '" + txtdiscount.Text+ "'  where Product_ID = '" + txtprodid.Text + "'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Successfully Updated", "Update");
                ///Clear Clear CLear
                ///
                txtprodid.Clear();
                txtprodname.Clear();
                txtcost.Clear();
                txtprice.Clear();
                txtdiscount.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }


            ////REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!

            try
            {
                conn.dbcon();

                cmd = new SqlCommand("SELECT Product_ID, Product_Name, Cost, Price, Discount FROM Products order by Product_ID ASC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "prd");
                dt = ds.Tables["prd"];
                datachange.DataSource = ds.Tables["prd"];
                datachange.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void txtstaff_TextChanged(object sender, EventArgs e)
        {
            conn.dbcon();
            try
            {
                cmd = new SqlCommand("Select * from userpass where staffID like '" + txtstaff.Text + "%'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataaccess.DataSource = dt;
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

        private void dataaccess_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataaccess.SelectedRows[0];
            txtstaffid.Text = dr.Cells[0].Value.ToString();
            txtstaffname.Text = dr.Cells[1].Value.ToString();
            txtuser.Text = dr.Cells[2].Value.ToString();
            txtpass.Text = dr.Cells[3].Value.ToString();
            btnadd.Enabled = false;
            btnupdates.Enabled = true;
            btndel.Enabled = true;
        }

        private void btnupdates_Click(object sender, EventArgs e)
        {
            bool error = true;
            bool error1 = true;

            string name = txtstaffname.Text;
            string user = txtuser.Text;
            string pass = txtpass.Text;
            ////start of txtstaff name constraints
            foreach (char c in name)
            {
                if (Char.IsNumber(c))
                {
                    error = false;
                    break;
                }
            }
            char ch = ' ';
            for (int a = 0; a < name.Length; a++)
            {

                ch = name[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error = false;
                }
            }
            if (error == false)
            {
                MessageBox.Show("Invalid input! Please Check Staff Name Field for INCORRECT input", "Error");
                return;
            }

            ////End of txtstaffname constraints
            ///
            ////start of txtuserandpass name constraints

            for (int a = 0; a < user.Length; a++)
            {

                ch = user[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error1 = false;
                }
            }
            for (int a = 0; a < pass.Length; a++)
            {

                ch = pass[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error1 = false;
                }
            }
            if (error1 == false)
            {
                MessageBox.Show("Invalid input! Numbers and Letters input only in Username and Password ", "Error");
                return;
            }

            ////End of txtuserandpass constraints
            ///

            if (txtstaffname.Text == "" || txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("All fields Cannot be empty","Error");
                return;
            }
            try
            {
                conn.dbcon();
                cmb1 = new SqlCommandBuilder(sda1);
                sda1.Update(ds1, "security");
                cmd1 = new SqlCommand("Update userpass set staffName  = '" + txtstaffname.Text + "' , username = '" + txtuser.Text + "'  , password = '" + txtpass.Text + "'  where staffID = '" + txtstaffid.Text + "'");
                cmd1.Connection = Connectionclass.con;
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated", "Update");
                ///Clear Clear CLear
                ///
                txtstaffid.Clear();
                txtstaffname.Clear();
                txtuser.Clear();
                txtpass.Clear();
                btnupdates.Enabled = false;
                btnadd.Enabled = true;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }


            ////REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!

            try
            {
                cmd1 = new SqlCommand("SELECT * from userpass order by staffID ASC");
                cmd1.Connection = Connectionclass.con;
                sda1 = new SqlDataAdapter(cmd1);
                cmb1 = new SqlCommandBuilder(sda1);
                ds1 = new DataSet();
                sda1.Fill(ds1, "security");
                dt1 = ds1.Tables["security"];

                dataaccess.DataSource = ds1.Tables["security"];
                dataaccess.ReadOnly = false;
                dataaccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void txtprice_MouseClick(object sender, MouseEventArgs e)
        {
            txtprice.Clear();
        }

        private void txtdiscount_MouseClick(object sender, MouseEventArgs e)
        {
            txtdiscount.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtprodid.Clear();
            txtprodname.Clear();
            txtcost.Clear();
            txtprice.Clear();
            txtdiscount.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bool error = true;
            bool error1 = true;
            
            string name = txtstaffname.Text;
            string user = txtuser.Text;
            string pass = txtpass.Text;
            ////start of txtstaff name constraints
            foreach (char c in name)
            {
                if (Char.IsNumber(c))
                {
                    error = false;
                    break;
                }
            }
            char ch = ' ';
            for (int a = 0; a < name.Length; a++)
            {

                ch = name[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error = false;
                }
            }
            if (error == false)
            {
                MessageBox.Show("Invalid input! Please Check Staff Name Field for INCORRECT input", "Error");
                return;
            }

            ////End of txtstaffname constraints
            ///
            ////start of txtuserandpass name constraints
            
            for (int a = 0; a < user.Length; a++)
            {

                ch = user[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error1 = false;
                }
            }
            for (int a = 0; a < pass.Length; a++)
            {

                ch = pass[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error1 = false;
                }
            }
            if (error1 == false)
            {
                MessageBox.Show("Invalid input! Numbers and Letters input only in Username and Password ", "Error");
                return;
            }

            ////End of txtuserandpass constraints
            ///

            if (txtstaffname.Text == "" || txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("All fields Cannot be empty", "Error");
                return;
            }

            try
            {
                conn.dbcon();
                SqlCommand com = new SqlCommand("INSERT INTO userpass (staffName, username, password) " + "Values ('" + txtstaffname.Text + "','" + txtuser.Text + "','" + txtpass.Text + "' )");
                com.Connection = Connectionclass.con;
                com.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully", "Saving");

                txtstaffid.Clear();
                txtstaffname.Clear();
                txtuser.Clear();
                txtpass.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Closecon();
            }

            ///REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!/REFRESH!!
            ///
          try
            {
                conn.dbcon();
                cmd1 = new SqlCommand("SELECT * from userpass order by staffID ASC");
                cmd1.Connection = Connectionclass.con;
               
                sda1 = new SqlDataAdapter(cmd1);
                cmb1 = new SqlCommandBuilder(sda1);
                 ds1 = new DataSet();
                sda1.Fill(ds1, "security");
                dt1 = ds1.Tables["security"];

                dataaccess.DataSource = ds1.Tables["security"];
                dataaccess.ReadOnly = false;
                dataaccess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void btnclears_Click(object sender, EventArgs e)
        {
            txtstaffid.Clear();
            txtstaffname.Clear();
            txtuser.Clear();
            txtpass.Clear();
            btnadd.Enabled = true;
            btnupdates.Enabled = false;
            btndel.Enabled = false;

        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                dataaccess.Rows.RemoveAt(dataaccess.SelectedRows[0].Index);

                sda1.Update(dt1);
              btndel.Enabled = false;
               btnupdates.Enabled = false;
               btnadd.Enabled = true;

               MessageBox.Show("Successfully Deleted", "Deleting");
            }
            
        }

       

       
    




    }
}

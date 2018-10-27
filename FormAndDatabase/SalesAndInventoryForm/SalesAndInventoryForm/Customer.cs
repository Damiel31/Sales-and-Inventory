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
    public partial class CustomerInformation : Form
    {

        Connectionclass conn = new Connectionclass();
             
        public CustomerInformation()
        {
            InitializeComponent();
        }

        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;
  

        private void Customer_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            conn.dbcon();
            try
            {
                cmd = new SqlCommand ("SELECT * FROM Customers order by Customer_ID DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Customer");
                dt = ds.Tables["Customer"];
             
                data.DataSource = ds.Tables["Customer"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (e.KeyData == Keys.F1)
            {
                this.Hide();
                addcust display = new addcust();
                display.ShowDialog();

            }
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Main display = new Main();
                display.ShowDialog();
                this.Close();
            }
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.F2)
            {
                string a = txtact.Text;

                if (txtcustid.Text == "" || txtname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "")
                {
                    MessageBox.Show("No such Record To Update", "Error");
                    return;
                }
                if (a.Equals("Y") || a.Equals("N") || a.Equals("y") || a.Equals("n") || a.Equals(""))
                {


                    try
                    {
                        conn.dbcon();
                        cmb = new SqlCommandBuilder(sda);
                        sda.Update(ds, "Customer");
                        cmd = new SqlCommand("Update Customers set CustomerName  = '" + txtname.Text + "' , Address = '" + txtaddress.Text + "',Contact_No = '" + txtcontact.Text + "', Status = '" + txtact.Text + "' where Customer_ID = '" + txtcustid.Text + "'");
                        cmd.Connection = Connectionclass.con;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated", "Update");

                        txtcustid.Clear();
                        txtname.Clear();
                        txtaddress.Clear();
                        txtcontact.Clear();
                        txtact.Clear();
                        txtcustid.ReadOnly = true;
                        txtname.ReadOnly = true;
                        txtaddress.ReadOnly = true;
                        txtcontact.ReadOnly = true;
                        txtact.ReadOnly = true;



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                    }
                    finally
                    {
                        conn.Closecon();
                    }
                    //////REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!
                    try
                    {
                        conn.dbcon();
                        cmd = new SqlCommand("SELECT * FROM Customers order by Customer_ID DESC");
                        cmd.Connection = Connectionclass.con;
                        sda = new SqlDataAdapter(cmd);
                        cmb = new SqlCommandBuilder(sda);
                        ds = new DataSet();
                        sda.Fill(ds, "Customer");
                        dt = ds.Tables["Customer"];

                        data.DataSource = ds.Tables["Customer"];
                        data.ReadOnly = false;
                        data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                else
                {
                    MessageBox.Show("Y or N input Only; Y stands for Yes and N stands for No", "Error");
                    return;
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main dis = new Main();
            dis.Show();
            this.Close();
        }

        ///UPDATE
        private void Updates_Click(object sender, EventArgs e)
        {         
            string a = txtact.Text;

            if (txtcustid.Text == "" || txtname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "")
            {
                MessageBox.Show("No such Record To Update", "Error");
                return;
            }
            if (a.Equals("Y") || a.Equals("N") || a.Equals("y") || a.Equals("n") || a.Equals(""))
         {
                    
          
            try
            {
                conn.dbcon();
                cmb = new SqlCommandBuilder(sda);
                sda.Update(ds, "Customer");
                cmd = new SqlCommand("Update Customers set CustomerName  = '" + txtname.Text + "' , Address = '" + txtaddress.Text + "',Contact_No = '" + txtcontact.Text + "', Status = '" + txtact.Text + "' where Customer_ID = '"+txtcustid.Text+"'");
                cmd.Connection = Connectionclass.con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Update");

                txtcustid.Clear();
                txtname.Clear();
                txtaddress.Clear();
                txtcontact.Clear();
                txtact.Clear();
                txtcustid.ReadOnly = true;
                txtname.ReadOnly = true;
                txtaddress.ReadOnly = true;
                txtcontact.ReadOnly = true;
                txtact.ReadOnly = true;
                
               
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            finally
            {
                conn.Closecon();
            }
            //////REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!REFRESH!!!
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("SELECT * FROM Customers order by Customer_ID DESC");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Customer");
                dt = ds.Tables["Customer"];

                data.DataSource = ds.Tables["Customer"];
                data.ReadOnly = false;
                data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
             else
            {
                MessageBox.Show("Y or N input Only; Y stands for Yes and N stands for No", "Error");
                return;
            }


        }
        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            conn.dbcon();
            try
            {
                cmd = new SqlCommand("select * from Customers where CustomerName like '" + txtsearchcus.Text + "%'");
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

        private void data_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = data.SelectedRows[0];
            txtcustid.Text = dr.Cells[0].Value.ToString();
            txtname.Text = dr.Cells[1].Value.ToString();
            txtaddress.Text = dr.Cells[2].Value.ToString();
            txtcontact.Text = dr.Cells[3].Value.ToString();
            txtact.Text = dr.Cells[4].Value.ToString();
            txtcustid.ReadOnly = true;
            txtname.ReadOnly = false;
            txtaddress.ReadOnly = false;
            txtcontact.ReadOnly = false;
            txtact.ReadOnly = false;
           
        

        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcust display = new addcust();
            display.ShowDialog();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcustid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            txtact.Clear(); ;
            txtcustid.ReadOnly = true;
            txtname.ReadOnly = true;
            txtaddress.ReadOnly = true;
            txtcontact.ReadOnly = true;
            txtact.ReadOnly = true;
            
           
        }

        private void txtsearchcus_MouseClick(object sender, MouseEventArgs e)
        {
            txtsearchcus.Clear();
        }

        private void txtact_MouseClick(object sender, MouseEventArgs e)
        {
            txtact.Clear();
        }

       

       

     

      
       

       

       

    }
}

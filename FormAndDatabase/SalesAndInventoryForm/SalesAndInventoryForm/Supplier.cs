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
    public partial class Supplier : Form
    {
        Connectionclass conn = new Connectionclass();

        DataSet ds;
        SqlDataAdapter sda;
        SqlCommandBuilder cmb;
        SqlCommand cmd;
        DataTable dt;




        public Supplier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();      
        }

      

        private void Supplier_Load(object sender, EventArgs e)
        {
           
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            try
            {
                conn.dbcon();

                cmd = new SqlCommand("SELECT * FROM Suppliers");
                cmd.Connection = Connectionclass.con;
                sda = new SqlDataAdapter(cmd);
                cmb = new SqlCommandBuilder(sda);
                ds = new DataSet();
                sda.Fill(ds, "Supplier");
                dt = ds.Tables["Supplier"];

                data.DataSource = ds.Tables["Supplier"];
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
                //Add Supplier
                this.Hide();
                AddingSupplier display = new AddingSupplier();
                display.ShowDialog();

            }
            if (e.KeyData == Keys.F2)
            {

                //Update 
                string a = txtact.Text;

                if (txtsupname.Text == "" || txtaddress.Text == "" || txttel.Text == "")
                {
                    MessageBox.Show("No such Record to Update", "Error");
                    return;
                }

                if (a.Equals("Y") || a.Equals("N") || a.Equals("y") || a.Equals("n") || a.Equals(""))
                {

                    try
                    {


                        conn.dbcon();
                        cmb = new SqlCommandBuilder(sda);
                        sda.Update(ds, "Supplier");
                        cmd = new SqlCommand("Update Suppliers set Supplier_Name  = '" + txtsupname.Text + "' , Address = '" + txtaddress.Text + "', Telephone_No = '" + txttel.Text + "', Status = '" + txtact.Text + "' where Supplier_ID = '" + txtcustid.Text + "'");
                        cmd.Connection = Connectionclass.con;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated", "Update");
                        //clear
                        txtsupname.Clear();
                        txtaddress.Clear();
                        txttel.Clear();
                        txtact.Clear();
                        txtsupname.ReadOnly = true;
                        txtaddress.ReadOnly = true;
                        txttel.ReadOnly = true;
                        txtcustid.Clear();
                        txtact.ReadOnly = true;




                        //refresh

                        cmd = new SqlCommand("SELECT * FROM Suppliers");
                        cmd.Connection = Connectionclass.con;
                        sda = new SqlDataAdapter(cmd);
                        cmb = new SqlCommandBuilder(sda);
                        ds = new DataSet();
                        sda.Fill(ds, "Supplier");
                        dt = ds.Tables["Supplier"];

                        data.DataSource = ds.Tables["Supplier"];
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
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Main display = new Main();
                display.ShowDialog();
                this.Close();
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.dbcon();
                cmd = new SqlCommand("select * from Suppliers where Supplier_Name like '" + txtsearchsup.Text + "%'");
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

        private void Updates_Click(object sender, EventArgs e)
        {


             string a = txtact.Text;

             if (txtsupname.Text == "" || txtaddress.Text == "" || txttel.Text == "")
             {
                 MessageBox.Show("No such Record to Update", "Error");
                 return;
             }

             if (a.Equals("Y") || a.Equals("N") || a.Equals("y") || a.Equals("n") || a.Equals(""))
             {
                 
                 try
                 {


                     conn.dbcon();
                     cmb = new SqlCommandBuilder(sda);
                     sda.Update(ds, "Supplier");
                     cmd = new SqlCommand("Update Suppliers set Supplier_Name  = '" + txtsupname.Text + "' , Address = '" + txtaddress.Text + "', Telephone_No = '" + txttel.Text + "', Status = '" + txtact.Text + "' where Supplier_ID = '" + txtcustid.Text + "'");
                     cmd.Connection = Connectionclass.con;
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Successfully Updated", "Update");
                     //clear
                     txtsupname.Clear();
                     txtaddress.Clear();
                     txttel.Clear();
                     txtact.Clear();
                     txtsupname.ReadOnly = true;
                     txtaddress.ReadOnly = true;
                     txttel.ReadOnly = true;
                     txtcustid.Clear();
                     txtact.ReadOnly = true;




                     //refresh

                     cmd = new SqlCommand("SELECT * FROM Suppliers");
                     cmd.Connection = Connectionclass.con;
                     sda = new SqlDataAdapter(cmd);
                     cmb = new SqlCommandBuilder(sda);
                     ds = new DataSet();
                     sda.Fill(ds, "Supplier");
                     dt = ds.Tables["Supplier"];

                     data.DataSource = ds.Tables["Supplier"];
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

        private void data_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = data.SelectedRows[0];
            txtcustid.Text = dr.Cells[0].Value.ToString();
            txtsupname.Text = dr.Cells[1].Value.ToString();
            txtaddress.Text = dr.Cells[2].Value.ToString();
            txttel.Text = dr.Cells[3].Value.ToString();
            txtact.Text = dr.Cells[4].Value.ToString();

            txtcustid.ReadOnly = true;
            txtsupname.ReadOnly = false;
            txtaddress.ReadOnly = false;
            txttel.ReadOnly = false;
            txtact.ReadOnly = false;
           
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingSupplier display = new AddingSupplier();
            display.ShowDialog();
        }

        private void txtact_MouseClick(object sender, MouseEventArgs e)
        {
            txtact.Clear();
        }

      

       

        

        
    }
}

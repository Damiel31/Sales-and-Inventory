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
    public partial class UserLogin : Form
    {
        Connectionclass conn = new Connectionclass();
        
        SqlCommand cm = new SqlCommand();
      

        public UserLogin()
        {
            InitializeComponent();


            txtpass.PasswordChar = '*';
            
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (staff.Checked == true)
            {
                conn.dbcon();
                try
                {
                    cm = new SqlCommand("Select username, password from userpass where Username = '" + txtuser.Text + "' and Password = '" + txtpass.Text + "'");
                    cm.Connection = Connectionclass.con;
                    SqlDataReader dr;
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Successfully Log In", "Welcome");
                        this.Hide();
                        Main dis = new Main();
                        dis.Show();

                    }
                    else
                    {
                        MessageBox.Show("Failed to Login. Please Check your Username and Password", "Error");
                        return;
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

            else if (admin.Checked == true)
            {
                conn.dbcon();
                try
                {
                    cm = new SqlCommand("Select username, password from adminpass where Username = '" + txtuser.Text + "' and Password = '" + txtpass.Text + "'");
                    cm.Connection = Connectionclass.con;
                    SqlDataReader dr;
                    dr = cm.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Successfully Log In", "Welcome");
                        this.Hide();
                        Main dis = new Main();
                        dis.Show();

                    }
                    else
                    {
                        MessageBox.Show("Failed to Login. Please Check your Username and Password", "Error");
                        return;
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

            else
            {
                MessageBox.Show("Please Select User Type.","Error");
                return;
            }
            

                
               
        }

       


        private void staff_MouseClick(object sender, MouseEventArgs e)
        {
            admin.Checked = false;
        }

        private void admin_MouseClick(object sender, MouseEventArgs e)
        {
            staff.Checked = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to EXIT ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else 
            {
                return;
            }
           
        }

       

        

        

        
    }
}

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
    public partial class adminpass : Form
    {
        SqlCommand cm = new SqlCommand();
        Connectionclass newcon = new Connectionclass();

        public adminpass()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*'; 
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            try
            {
                newcon.dbcon();
                cm.CommandText = ("Select * from adminpass where Username = '" + txtuser.Text + "' and Password = '" + txtpass.Text + "'");
                cm.Connection = Connectionclass.con;
                SqlDataReader dr;
                dr = cm.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Successfully Log In", "Welcome");
                    this.Hide();
                    Admin display = new Admin();
                    display.ShowDialog();
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
                newcon.Closecon();
            }

        }

       



        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main display = new Main();
            display.ShowDialog();
            this.Close();
        }

        

        

       

    }
}

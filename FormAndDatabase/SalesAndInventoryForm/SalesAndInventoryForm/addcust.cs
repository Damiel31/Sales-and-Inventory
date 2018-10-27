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
    public partial class addcust : Form
    {

        Connectionclass conn = new Connectionclass();


        public addcust()
        {
            InitializeComponent();
        }

        private void addcust_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Main_KeyDown);
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                CustomerInformation display = new CustomerInformation();
                display.ShowDialog();
                this.Close();
            }
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.F1)
            {
                string add = txtaddress.Text;
                string inp = txtname.Text;
                string contact = txtcontact.Text;
                ////TXTNAME CONSTRAINTS 
                bool error = true;

                foreach (char c in inp)
                {
                    if (Char.IsNumber(c))
                    {
                        error = false;
                        break;
                    }
                }
                char ch = ' ';
                for (int a = 0; a < inp.Length; a++)
                {

                    ch = inp[a];

                    if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                    {
                        error = false;
                    }
                }
                ////end of TXTNAME CONSTRAINTS 
                ///
                //// START TXTADDRES CONSTRAINTS 
                for (int a = 0; a < add.Length; a++)
                {
                    ch = add[a];

                    if (ch == '-' || ch == '<' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                    {
                        error = false;
                    }

                }
                ////end of TXTADDRESS CONSTRAINTS 
                ///
                //// START TXTCONTACT CONSTRAINTS
                for (int a = 0; a < contact.Length; a++)
                {
                    ch = contact[a];

                    if (ch == '<' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                    {
                        error = false;
                    }
                    if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                    {
                        error = true;
                    }
                    else
                    {
                        error = false;
                    }

                }
                ////end of TXTCONTACT CONSTRAINTS 

                if (contact.Length > 13)
                {
                    MessageBox.Show("Invalid Contact Number", "Error");
                    return;
                }



                if (error == false)
                {
                    MessageBox.Show("Invalid input! Please Check all Fields for INCORRECT input", "Error");
                    return;
                }

                if (txtname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "")
                {
                    MessageBox.Show("Name, Address and Contact cannot be EMPTY", "Error");
                    return;
                }


                try
                {
                    conn.dbcon();
                    SqlCommand com = new SqlCommand("INSERT INTO Customers (CustomerName, Address, Contact_No) " + "Values ('" + txtname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "' )");
                    com.Connection = Connectionclass.con;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully", "Saving");


                    txtaddress.Clear();
                    txtname.Clear();
                    txtcontact.Clear();

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

        }


        private void add_Click(object sender, EventArgs e)
        {
            string add = txtaddress.Text;
            string inp = txtname.Text;
            string contact = txtcontact.Text;
            ////TXTNAME CONSTRAINTS 
            bool error = true;
           
            foreach (char c in inp)
            {
                if (Char.IsNumber(c))
                {
                    error = false;
                    break;
                }
            }
            char ch = ' ';
            for (int a = 0; a < inp.Length; a++)
            {

                ch = inp[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' ||  ch == '\\' || ch == '\'')
                {
                    error = false;
                }
            }
            ////end of TXTNAME CONSTRAINTS 
            ///
            //// START TXTADDRES CONSTRAINTS 
            for (int a = 0; a < add.Length; a++)
            {
                ch = add[a];

                if (ch == '-' || ch == '<' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error = false;
                }
             
            }
            ////end of TXTADDRESS CONSTRAINTS 
            ///
            //// START TXTCONTACT CONSTRAINTS
            for (int a = 0; a < contact.Length; a++)
            {
                ch = contact[a];

                if (ch == '<' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error = false;
                }
                if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
                {
                    error = true;
                }
                else
                {
                    error = false;
                }

            }
            ////end of TXTCONTACT CONSTRAINTS 

            if (contact.Length > 13)
            {
                MessageBox.Show("Invalid Contact Number","Error");
                return;
            }
         
            

            if (error == false)
            {
                MessageBox.Show("Invalid input! Please Check all Fields for INCORRECT input", "Error");
                return;
            }

            if (txtname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "")
            {
                MessageBox.Show("Name, Address and Contact cannot be EMPTY", "Error");
                return;
            }


            try
            {
                char Yes = 'Y';
                conn.dbcon();
                SqlCommand com = new SqlCommand("INSERT INTO Customers (CustomerName, Address, Contact_No, Status) " + "Values ('" + txtname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "', '"+Yes+"' )");
                com.Connection = Connectionclass.con;
                com.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Saving");


                txtaddress.Clear();
                txtname.Clear();
                txtcontact.Clear();

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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
           CustomerInformation display = new CustomerInformation();
            display.ShowDialog();
            this.Close();      

        }

       

       

       
      
    }
}

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
    public partial class Item : Form
    {

        Connectionclass conn = new Connectionclass();
    

        public Item()
        {
            InitializeComponent();
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders display = new Orders();
            display.ShowDialog();
            this.Close();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error1 = true;
            bool error2 = true;
            bool error3 = true;
            bool error4 = true;
            bool error5 = true;
            string name = txtprodname.Text;
            string unit = txtunitmeas.Text;
            string cost = txtcost.Text;
            string price = txtitemprice.Text;
            string discount = txtdis.Text;

            //Start TXTCustid Constraints
            foreach (char c in name)
            {
                if (Char.IsNumber(c))
                {
                    error1 = false;
                    break;
                }
            }
            char ch = ' ';
            for (int a = 0; a < name.Length; a++)
            {

                ch = name[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error1 = false;
                }
            }

            if (error1 == false)
            {
                MessageBox.Show("Invalid Input Please Check Product Name Field", "Error");
                return;
            }
            ///end of txtCUSTID Constraints
            ///
            ///Start of txtprodcode Constraints
            foreach (char c in unit)
            {
                if (Char.IsNumber(c))
                {
                    error2 = false;
                    break;
                }
            }
            for (int a = 0; a < unit.Length; a++)
            {

                ch = unit[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error2 = false;
                }
            }




            if (error2 == false)
            {
                MessageBox.Show("Invalid Input Please Check Unit Measure Field", "Error");
                return;
            }
            ///end of txtprodcode Constraints
            ///
            ///Start of txtquantity Constraints
            foreach (char c in cost)
            {
                if (!Char.IsNumber(c))
                {
                    error3 = false;
                    break;
                }
            }
            if (error3 == false)
            {
                MessageBox.Show("Invalid Input Please Check Item Cost Field", "Error");
                return;
            }
            ///end of txtquantity Constraints
            ///
            ///Start of txtitemprice Constraints
            foreach (char c in price)
            {
                if (!Char.IsNumber(c))
                {
                    error4 = false;
                    break;
                }
            }
            if (error4 == false)
            {
                MessageBox.Show("Invalid Input Please Check Item Price Field", "Error");
                return;
            }
            ///end of txtitemprice Constraints
            ///
            ///Start of txtdiscount Constraints
            foreach (char c in discount)
            {
                if (!Char.IsNumber(c))
                {
                    error5 = false;
                    break;
                }
            }
            if (error5 == false)
            {
                MessageBox.Show("Invalid Input Please Check Discount Field", "Error");
                return;
            }








            if (txtprodname.Text == "" || txtunitmeas.Text == "" || txtcost.Text == "" || txtdiscrip.Text == "" || txtitemprice.Text == "")
            {
                MessageBox.Show("All fields cannot be empty", "Error");
                return;
            }


            try
            {
                conn.dbcon();

                SqlCommand cm = new SqlCommand("INSERT INTO Products (Product_Name,Unit_Measure, Description, Cost, Price, Discount) " + "Values ('" + txtprodname.Text + "','" + txtunitmeas.Text + "','" + txtdiscrip.Text + "','" + txtcost.Text + "','" + txtitemprice.Text + "', '" + txtdis.Text + "' )");
                cm.Connection = Connectionclass.con;
                cm.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Saving");

                txtprodname.Clear();
                txtdiscrip.Clear();
                txtunitmeas.Clear();
                txtcost.Clear();
                txtitemprice.Clear();
                txtdis.Clear();


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

        private void Item_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //back
            if (e.KeyData == Keys.Escape)
            {
                this.Hide();
                Orders display = new Orders();
                display.ShowDialog();
                this.Close();
            }
            ///add product
            if (e.KeyData == Keys.F1)
            {
                bool error1 = true;
            bool error2 = true;
            bool error3 = true;
            bool error4 = true;
            bool error5 = true;
            string name = txtprodname.Text;
            string unit = txtunitmeas.Text;
            string cost = txtcost.Text;
            string price = txtitemprice.Text;
            string discount = txtdis.Text;

            //Start TXTCustid Constraints
            foreach (char c in name)
            {
                if (Char.IsNumber(c))
                {
                    error1 = false;
                    break;
                }
            }
            char ch = ' ';
            for (int a = 0; a < name.Length; a++)
            {

                ch = name[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error1 = false;
                }
            }

            if (error1 == false)
            {
                MessageBox.Show("1", "Error");
                return;
            }
            ///end of txtCUSTID Constraints
            ///
            ///Start of txtprodcode Constraints
            foreach (char c in unit)
            {
                if (Char.IsNumber(c))
                {
                    error2 = false;
                    break;
                }
            }
            for (int a = 0; a < unit.Length; a++)
            {

                ch = unit[a];

                if (ch == ',' || ch == '<' || ch == '.' || ch == '>' || ch == '?' || ch == '/' || ch == ';' || ch == ':' || ch == '"' || ch == '|' || ch == ']' || ch == '}' || ch == '[' || ch == '{' || ch == '+' || ch == '=' || ch == '-' || ch == '_' || ch == ')' || ch == '(' || ch == '*' || ch == '&' || ch == '^' || ch == '%' || ch == '$' || ch == '#' || ch == '@' || ch == '!' || ch == '`' || ch == '~' || ch == '\\' || ch == '\'')
                {
                    error2 = false;
                }
            }




            if (error2 == false)
            {
                MessageBox.Show("2", "Error");
                return;
            }
            ///end of txtprodcode Constraints
            ///
            ///Start of txtquantity Constraints
            foreach (char c in cost)
            {
                if (!Char.IsNumber(c))
                {
                    error3 = false;
                    break;
                }
            }
            if (error3 == false)
            {
                MessageBox.Show("3", "Error");
                return;
            }
            ///end of txtquantity Constraints
            ///
            ///Start of txtitemprice Constraints
            foreach (char c in price)
            {
                if (!Char.IsNumber(c))
                {
                    error4 = false;
                    break;
                }
            }
            if (error4 == false)
            {
                MessageBox.Show("4", "Error");
                return;
            }
            ///end of txtitemprice Constraints
            ///
            ///Start of txtdiscount Constraints
            foreach (char c in discount)
            {
                if (!Char.IsNumber(c))
                {
                    error5 = false;
                    break;
                }
            }
            if (error5 == false)
            {
                MessageBox.Show("5", "Error");
                return;
            }








            if (txtprodname.Text == "" || txtunitmeas.Text == "" || txtcost.Text == "" || txtdiscrip.Text == "" || txtitemprice.Text == "")
            {
                MessageBox.Show("All fields cannot be empty", "Error");
                return;
            }


            try
            {
                conn.dbcon();

                SqlCommand cm = new SqlCommand("INSERT INTO Products (Product_Name,Unit_Measure, Description, Cost, Price, Discount) " + "Values ('" + txtprodname.Text + "','" + txtunitmeas.Text + "','" + txtdiscrip.Text + "','" + txtcost.Text + "','" + txtitemprice.Text + "', '" + txtdis.Text + "' )");
                cm.Connection = Connectionclass.con;
                cm.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully", "Saving");

                txtprodname.Clear();
                txtdiscrip.Clear();
                txtunitmeas.Clear();
                txtcost.Clear();
                txtitemprice.Clear();
                txtdis.Clear();


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

        
      
    }
}

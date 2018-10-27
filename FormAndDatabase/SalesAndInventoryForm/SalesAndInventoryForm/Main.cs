using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        public string TextBoxValue
        {
            get { return label8.Text; }
            set { label8.Text = value; }
        }            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInformation display = new CustomerInformation();
            display.ShowDialog();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log Out ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales display = new Sales();
            display.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier display = new Supplier();
            display.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders display = new Orders();
            display.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockCard display = new StockCard();
            display.ShowDialog();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
           InventorySummary display = new InventorySummary();
            display.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpass display = new adminpass();
            display.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports display = new Reports();
            display.ShowDialog();
        }

      

      

        
    }
}

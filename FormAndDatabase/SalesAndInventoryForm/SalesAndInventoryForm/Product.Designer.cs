namespace WindowsFormsApplication1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnclear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.txtprodid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datachange = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclears = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdates = new System.Windows.Forms.Button();
            this.txtstaff = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtstaffname = new System.Windows.Forms.TextBox();
            this.txtstaffid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataaccess = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachange)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaccess)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back -->>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(22, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 512);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.Controls.Add(this.btnclear);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnupdate);
            this.tabPage2.Controls.Add(this.txtcost);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtdiscount);
            this.tabPage2.Controls.Add(this.txtprice);
            this.tabPage2.Controls.Add(this.txtprodname);
            this.tabPage2.Controls.Add(this.txtprodid);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtsearch);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.datachange);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Product Information";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(128, 300);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 92;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 91;
            this.label8.Text = "Products Information";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(128, 259);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 89;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(103, 116);
            this.txtcost.Name = "txtcost";
            this.txtcost.ReadOnly = true;
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(61, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Cost:";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(103, 174);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount.TabIndex = 86;
            this.txtdiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdiscount_MouseClick);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(103, 145);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 85;
            this.txtprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtprice_MouseClick);
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(103, 88);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.ReadOnly = true;
            this.txtprodname.Size = new System.Drawing.Size(100, 20);
            this.txtprodname.TabIndex = 84;
            // 
            // txtprodid
            // 
            this.txtprodid.Location = new System.Drawing.Point(103, 58);
            this.txtprodid.Name = "txtprodid";
            this.txtprodid.ReadOnly = true;
            this.txtprodid.Size = new System.Drawing.Size(100, 20);
            this.txtprodid.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(43, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Discount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(60, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(36, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Product ID:";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(363, 37);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 78;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(249, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Search by Product ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products Table";
            // 
            // datachange
            // 
            this.datachange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datachange.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datachange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datachange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datachange.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datachange.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datachange.Location = new System.Drawing.Point(252, 61);
            this.datachange.Name = "datachange";
            this.datachange.Size = new System.Drawing.Size(421, 404);
            this.datachange.TabIndex = 0;
            this.datachange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.data_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 196);
            this.panel1.TabIndex = 90;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Controls.Add(this.btndel);
            this.tabPage1.Controls.Add(this.btnclears);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.btnupdates);
            this.tabPage1.Controls.Add(this.txtstaff);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtpass);
            this.tabPage1.Controls.Add(this.txtuser);
            this.tabPage1.Controls.Add(this.txtstaffname);
            this.tabPage1.Controls.Add(this.txtstaffid);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dataaccess);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 486);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Add Staff Security Access";
            // 
            // btndel
            // 
            this.btndel.Enabled = false;
            this.btndel.Location = new System.Drawing.Point(204, 283);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 84;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnclears
            // 
            this.btnclears.Location = new System.Drawing.Point(167, 324);
            this.btnclears.Name = "btnclears";
            this.btnclears.Size = new System.Drawing.Size(75, 23);
            this.btnclears.TabIndex = 83;
            this.btnclears.Text = "Clear";
            this.btnclears.UseVisualStyleBackColor = true;
            this.btnclears.Click += new System.EventHandler(this.btnclears_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(23, 283);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 82;
            this.btnadd.Text = "Add Staff";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdates
            // 
            this.btnupdates.Enabled = false;
            this.btnupdates.Location = new System.Drawing.Point(113, 283);
            this.btnupdates.Name = "btnupdates";
            this.btnupdates.Size = new System.Drawing.Size(75, 23);
            this.btnupdates.TabIndex = 81;
            this.btnupdates.Text = "Update";
            this.btnupdates.UseVisualStyleBackColor = true;
            this.btnupdates.Click += new System.EventHandler(this.btnupdates_Click);
            // 
            // txtstaff
            // 
            this.txtstaff.Location = new System.Drawing.Point(378, 53);
            this.txtstaff.Name = "txtstaff";
            this.txtstaff.Size = new System.Drawing.Size(100, 20);
            this.txtstaff.TabIndex = 80;
            this.txtstaff.TextChanged += new System.EventHandler(this.txtstaff_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(275, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Search by Staff ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(29, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Staff Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(274, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Staff Security Access Table";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(104, 163);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(104, 135);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 7;
            // 
            // txtstaffname
            // 
            this.txtstaffname.Location = new System.Drawing.Point(104, 106);
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.Size = new System.Drawing.Size(100, 20);
            this.txtstaffname.TabIndex = 6;
            // 
            // txtstaffid
            // 
            this.txtstaffid.Location = new System.Drawing.Point(104, 77);
            this.txtstaffid.Name = "txtstaffid";
            this.txtstaffid.ReadOnly = true;
            this.txtstaffid.Size = new System.Drawing.Size(100, 20);
            this.txtstaffid.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(40, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(39, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Username:";
            // 
            // dataaccess
            // 
            this.dataaccess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataaccess.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataaccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataaccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataaccess.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataaccess.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataaccess.Location = new System.Drawing.Point(278, 77);
            this.dataaccess.Name = "dataaccess";
            this.dataaccess.Size = new System.Drawing.Size(351, 186);
            this.dataaccess.TabIndex = 2;
            this.dataaccess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataaccess_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(35, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Staff Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(51, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Staff ID:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(23, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 194);
            this.panel2.TabIndex = 11;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(751, 650);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datachange)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datachange;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.TextBox txtprodid;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtstaffname;
        private System.Windows.Forms.TextBox txtstaffid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataaccess;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtstaff;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdates;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclears;
        private System.Windows.Forms.Button btndel;
    }
}
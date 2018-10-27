namespace WindowsFormsApplication1
{
    partial class addsales
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
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtinfocustname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinfoprod = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtleftitem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprodcode = new System.Windows.Forms.ComboBox();
            this.txtcustid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtsalesdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(169, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 15);
            this.label13.TabIndex = 141;
            this.label13.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(54, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 29);
            this.label11.TabIndex = 140;
            this.label11.Text = "Add Sales";
            // 
            // txtinfocustname
            // 
            this.txtinfocustname.Location = new System.Drawing.Point(203, 117);
            this.txtinfocustname.Name = "txtinfocustname";
            this.txtinfocustname.ReadOnly = true;
            this.txtinfocustname.Size = new System.Drawing.Size(142, 20);
            this.txtinfocustname.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(150, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "DESCRIPTION";
            // 
            // txtinfoprod
            // 
            this.txtinfoprod.Location = new System.Drawing.Point(145, 184);
            this.txtinfoprod.Multiline = true;
            this.txtinfoprod.Name = "txtinfoprod";
            this.txtinfoprod.ReadOnly = true;
            this.txtinfoprod.Size = new System.Drawing.Size(95, 75);
            this.txtinfoprod.TabIndex = 137;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(145, 273);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(24, 20);
            this.txtdiscount.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(79, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 136;
            this.label9.Text = "Discount:";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(145, 298);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 126;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtleftitem
            // 
            this.txtleftitem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtleftitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtleftitem.Font = new System.Drawing.Font("Mistress Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleftitem.Location = new System.Drawing.Point(277, 195);
            this.txtleftitem.Multiline = true;
            this.txtleftitem.Name = "txtleftitem";
            this.txtleftitem.ReadOnly = true;
            this.txtleftitem.Size = new System.Drawing.Size(68, 64);
            this.txtleftitem.TabIndex = 135;
            this.txtleftitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(245, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 134;
            this.label8.Text = "TOTAL PRODUCT LEFT";
            // 
            // txtprodcode
            // 
            this.txtprodcode.FormattingEnabled = true;
            this.txtprodcode.Location = new System.Drawing.Point(145, 144);
            this.txtprodcode.Name = "txtprodcode";
            this.txtprodcode.Size = new System.Drawing.Size(52, 21);
            this.txtprodcode.TabIndex = 124;
            this.txtprodcode.SelectedIndexChanged += new System.EventHandler(this.txtprodcode_SelectedIndexChanged);
            this.txtprodcode.TextChanged += new System.EventHandler(this.txtprodcode_TextChanged);
            // 
            // txtcustid
            // 
            this.txtcustid.FormattingEnabled = true;
            this.txtcustid.Location = new System.Drawing.Point(145, 117);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(52, 21);
            this.txtcustid.TabIndex = 123;
            this.txtcustid.SelectedIndexChanged += new System.EventHandler(this.txtcustid_SelectedIndexChanged);
            this.txtcustid.TextChanged += new System.EventHandler(this.txtcustid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(63, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Customer ID:";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(145, 324);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 127;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(94, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 132;
            this.label7.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(82, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(97, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "Price:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(145, 356);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 131;
            this.txtTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(56, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "Product Code:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtprodname);
            this.panel1.Location = new System.Drawing.Point(44, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 341);
            this.panel1.TabIndex = 142;
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(158, 80);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.ReadOnly = true;
            this.txtprodname.Size = new System.Drawing.Size(142, 20);
            this.txtprodname.TabIndex = 155;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(433, 413);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(61, 47);
            this.btnadd.TabIndex = 143;
            this.btnadd.Text = "Save";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(675, 472);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 144;
            this.btnback.Text = "-->> Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtsalesdate
            // 
            this.txtsalesdate.Location = new System.Drawing.Point(701, 26);
            this.txtsalesdate.Name = "txtsalesdate";
            this.txtsalesdate.ReadOnly = true;
            this.txtsalesdate.Size = new System.Drawing.Size(59, 20);
            this.txtsalesdate.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(662, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(67, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 13);
            this.label14.TabIndex = 149;
            this.label14.Text = "|";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(2, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 148;
            this.label15.Text = "F1 Add to list";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(76, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 147;
            this.label17.Text = "F2 Save";
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data.Location = new System.Drawing.Point(433, 109);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(327, 296);
            this.data.TabIndex = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(428, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 29);
            this.label10.TabIndex = 151;
            this.label10.Text = "Added Product List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 154;
            this.button1.Text = "Add to List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(122, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(9, 13);
            this.label12.TabIndex = 156;
            this.label12.Text = "|";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(131, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 155;
            this.label16.Text = "ESC Back";
            // 
            // addsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(783, 507);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtsalesdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtinfocustname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinfoprod);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtleftitem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprodcode);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.addsales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtinfocustname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinfoprod;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtleftitem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtprodcode;
        private System.Windows.Forms.ComboBox txtcustid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtsalesdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
    }
}
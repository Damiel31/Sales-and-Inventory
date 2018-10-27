namespace WindowsFormsApplication1
{
    partial class Sales
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
            this.btnback = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.f1AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f5RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtsalesdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinfocustname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinfoprod = new System.Windows.Forms.TextBox();
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
            this.btnaddsale = new System.Windows.Forms.Button();
            this.txtsaleno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(833, 450);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back --->";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.Location = new System.Drawing.Point(416, 62);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(491, 356);
            this.data.TabIndex = 68;
            this.data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.data_MouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(184, 398);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(51, 39);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // f1AddCustomerToolStripMenuItem
            // 
            this.f1AddCustomerToolStripMenuItem.Enabled = false;
            this.f1AddCustomerToolStripMenuItem.Name = "f1AddCustomerToolStripMenuItem";
            this.f1AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.f1AddCustomerToolStripMenuItem.Text = "F1 Add Customer";
            // 
            // f2ToolStripMenuItem
            // 
            this.f2ToolStripMenuItem.Enabled = false;
            this.f2ToolStripMenuItem.Name = "f2ToolStripMenuItem";
            this.f2ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.f2ToolStripMenuItem.Text = "F2 Save";
            // 
            // f5RefreshToolStripMenuItem
            // 
            this.f5RefreshToolStripMenuItem.Enabled = false;
            this.f5RefreshToolStripMenuItem.Name = "f5RefreshToolStripMenuItem";
            this.f5RefreshToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.f5RefreshToolStripMenuItem.Text = "ESC Back";
            // 
            // txtsalesdate
            // 
            this.txtsalesdate.Location = new System.Drawing.Point(849, 32);
            this.txtsalesdate.Name = "txtsalesdate";
            this.txtsalesdate.ReadOnly = true;
            this.txtsalesdate.Size = new System.Drawing.Size(59, 20);
            this.txtsalesdate.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(810, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Date:";
            // 
            // txtinfocustname
            // 
            this.txtinfocustname.Location = new System.Drawing.Point(173, 89);
            this.txtinfocustname.Name = "txtinfocustname";
            this.txtinfocustname.ReadOnly = true;
            this.txtinfocustname.Size = new System.Drawing.Size(142, 20);
            this.txtinfocustname.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "DESCRIPTION";
            // 
            // txtinfoprod
            // 
            this.txtinfoprod.Location = new System.Drawing.Point(115, 156);
            this.txtinfoprod.Multiline = true;
            this.txtinfoprod.Name = "txtinfoprod";
            this.txtinfoprod.ReadOnly = true;
            this.txtinfoprod.Size = new System.Drawing.Size(95, 75);
            this.txtinfoprod.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(49, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 106;
            this.label9.Text = "Discount:";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(115, 270);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 4;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtleftitem
            // 
            this.txtleftitem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtleftitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtleftitem.Font = new System.Drawing.Font("Mistress Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleftitem.Location = new System.Drawing.Point(247, 167);
            this.txtleftitem.Multiline = true;
            this.txtleftitem.Name = "txtleftitem";
            this.txtleftitem.ReadOnly = true;
            this.txtleftitem.Size = new System.Drawing.Size(68, 64);
            this.txtleftitem.TabIndex = 105;
            this.txtleftitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(215, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "TOTAL PRODUCT LEFT";
            // 
            // txtprodcode
            // 
            this.txtprodcode.Enabled = false;
            this.txtprodcode.FormattingEnabled = true;
            this.txtprodcode.Location = new System.Drawing.Point(115, 116);
            this.txtprodcode.Name = "txtprodcode";
            this.txtprodcode.Size = new System.Drawing.Size(100, 21);
            this.txtprodcode.TabIndex = 2;
            this.txtprodcode.SelectedIndexChanged += new System.EventHandler(this.txtprodcode_SelectedIndexChanged_1);
            this.txtprodcode.TextChanged += new System.EventHandler(this.txtprodcode_TextChanged);
            // 
            // txtcustid
            // 
            this.txtcustid.Enabled = false;
            this.txtcustid.FormattingEnabled = true;
            this.txtcustid.Location = new System.Drawing.Point(115, 89);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(52, 21);
            this.txtcustid.TabIndex = 1;
            this.txtcustid.SelectedIndexChanged += new System.EventHandler(this.txtcustid_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Customer ID:";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(115, 296);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.ReadOnly = true;
            this.txtquantity.Size = new System.Drawing.Size(100, 20);
            this.txtquantity.TabIndex = 5;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(64, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(52, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(67, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Price:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(115, 328);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 99;
            this.txtTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Product Code:";
            // 
            // btnaddsale
            // 
            this.btnaddsale.Location = new System.Drawing.Point(117, 398);
            this.btnaddsale.Name = "btnaddsale";
            this.btnaddsale.Size = new System.Drawing.Size(52, 39);
            this.btnaddsale.TabIndex = 6;
            this.btnaddsale.Text = "Add Sales";
            this.btnaddsale.UseVisualStyleBackColor = true;
            this.btnaddsale.Click += new System.EventHandler(this.btnaddsale_Click);
            // 
            // txtsaleno
            // 
            this.txtsaleno.Location = new System.Drawing.Point(442, 167);
            this.txtsaleno.Name = "txtsaleno";
            this.txtsaleno.Size = new System.Drawing.Size(68, 20);
            this.txtsaleno.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(418, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 16);
            this.label10.TabIndex = 116;
            this.label10.Text = "To edit an existing sales record. Just click the table.";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(115, 245);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(24, 20);
            this.txtdiscount.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(24, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 29);
            this.label11.TabIndex = 117;
            this.label11.Text = "Add Sales";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(412, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 29);
            this.label12.TabIndex = 118;
            this.label12.Text = "Sales Table";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(139, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 15);
            this.label13.TabIndex = 120;
            this.label13.Text = "%";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(249, 398);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(51, 39);
            this.btnclear.TabIndex = 121;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 341);
            this.panel1.TabIndex = 122;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(70, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 13);
            this.label14.TabIndex = 126;
            this.label14.Text = "|";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(176, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 125;
            this.label15.Text = "ESC Back";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(77, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 124;
            this.label16.Text = "F2 Update Record";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(2, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 123;
            this.label17.Text = "F1 Add Sales";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(169, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(9, 13);
            this.label18.TabIndex = 127;
            this.label18.Text = "|";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(886, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 128;
            this.label19.Text = "(%)";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(920, 485);
            this.ControlBox = false;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnaddsale);
            this.Controls.Add(this.txtsalesdate);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtsaleno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ToolStripMenuItem f1AddCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f5RefreshToolStripMenuItem;
        private System.Windows.Forms.TextBox txtsalesdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinfocustname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinfoprod;
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
        private System.Windows.Forms.Button btnaddsale;
        private System.Windows.Forms.TextBox txtsaleno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}
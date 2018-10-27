namespace WindowsFormsApplication1
{
    partial class Reports
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
            this.label3 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtexpenses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdatemonth = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.salesreport = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesreport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sales";
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagrid.Location = new System.Drawing.Point(13, 60);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(722, 455);
            this.datagrid.TabIndex = 11;
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(93, 530);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.ReadOnly = true;
            this.txtgrandtotal.Size = new System.Drawing.Size(100, 20);
            this.txtgrandtotal.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(11, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "TOTAL SALES:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 612);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.datagrid);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtgrandtotal);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(579, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "(%)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.Controls.Add(this.txtexpenses);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.data);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Purchased Order";
            // 
            // txtexpenses
            // 
            this.txtexpenses.Location = new System.Drawing.Point(155, 549);
            this.txtexpenses.Name = "txtexpenses";
            this.txtexpenses.Size = new System.Drawing.Size(100, 20);
            this.txtexpenses.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "TOTAL EXPENSES:";
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data.Location = new System.Drawing.Point(48, 55);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(658, 479);
            this.data.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Purchased Order";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtyear);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtdatemonth);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtdate);
            this.tabPage3.Controls.Add(this.txttotal);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.salesreport);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(750, 586);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sales Record Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(401, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Yearly Sales Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(264, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Monthly Sales Record";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(137, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Daily Sales Record";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(439, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Year";
            // 
            // txtyear
            // 
            this.txtyear.FormattingEnabled = true;
            this.txtyear.Location = new System.Drawing.Point(406, 35);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(94, 21);
            this.txtyear.TabIndex = 16;
            this.txtyear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtyear_MouseClick);
            this.txtyear.SelectedIndexChanged += new System.EventHandler(this.txtyear_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(284, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Month - Year";
            // 
            // txtdatemonth
            // 
            this.txtdatemonth.FormattingEnabled = true;
            this.txtdatemonth.Location = new System.Drawing.Point(272, 35);
            this.txtdatemonth.Name = "txtdatemonth";
            this.txtdatemonth.Size = new System.Drawing.Size(94, 21);
            this.txtdatemonth.TabIndex = 14;
            this.txtdatemonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdatemonth_MouseClick);
            this.txtdatemonth.SelectedIndexChanged += new System.EventHandler(this.txtdatemonth_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(136, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Month - Day - Year";
            // 
            // txtdate
            // 
            this.txtdate.FormattingEnabled = true;
            this.txtdate.Location = new System.Drawing.Point(138, 35);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(94, 21);
            this.txtdate.TabIndex = 10;
            this.txtdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdate_MouseClick);
            this.txtdate.SelectedIndexChanged += new System.EventHandler(this.txtdate_SelectedIndexChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(117, 531);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(66, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "TOTAL:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(69, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sales Date:";
            // 
            // salesreport
            // 
            this.salesreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.salesreport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesreport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesreport.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salesreport.Location = new System.Drawing.Point(67, 93);
            this.salesreport.Name = "salesreport";
            this.salesreport.Size = new System.Drawing.Size(628, 427);
            this.salesreport.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(664, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date: ";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(706, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(60, 20);
            this.date.TabIndex = 15;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(695, 669);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "-->> Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(791, 705);
            this.ControlBox = false;
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtexpenses;
        private System.Windows.Forms.Label label2;
      
    
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView salesreport;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txtdatemonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtyear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}
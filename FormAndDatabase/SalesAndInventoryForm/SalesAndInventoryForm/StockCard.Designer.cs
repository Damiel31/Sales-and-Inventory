namespace WindowsFormsApplication1
{
    partial class StockCard
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
            this.l1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.txtunitmeas = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.comboprodID = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l1.Location = new System.Drawing.Point(36, 57);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(75, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "Product Code:";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(449, 573);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back -->";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.data.Location = new System.Drawing.Point(35, 137);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 20;
            this.data.Size = new System.Drawing.Size(497, 408);
            this.data.TabIndex = 10;
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(119, 82);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.ReadOnly = true;
            this.txtprodname.Size = new System.Drawing.Size(127, 20);
            this.txtprodname.TabIndex = 12;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l2.Location = new System.Drawing.Point(32, 85);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(81, 13);
            this.l2.TabIndex = 11;
            this.l2.Text = "Product Name: ";
            // 
            // txtunitmeas
            // 
            this.txtunitmeas.Location = new System.Drawing.Point(120, 110);
            this.txtunitmeas.Name = "txtunitmeas";
            this.txtunitmeas.ReadOnly = true;
            this.txtunitmeas.Size = new System.Drawing.Size(126, 20);
            this.txtunitmeas.TabIndex = 14;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l3.Location = new System.Drawing.Point(38, 113);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(73, 13);
            this.l3.TabIndex = 13;
            this.l3.Text = "Unit Measure:";
            // 
            // comboprodID
            // 
            this.comboprodID.FormattingEnabled = true;
            this.comboprodID.Location = new System.Drawing.Point(119, 54);
            this.comboprodID.Name = "comboprodID";
            this.comboprodID.Size = new System.Drawing.Size(53, 21);
            this.comboprodID.TabIndex = 1;
            this.comboprodID.SelectedIndexChanged += new System.EventHandler(this.comboprodID_SelectedIndexChanged);
            this.comboprodID.TextChanged += new System.EventHandler(this.comboprodID_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "ESC Back";
            // 
            // StockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(568, 609);
            this.ControlBox = false;
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboprodID);
            this.Controls.Add(this.txtunitmeas);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.txtprodname);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.l1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StockCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox txtunitmeas;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.ComboBox comboprodID;
        private System.Windows.Forms.Label label21;
    }
}
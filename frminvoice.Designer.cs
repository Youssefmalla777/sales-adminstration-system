namespace invoice_programm
{
    partial class frminvoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinvoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmount = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnedit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::invoice_programm.Properties.Resources.pexels_life_of_pix_7974;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Name = "label2";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtinvoice
            // 
            resources.ApplyResources(this.txtinvoice, "txtinvoice");
            this.txtinvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txtinvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtinvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtinvoice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtinvoice.Name = "txtinvoice";
            this.toolTip1.SetToolTip(this.txtinvoice, resources.GetString("txtinvoice.ToolTip"));
            this.txtinvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Name = "label3";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txtdate
            // 
            resources.ApplyResources(this.txtdate, "txtdate");
            this.txtdate.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txtdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdate.Name = "txtdate";
            this.txtdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdate_KeyPress);
            this.txtdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtdate_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Name = "label4";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // txtname
            // 
            resources.ApplyResources(this.txtname, "txtname");
            this.txtname.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtname.Name = "txtname";
            this.toolTip1.SetToolTip(this.txtname, resources.GetString("txtname.ToolTip"));
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            this.txtname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtname_MouseDown);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cbxtype
            // 
            this.cbxtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxtype.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.cbxtype, "cbxtype");
            this.cbxtype.FormattingEnabled = true;
            this.cbxtype.Name = "cbxtype";
            this.toolTip1.SetToolTip(this.cbxtype, resources.GetString("cbxtype.ToolTip"));
            this.cbxtype.SelectedIndexChanged += new System.EventHandler(this.cbxtype_SelectedIndexChanged);
            this.cbxtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxtype_KeyDown);
            this.cbxtype.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbxtype_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Name = "label6";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            resources.ApplyResources(this.label7, "label7");
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Name = "label7";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // txtprice
            // 
            resources.ApplyResources(this.txtprice, "txtprice");
            this.txtprice.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txtprice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtprice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtprice.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.toolTip1.SetToolTip(this.txtprice, resources.GetString("txtprice.ToolTip"));
            this.txtprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyDown);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            this.txtprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            resources.ApplyResources(this.label8, "label8");
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Name = "label8";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // txtmount
            // 
            resources.ApplyResources(this.txtmount, "txtmount");
            this.txtmount.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txtmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtmount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmount.Name = "txtmount";
            this.toolTip1.SetToolTip(this.txtmount, resources.GetString("txtmount.ToolTip"));
            this.txtmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmount_KeyDown);
            this.txtmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmount_KeyPress);
            this.txtmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmount_KeyUp);
            // 
            // txttotal
            // 
            resources.ApplyResources(this.txttotal, "txttotal");
            this.txttotal.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txttotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txttotal.BackColor = System.Drawing.Color.DarkGray;
            this.txttotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txttotal.Name = "txttotal";
            this.txttotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttotal_KeyDown);
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            this.txttotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttotal_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            resources.ApplyResources(this.label9, "label9");
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Name = "label9";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.btnprint, "btnprint");
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.Name = "btnprint";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice,
            this.name,
            this.type,
            this.mount,
            this.price,
            this.total});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView1_CellStateChanged);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // invoice
            // 
            resources.ApplyResources(this.invoice, "invoice");
            this.invoice.Name = "invoice";
            this.invoice.ReadOnly = true;
            this.invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            resources.ApplyResources(this.type, "type");
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // mount
            // 
            resources.ApplyResources(this.mount, "mount");
            this.mount.Name = "mount";
            this.mount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // total
            // 
            resources.ApplyResources(this.total, "total");
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "info";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.btnedit, "btnedit");
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Name = "btnedit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frminvoice
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frminvoice";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frminvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtmount;
        protected System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn mount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}


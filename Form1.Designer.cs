namespace SalesApp2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PeoplecomboBox1 = new System.Windows.Forms.ComboBox();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegioncomboBox1 = new System.Windows.Forms.ComboBox();
            this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshSalessabutton1 = new System.Windows.Forms.Button();
            this.SalesdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTaregetbutton1 = new System.Windows.Forms.Button();
            this.newAmountnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.newDatedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.newPersoncomboBox1 = new System.Windows.Forms.ComboBox();
            this.newRegioncomboBox2 = new System.Windows.Forms.ComboBox();
            this.newSalebutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PeoplecomboBox1
            // 
            this.PeoplecomboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeoplecomboBox1.DataSource = this.salesPersonBindingSource;
            this.PeoplecomboBox1.DisplayMember = "FullName";
            this.PeoplecomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeoplecomboBox1.FormattingEnabled = true;
            this.PeoplecomboBox1.Location = new System.Drawing.Point(144, 68);
            this.PeoplecomboBox1.Name = "PeoplecomboBox1";
            this.PeoplecomboBox1.Size = new System.Drawing.Size(292, 28);
            this.PeoplecomboBox1.TabIndex = 0;
            this.PeoplecomboBox1.ValueMember = "Id";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataSource = typeof(SalesApp2.Models.SalesPerson);
            // 
            // RegioncomboBox1
            // 
            this.RegioncomboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegioncomboBox1.DataSource = this.salesRegionBindingSource;
            this.RegioncomboBox1.DisplayMember = "Name";
            this.RegioncomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegioncomboBox1.FormattingEnabled = true;
            this.RegioncomboBox1.Location = new System.Drawing.Point(17, 68);
            this.RegioncomboBox1.Name = "RegioncomboBox1";
            this.RegioncomboBox1.Size = new System.Drawing.Size(121, 28);
            this.RegioncomboBox1.TabIndex = 1;
            this.RegioncomboBox1.ValueMember = "Id";
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(SalesApp2.Models.SalesRegion);
            // 
            // refreshSalessabutton1
            // 
            this.refreshSalessabutton1.Location = new System.Drawing.Point(344, 12);
            this.refreshSalessabutton1.Name = "refreshSalessabutton1";
            this.refreshSalessabutton1.Size = new System.Drawing.Size(92, 36);
            this.refreshSalessabutton1.TabIndex = 2;
            this.refreshSalessabutton1.Text = "Refresh";
            this.refreshSalessabutton1.UseVisualStyleBackColor = true;
            this.refreshSalessabutton1.Click += new System.EventHandler(this.refreshSalessabutton1_Click);
            // 
            // SalesdataGridView1
            // 
            this.SalesdataGridView1.AllowUserToAddRows = false;
            this.SalesdataGridView1.AutoGenerateColumns = false;
            this.SalesdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
            this.SalesdataGridView1.DataSource = this.saleBindingSource;
            this.SalesdataGridView1.Location = new System.Drawing.Point(24, 102);
            this.SalesdataGridView1.Name = "SalesdataGridView1";
            this.SalesdataGridView1.RowTemplate.Height = 28;
            this.SalesdataGridView1.Size = new System.Drawing.Size(419, 278);
            this.SalesdataGridView1.TabIndex = 3;
            this.SalesdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesdataGridView1_CellContentClick);
            this.SalesdataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesdataGridView1_CellEndEdit);
            this.SalesdataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.SalesdataGridView1_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Updated By";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(SalesApp2.Models.Sale);
            // 
            // salesTaregetbutton1
            // 
            this.salesTaregetbutton1.Location = new System.Drawing.Point(17, 12);
            this.salesTaregetbutton1.Name = "salesTaregetbutton1";
            this.salesTaregetbutton1.Size = new System.Drawing.Size(99, 36);
            this.salesTaregetbutton1.TabIndex = 4;
            this.salesTaregetbutton1.Text = "Target";
            this.salesTaregetbutton1.UseVisualStyleBackColor = true;
            this.salesTaregetbutton1.Click += new System.EventHandler(this.salesTaregetbutton1_Click);
            // 
            // newAmountnumericUpDown1
            // 
            this.newAmountnumericUpDown1.DecimalPlaces = 2;
            this.newAmountnumericUpDown1.Location = new System.Drawing.Point(24, 453);
            this.newAmountnumericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newAmountnumericUpDown1.Name = "newAmountnumericUpDown1";
            this.newAmountnumericUpDown1.Size = new System.Drawing.Size(214, 26);
            this.newAmountnumericUpDown1.TabIndex = 5;
            // 
            // newDatedateTimePicker1
            // 
            this.newDatedateTimePicker1.Location = new System.Drawing.Point(24, 396);
            this.newDatedateTimePicker1.Name = "newDatedateTimePicker1";
            this.newDatedateTimePicker1.Size = new System.Drawing.Size(285, 26);
            this.newDatedateTimePicker1.TabIndex = 6;
            // 
            // newPersoncomboBox1
            // 
            this.newPersoncomboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPersoncomboBox1.DataSource = this.salesPersonBindingSource;
            this.newPersoncomboBox1.DisplayMember = "FullName";
            this.newPersoncomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPersoncomboBox1.FormattingEnabled = true;
            this.newPersoncomboBox1.Location = new System.Drawing.Point(24, 504);
            this.newPersoncomboBox1.Name = "newPersoncomboBox1";
            this.newPersoncomboBox1.Size = new System.Drawing.Size(214, 28);
            this.newPersoncomboBox1.TabIndex = 7;
            this.newPersoncomboBox1.ValueMember = "Id";
            // 
            // newRegioncomboBox2
            // 
            this.newRegioncomboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newRegioncomboBox2.DataSource = this.salesRegionBindingSource;
            this.newRegioncomboBox2.DisplayMember = "Name";
            this.newRegioncomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRegioncomboBox2.FormattingEnabled = true;
            this.newRegioncomboBox2.Location = new System.Drawing.Point(24, 567);
            this.newRegioncomboBox2.Name = "newRegioncomboBox2";
            this.newRegioncomboBox2.Size = new System.Drawing.Size(214, 28);
            this.newRegioncomboBox2.TabIndex = 8;
            this.newRegioncomboBox2.ValueMember = "Id";
            // 
            // newSalebutton1
            // 
            this.newSalebutton1.Location = new System.Drawing.Point(273, 567);
            this.newSalebutton1.Name = "newSalebutton1";
            this.newSalebutton1.Size = new System.Drawing.Size(118, 34);
            this.newSalebutton1.TabIndex = 9;
            this.newSalebutton1.Text = "New Sale";
            this.newSalebutton1.UseVisualStyleBackColor = true;
            this.newSalebutton1.Click += new System.EventHandler(this.newSalebutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 631);
            this.Controls.Add(this.newSalebutton1);
            this.Controls.Add(this.newRegioncomboBox2);
            this.Controls.Add(this.newPersoncomboBox1);
            this.Controls.Add(this.newDatedateTimePicker1);
            this.Controls.Add(this.newAmountnumericUpDown1);
            this.Controls.Add(this.salesTaregetbutton1);
            this.Controls.Add(this.SalesdataGridView1);
            this.Controls.Add(this.refreshSalessabutton1);
            this.Controls.Add(this.RegioncomboBox1);
            this.Controls.Add(this.PeoplecomboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountnumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PeoplecomboBox1;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox RegioncomboBox1;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.Button refreshSalessabutton1;
        private System.Windows.Forms.DataGridView SalesdataGridView1;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.Button salesTaregetbutton1;
        private System.Windows.Forms.NumericUpDown newAmountnumericUpDown1;
        private System.Windows.Forms.DateTimePicker newDatedateTimePicker1;
        private System.Windows.Forms.ComboBox newPersoncomboBox1;
        private System.Windows.Forms.ComboBox newRegioncomboBox2;
        private System.Windows.Forms.Button newSalebutton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
    }
}


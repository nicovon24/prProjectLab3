namespace pryVonMuhlinenPP1
{
    partial class frmConsultSells
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grdSells = new System.Windows.Forms.DataGridView();
            this.colAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbxAllowDate = new System.Windows.Forms.CheckBox();
            this.cbxAllowEmployee = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblCounterRes = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSells)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(22, 646);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 32);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdSells
            // 
            this.grdSells.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdSells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdress,
            this.colPhone,
            this.colFecha,
            this.colHora,
            this.colPrice});
            this.grdSells.Location = new System.Drawing.Point(22, 239);
            this.grdSells.Name = "grdSells";
            this.grdSells.Size = new System.Drawing.Size(786, 370);
            this.grdSells.TabIndex = 10;
            this.grdSells.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSells_CellContentClick);
            // 
            // colAdress
            // 
            this.colAdress.HeaderText = "Producto";
            this.colAdress.Name = "colAdress";
            this.colAdress.Width = 200;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Cliente";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 185;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 150;
            // 
            // colHora
            // 
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cbxAllowDate);
            this.groupBox1.Controls.Add(this.cbxAllowEmployee);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.lblEmployee);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.cbEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 199);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(104, 89);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(154, 24);
            this.dtpEndDate.TabIndex = 20;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(17, 95);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 18);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "End Date";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(691, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 47);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear Filters";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbxAllowDate
            // 
            this.cbxAllowDate.AutoSize = true;
            this.cbxAllowDate.ForeColor = System.Drawing.Color.Black;
            this.cbxAllowDate.Location = new System.Drawing.Point(156, 142);
            this.cbxAllowDate.Name = "cbxAllowDate";
            this.cbxAllowDate.Size = new System.Drawing.Size(102, 22);
            this.cbxAllowDate.TabIndex = 17;
            this.cbxAllowDate.Text = "Allow date?";
            this.cbxAllowDate.UseVisualStyleBackColor = true;
            this.cbxAllowDate.CheckedChanged += new System.EventHandler(this.cbxAllowDate_CheckedChanged);
            // 
            // cbxAllowEmployee
            // 
            this.cbxAllowEmployee.AutoSize = true;
            this.cbxAllowEmployee.ForeColor = System.Drawing.Color.Black;
            this.cbxAllowEmployee.Location = new System.Drawing.Point(395, 142);
            this.cbxAllowEmployee.Name = "cbxAllowEmployee";
            this.cbxAllowEmployee.Size = new System.Drawing.Size(138, 22);
            this.cbxAllowEmployee.TabIndex = 16;
            this.cbxAllowEmployee.Text = "Allow employee?";
            this.cbxAllowEmployee.UseVisualStyleBackColor = true;
            this.cbxAllowEmployee.CheckedChanged += new System.EventHandler(this.cbxAllowEmployee_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.PeachPuff;
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(691, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(79, 27);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(104, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(154, 24);
            this.dtpDate.TabIndex = 14;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(321, 89);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(74, 18);
            this.lblEmployee.TabIndex = 11;
            this.lblEmployee.Text = "Employee";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Enabled = false;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(412, 86);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(121, 26);
            this.cbEmployee.TabIndex = 10;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // lblCounterRes
            // 
            this.lblCounterRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCounterRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterRes.Location = new System.Drawing.Point(608, 643);
            this.lblCounterRes.Name = "lblCounterRes";
            this.lblCounterRes.Size = new System.Drawing.Size(91, 35);
            this.lblCounterRes.TabIndex = 14;
            this.lblCounterRes.Text = "0";
            this.lblCounterRes.UseVisualStyleBackColor = false;
            this.lblCounterRes.Click += new System.EventHandler(this.lblCounterRes_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Black;
            this.lblCounter.Location = new System.Drawing.Point(488, 650);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(104, 18);
            this.lblCounter.TabIndex = 15;
            this.lblCounter.Text = "Products sold:";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.Black;
            this.lblIncome.Location = new System.Drawing.Point(488, 719);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(98, 18);
            this.lblIncome.TabIndex = 17;
            this.lblIncome.Text = "Total Income:";
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.Location = new System.Drawing.Point(608, 712);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(91, 35);
            this.btnIncome.TabIndex = 16;
            this.btnIncome.Text = "0";
            this.btnIncome.UseVisualStyleBackColor = false;
            // 
            // frmConsultSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 791);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblCounterRes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grdSells);
            this.Name = "frmConsultSells";
            this.Text = "Consult Sells";
            this.Load += new System.EventHandler(this.frmConsultSells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSells)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdSells;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.CheckBox cbxAllowDate;
        private System.Windows.Forms.CheckBox cbxAllowEmployee;
        private System.Windows.Forms.Button lblCounterRes;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnIncome;
    }
}
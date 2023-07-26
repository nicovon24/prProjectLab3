namespace pryVonMuhlinenPP1
{
    partial class frmConsultClients
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
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClients
            // 
            this.grdClients.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAdress,
            this.colPhone});
            this.grdClients.Location = new System.Drawing.Point(24, 12);
            this.grdClients.Name = "grdClients";
            this.grdClients.Size = new System.Drawing.Size(750, 445);
            this.grdClients.TabIndex = 0;
            this.grdClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClients_CellContentClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 230;
            // 
            // colAdress
            // 
            this.colAdress.HeaderText = "Adress";
            this.colAdress.Name = "colAdress";
            this.colAdress.Width = 280;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 185;
            // 
            // frmConsultClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 480);
            this.Controls.Add(this.grdClients);
            this.Name = "frmConsultClients";
            this.Text = "Consult Clients";
            this.Load += new System.EventHandler(this.frmConsultClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
    }
}
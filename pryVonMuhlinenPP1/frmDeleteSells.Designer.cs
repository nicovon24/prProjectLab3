namespace pryVonMuhlinenPP1
{
    partial class frmDeleteSells
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.btnCheckData = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblClientRes = new System.Windows.Forms.Label();
            this.lblProductRes = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.gbData.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(23, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(208, 44);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 26);
            this.cbID.TabIndex = 15;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            this.cbID.SelectedValueChanged += new System.EventHandler(this.cbID_SelectedValueChanged);
            // 
            // btnCheckData
            // 
            this.btnCheckData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckData.Location = new System.Drawing.Point(180, 171);
            this.btnCheckData.Name = "btnCheckData";
            this.btnCheckData.Size = new System.Drawing.Size(96, 32);
            this.btnCheckData.TabIndex = 16;
            this.btnCheckData.Text = "Check Data";
            this.btnCheckData.UseVisualStyleBackColor = true;
            this.btnCheckData.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblClientRes);
            this.gbData.Controls.Add(this.btnCheckData);
            this.gbData.Controls.Add(this.lblProductRes);
            this.gbData.Controls.Add(this.lblName);
            this.gbData.Controls.Add(this.lblAdress);
            this.gbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(53, 115);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(304, 220);
            this.gbData.TabIndex = 22;
            this.gbData.TabStop = false;
            this.gbData.Text = "Show data from item";
            // 
            // lblClientRes
            // 
            this.lblClientRes.AutoEllipsis = true;
            this.lblClientRes.BackColor = System.Drawing.Color.White;
            this.lblClientRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientRes.Location = new System.Drawing.Point(155, 119);
            this.lblClientRes.Name = "lblClientRes";
            this.lblClientRes.Size = new System.Drawing.Size(121, 18);
            this.lblClientRes.TabIndex = 26;
            // 
            // lblProductRes
            // 
            this.lblProductRes.AutoEllipsis = true;
            this.lblProductRes.BackColor = System.Drawing.Color.White;
            this.lblProductRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductRes.Location = new System.Drawing.Point(155, 48);
            this.lblProductRes.Name = "lblProductRes";
            this.lblProductRes.Size = new System.Drawing.Size(121, 18);
            this.lblProductRes.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(40, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Product";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.Color.Black;
            this.lblAdress.Location = new System.Drawing.Point(40, 119);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(40, 16);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Client";
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.label1);
            this.gbDelete.Controls.Add(this.gbData);
            this.gbDelete.Controls.Add(this.cbID);
            this.gbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDelete.Location = new System.Drawing.Point(23, 12);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(400, 363);
            this.gbDelete.TabIndex = 27;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete sell";
            // 
            // frmDeleteSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 485);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmDeleteSells";
            this.Text = "Delete Sells";
            this.Load += new System.EventHandler(this.frmDeleteSells_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btnCheckData;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblClientRes;
        private System.Windows.Forms.Label lblProductRes;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.GroupBox gbDelete;
    }
}
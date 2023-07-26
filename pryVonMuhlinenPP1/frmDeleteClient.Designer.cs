namespace pryVonMuhlinenPP1
{
    partial class frmDeleteClient
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
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.label1);
            this.gbDelete.Controls.Add(this.cbID);
            this.gbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDelete.Location = new System.Drawing.Point(27, 12);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(383, 150);
            this.gbDelete.TabIndex = 30;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(208, 44);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 26);
            this.cbID.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(27, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 32);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 253);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmDeleteClient";
            this.Text = "Delete Client";
            this.Load += new System.EventHandler(this.frmDeleteClient_Load);
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btnDelete;
    }
}
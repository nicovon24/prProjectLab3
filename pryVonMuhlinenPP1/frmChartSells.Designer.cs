namespace pryVonMuhlinenPP1
{
    partial class frmChartSells
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartBindSource = new System.Windows.Forms.BindingSource(this.components);
            this.chrtSells = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chrtSells
            // 
            this.chrtSells.Location = new System.Drawing.Point(31, 33);
            this.chrtSells.Name = "chrtSells";
            this.chrtSells.Size = new System.Drawing.Size(1023, 560);
            this.chrtSells.TabIndex = 2;
            this.chrtSells.Text = "chrtSells";
            this.chrtSells.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // frmChartSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 615);
            this.Controls.Add(this.chrtSells);
            this.Name = "frmChartSells";
            this.Text = "Total income per month (graphic)";
            this.Load += new System.EventHandler(this.frmChartSells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBindSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource chartBindSource;
        private LiveCharts.WinForms.CartesianChart chrtSells;
    }
}
namespace ShaleyPoshanAhar.Reports
{
    partial class ReportDailyEntry
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
            this.GVDailyEntry = new System.Windows.Forms.DataGridView();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVDailyEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // GVDailyEntry
            // 
            this.GVDailyEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDailyEntry.Location = new System.Drawing.Point(0, 46);
            this.GVDailyEntry.Name = "GVDailyEntry";
            this.GVDailyEntry.Size = new System.Drawing.Size(783, 462);
            this.GVDailyEntry.TabIndex = 0;
            this.GVDailyEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVDailyEntry_CellContentClick);
            // 
            // dtdate
            // 
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(186, 12);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(101, 20);
            this.dtdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Date";
            // 
            // ReportDailyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.GVDailyEntry);
            this.Name = "ReportDailyEntry";
            this.Text = "ReportDailyEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportDailyEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDailyEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVDailyEntry;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label label1;
    }
}
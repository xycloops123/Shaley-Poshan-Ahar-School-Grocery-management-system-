namespace ShaleyPoshanAhar
{
    partial class DailyEntry
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
            this.GVDetail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Find = new System.Windows.Forms.Button();
            this.GVGroup = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.WD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Modify1 = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVDetail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVGroup)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVDetail
            // 
            this.GVDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVDetail.Location = new System.Drawing.Point(3, 169);
            this.GVDetail.Name = "GVDetail";
            this.GVDetail.Size = new System.Drawing.Size(778, 278);
            this.GVDetail.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Find);
            this.panel1.Controls.Add(this.GVGroup);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.WD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 160);
            this.panel1.TabIndex = 2;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(602, 60);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 58);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // GVGroup
            // 
            this.GVGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVGroup.Location = new System.Drawing.Point(3, 42);
            this.GVGroup.Name = "GVGroup";
            this.GVGroup.Size = new System.Drawing.Size(541, 110);
            this.GVGroup.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // WD
            // 
            this.WD.AutoSize = true;
            this.WD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WD.Location = new System.Drawing.Point(382, 13);
            this.WD.Name = "WD";
            this.WD.Size = new System.Drawing.Size(51, 20);
            this.WD.TabIndex = 0;
            this.WD.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "WeekDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.Modify1);
            this.panel2.Controls.Add(this.cancle);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(3, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 55);
            this.panel2.TabIndex = 15;
            // 
            // Modify1
            // 
            this.Modify1.Location = new System.Drawing.Point(373, 3);
            this.Modify1.Name = "Modify1";
            this.Modify1.Size = new System.Drawing.Size(102, 47);
            this.Modify1.TabIndex = 1;
            this.Modify1.Text = "Modify";
            this.Modify1.UseVisualStyleBackColor = false;
            this.Modify1.Click += new System.EventHandler(this.Modify1_Click);
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(600, 5);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(102, 47);
            this.cancle.TabIndex = 1;
            this.cancle.Text = "Close";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(272, 1);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(95, 48);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(13, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 48);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DailyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GVDetail);
            this.Controls.Add(this.panel1);
            this.Name = "DailyEntry";
            this.Text = "DailyEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DailyEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVGroup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.DataGridView GVGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label WD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Modify1;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
    }
}
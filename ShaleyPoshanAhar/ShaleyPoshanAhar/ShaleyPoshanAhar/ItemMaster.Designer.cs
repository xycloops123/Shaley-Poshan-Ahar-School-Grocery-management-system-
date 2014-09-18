namespace ShaleyPoshanAhar
{
    partial class ItemMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GMGroup = new System.Windows.Forms.DataGridView();
            this.CLWeekDay = new System.Windows.Forms.CheckedListBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemGroup = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Modify1 = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.gvWeekday = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GMGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGroup)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWeekday)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txtItemId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GMGroup);
            this.panel1.Controls.Add(this.CLWeekDay);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 310);
            this.panel1.TabIndex = 12;
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(138, 12);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(333, 20);
            this.txtItemId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Item Id";
            // 
            // GMGroup
            // 
            this.GMGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GMGroup.Location = new System.Drawing.Point(138, 178);
            this.GMGroup.Name = "GMGroup";
            this.GMGroup.Size = new System.Drawing.Size(333, 116);
            this.GMGroup.TabIndex = 13;
            // 
            // CLWeekDay
            // 
            this.CLWeekDay.FormattingEnabled = true;
            this.CLWeekDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.CLWeekDay.Location = new System.Drawing.Point(138, 72);
            this.CLWeekDay.Name = "CLWeekDay";
            this.CLWeekDay.Size = new System.Drawing.Size(333, 94);
            this.CLWeekDay.TabIndex = 10;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(138, 46);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(333, 20);
            this.txtItemName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Insert Weight\r\n In grams)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Define \r\nWeight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "WeekDay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // ItemGroup
            // 
            this.ItemGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGroup.Location = new System.Drawing.Point(516, 1);
            this.ItemGroup.Name = "ItemGroup";
            this.ItemGroup.Size = new System.Drawing.Size(543, 310);
            this.ItemGroup.TabIndex = 13;
            this.ItemGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGroup_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.Modify1);
            this.panel2.Controls.Add(this.cancle);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Location = new System.Drawing.Point(3, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 55);
            this.panel2.TabIndex = 14;
            // 
            // Modify1
            // 
            this.Modify1.Location = new System.Drawing.Point(593, 5);
            this.Modify1.Name = "Modify1";
            this.Modify1.Size = new System.Drawing.Size(102, 47);
            this.Modify1.TabIndex = 1;
            this.Modify1.Text = "Modify";
            this.Modify1.UseVisualStyleBackColor = true;
            this.Modify1.Click += new System.EventHandler(this.Modify1_Click);
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(114, 4);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(102, 47);
            this.cancle.TabIndex = 1;
            this.cancle.Text = "Close";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(492, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(95, 48);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
            // gvWeekday
            // 
            this.gvWeekday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWeekday.Location = new System.Drawing.Point(1065, 1);
            this.gvWeekday.Name = "gvWeekday";
            this.gvWeekday.Size = new System.Drawing.Size(144, 305);
            this.gvWeekday.TabIndex = 15;
            // 
            // ItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShaleyPoshanAhar.Properties.Resources.Penguins;
            this.ClientSize = new System.Drawing.Size(1214, 369);
            this.Controls.Add(this.gvWeekday);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ItemGroup);
            this.Controls.Add(this.panel1);
            this.Name = "ItemMaster";
            this.Text = "ItemMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GMGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGroup)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvWeekday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GMGroup;
        private System.Windows.Forms.CheckedListBox CLWeekDay;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Modify1;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvWeekday;
    }
}
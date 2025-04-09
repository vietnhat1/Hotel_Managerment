namespace Hotel_Managerment
{
    partial class frm_qlBill
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
            this.dtgv_Bill = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Createday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cn = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_IDBooking = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Bill
            // 
            this.dtgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Bill.Location = new System.Drawing.Point(0, 485);
            this.dtgv_Bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_Bill.Name = "dtgv_Bill";
            this.dtgv_Bill.RowHeadersWidth = 51;
            this.dtgv_Bill.RowTemplate.Height = 24;
            this.dtgv_Bill.Size = new System.Drawing.Size(844, 160);
            this.dtgv_Bill.TabIndex = 20;
            this.dtgv_Bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Bill_CellContentClick);
            this.dtgv_Bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Bill_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(844, 160);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "\r\nQuản Lý Bill";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID Đặt phòng";
            // 
            // txt_Createday
            // 
            this.txt_Createday.Location = new System.Drawing.Point(317, 346);
            this.txt_Createday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Createday.Multiline = true;
            this.txt_Createday.Name = "txt_Createday";
            this.txt_Createday.Size = new System.Drawing.Size(229, 34);
            this.txt_Createday.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Create Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Add.Location = new System.Drawing.Point(108, 407);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(125, 52);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Update.Location = new System.Drawing.Point(293, 407);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(125, 52);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Delete.Location = new System.Drawing.Point(467, 407);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 52);
            this.btn_Delete.TabIndex = 33;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cn
            // 
            this.btn_Cn.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Cn.Location = new System.Drawing.Point(682, 406);
            this.btn_Cn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cn.Name = "btn_Cn";
            this.btn_Cn.Size = new System.Drawing.Size(138, 52);
            this.btn_Cn.TabIndex = 34;
            this.btn_Cn.Text = "Cập nhật";
            this.btn_Cn.UseVisualStyleBackColor = false;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(317, 280);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(229, 34);
            this.txt_Total.TabIndex = 37;
            // 
            // txt_IDBooking
            // 
            this.txt_IDBooking.Location = new System.Drawing.Point(317, 214);
            this.txt_IDBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDBooking.Multiline = true;
            this.txt_IDBooking.Name = "txt_IDBooking";
            this.txt_IDBooking.Size = new System.Drawing.Size(229, 34);
            this.txt_IDBooking.TabIndex = 38;
            // 
            // frm_qlBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(842, 644);
            this.Controls.Add(this.txt_IDBooking);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.btn_Cn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Createday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgv_Bill);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_qlBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý bill";
            this.Load += new System.EventHandler(this.frm_qlBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_Bill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Createday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cn;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_IDBooking;
    }
}
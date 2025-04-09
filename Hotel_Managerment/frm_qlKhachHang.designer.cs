namespace Hotel_Managerment
{
    partial class frm_qlKhachHang
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
            this.btn_Capnhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtgv_qlKhachhang = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_Tuoi = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Gioitinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qlKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Capnhat.Location = new System.Drawing.Point(670, 379);
            this.btn_Capnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(116, 52);
            this.btn_Capnhat.TabIndex = 15;
            this.btn_Capnhat.Text = "Cập nhật";
            this.btn_Capnhat.UseVisualStyleBackColor = false;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Xoa.Location = new System.Drawing.Point(432, 379);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 52);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Sua.Location = new System.Drawing.Point(262, 379);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(99, 52);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_Them.Location = new System.Drawing.Point(93, 379);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 52);
            this.btn_Them.TabIndex = 12;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtgv_qlKhachhang
            // 
            this.dtgv_qlKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_qlKhachhang.Location = new System.Drawing.Point(0, 469);
            this.dtgv_qlKhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_qlKhachhang.Name = "dtgv_qlKhachhang";
            this.dtgv_qlKhachhang.RowHeadersWidth = 51;
            this.dtgv_qlKhachhang.RowTemplate.Height = 24;
            this.dtgv_qlKhachhang.Size = new System.Drawing.Size(843, 171);
            this.dtgv_qlKhachhang.TabIndex = 16;
            this.dtgv_qlKhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_qlKhachhang_CellContentClick);
            this.dtgv_qlKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_qlKhachhang_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 142);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "\r\nQuản Lý Khách Hàng";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(580, 284);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(206, 34);
            this.txt_sdt.TabIndex = 31;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(80, 190);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(206, 36);
            this.txt_tenkh.TabIndex = 30;
            // 
            // txt_Tuoi
            // 
            this.txt_Tuoi.Location = new System.Drawing.Point(580, 190);
            this.txt_Tuoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tuoi.Multiline = true;
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Size = new System.Drawing.Size(206, 35);
            this.txt_Tuoi.TabIndex = 29;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(81, 284);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(205, 34);
            this.txt_DiaChi.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name Customer";
            // 
            // txt_Gioitinh
            // 
            this.txt_Gioitinh.Location = new System.Drawing.Point(393, 234);
            this.txt_Gioitinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Gioitinh.Multiline = true;
            this.txt_Gioitinh.Name = "txt_Gioitinh";
            this.txt_Gioitinh.Size = new System.Drawing.Size(88, 35);
            this.txt_Gioitinh.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Gender";
            // 
            // frm_qlKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 644);
            this.Controls.Add(this.txt_Gioitinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_Tuoi);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtgv_qlKhachhang);
            this.Controls.Add(this.btn_Capnhat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_qlKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frm_qlKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_qlKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Capnhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dtgv_qlKhachhang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_Tuoi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Gioitinh;
        private System.Windows.Forms.Label label6;
    }
}
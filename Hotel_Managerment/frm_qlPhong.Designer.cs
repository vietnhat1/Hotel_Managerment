namespace Hotel_Managerment
{
    partial class frm_qlPhong
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
            this.grv_Phong = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cap = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cb_loai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Phong
            // 
            this.grv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Phong.Location = new System.Drawing.Point(-6, 492);
            this.grv_Phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grv_Phong.Name = "grv_Phong";
            this.grv_Phong.RowHeadersWidth = 51;
            this.grv_Phong.RowTemplate.Height = 24;
            this.grv_Phong.Size = new System.Drawing.Size(852, 151);
            this.grv_Phong.TabIndex = 12;
            this.grv_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Phong_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(847, 148);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "\r\nQuản Lý Phòng";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cap
            // 
            this.btn_cap.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_cap.Location = new System.Drawing.Point(678, 395);
            this.btn_cap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cap.Name = "btn_cap";
            this.btn_cap.Size = new System.Drawing.Size(107, 45);
            this.btn_cap.TabIndex = 24;
            this.btn_cap.Text = "Cập nhật";
            this.btn_cap.UseVisualStyleBackColor = false;
            this.btn_cap.Click += new System.EventHandler(this.btn_cap_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_xoa.Location = new System.Drawing.Point(396, 395);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 45);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_sua.Location = new System.Drawing.Point(226, 395);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 45);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_them.Location = new System.Drawing.Point(57, 395);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 45);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // cb_loai
            // 
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.Location = new System.Drawing.Point(312, 334);
            this.cb_loai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(216, 28);
            this.cb_loai.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(312, 184);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Gia.Multiline = true;
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(216, 33);
            this.txt_Gia.TabIndex = 26;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(312, 259);
            this.txt_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TrangThai.Multiline = true;
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(216, 33);
            this.txt_TrangThai.TabIndex = 27;
            // 
            // frm_qlPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(842, 644);
            this.Controls.Add(this.txt_TrangThai);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.btn_cap);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cb_loai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grv_Phong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_qlPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frm_qlPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Phong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grv_Phong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cap;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cb_loai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_TrangThai;
    }
}
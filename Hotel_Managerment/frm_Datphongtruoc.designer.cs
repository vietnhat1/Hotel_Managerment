namespace Hotel_Managerment.View
{
    partial class frm_Datphongtruoc
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
            this.label7 = new System.Windows.Forms.Label();
            this.flp_dsPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Datphongtruoc = new System.Windows.Forms.Button();
            this.date_Checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_IDKhachhang = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_IDDatphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_Ngaydatphong = new System.Windows.Forms.DateTimePicker();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.cb_loaiphong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_Reservation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Reservation)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(910, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ngày đặt phòng";
            // 
            // flp_dsPhong
            // 
            this.flp_dsPhong.BackColor = System.Drawing.Color.Gray;
            this.flp_dsPhong.Location = new System.Drawing.Point(11, 14);
            this.flp_dsPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flp_dsPhong.Name = "flp_dsPhong";
            this.flp_dsPhong.Size = new System.Drawing.Size(526, 525);
            this.flp_dsPhong.TabIndex = 47;
            // 
            // btn_Datphongtruoc
            // 
            this.btn_Datphongtruoc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Datphongtruoc.Location = new System.Drawing.Point(1030, 158);
            this.btn_Datphongtruoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Datphongtruoc.Name = "btn_Datphongtruoc";
            this.btn_Datphongtruoc.Size = new System.Drawing.Size(152, 58);
            this.btn_Datphongtruoc.TabIndex = 45;
            this.btn_Datphongtruoc.Text = "Đặt phòng trước";
            this.btn_Datphongtruoc.UseVisualStyleBackColor = false;
            this.btn_Datphongtruoc.Click += new System.EventHandler(this.btn_Datphongtruoc_Click);
            // 
            // date_Checkin
            // 
            this.date_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Checkin.Location = new System.Drawing.Point(1050, 62);
            this.date_Checkin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_Checkin.Name = "date_Checkin";
            this.date_Checkin.Size = new System.Drawing.Size(152, 26);
            this.date_Checkin.TabIndex = 42;
            // 
            // txt_IDKhachhang
            // 
            this.txt_IDKhachhang.Location = new System.Drawing.Point(717, 106);
            this.txt_IDKhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDKhachhang.Name = "txt_IDKhachhang";
            this.txt_IDKhachhang.Size = new System.Drawing.Size(139, 26);
            this.txt_IDKhachhang.TabIndex = 41;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(717, 62);
            this.txt_IDPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(139, 26);
            this.txt_IDPhong.TabIndex = 40;
            // 
            // txt_IDDatphong
            // 
            this.txt_IDDatphong.Location = new System.Drawing.Point(717, 19);
            this.txt_IDDatphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDDatphong.Name = "txt_IDDatphong";
            this.txt_IDDatphong.Size = new System.Drawing.Size(139, 26);
            this.txt_IDDatphong.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(910, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID Đặt phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Trạng thái";
            // 
            // date_Ngaydatphong
            // 
            this.date_Ngaydatphong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Ngaydatphong.Location = new System.Drawing.Point(1050, 19);
            this.date_Ngaydatphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_Ngaydatphong.Name = "date_Ngaydatphong";
            this.date_Ngaydatphong.Size = new System.Drawing.Size(152, 26);
            this.date_Ngaydatphong.TabIndex = 52;
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(1050, 106);
            this.cb_trangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(152, 28);
            this.cb_trangthai.TabIndex = 53;
            // 
            // cb_loaiphong
            // 
            this.cb_loaiphong.FormattingEnabled = true;
            this.cb_loaiphong.Location = new System.Drawing.Point(717, 158);
            this.cb_loaiphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_loaiphong.Name = "cb_loaiphong";
            this.cb_loaiphong.Size = new System.Drawing.Size(139, 28);
            this.cb_loaiphong.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Loại phòng";
            // 
            // dtgv_Reservation
            // 
            this.dtgv_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Reservation.Location = new System.Drawing.Point(544, 222);
            this.dtgv_Reservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_Reservation.Name = "dtgv_Reservation";
            this.dtgv_Reservation.RowHeadersWidth = 51;
            this.dtgv_Reservation.RowTemplate.Height = 24;
            this.dtgv_Reservation.Size = new System.Drawing.Size(836, 304);
            this.dtgv_Reservation.TabIndex = 57;
            // 
            // frm_Datphongtruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 562);
            this.Controls.Add(this.dtgv_Reservation);
            this.Controls.Add(this.cb_loaiphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.date_Ngaydatphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flp_dsPhong);
            this.Controls.Add(this.btn_Datphongtruoc);
            this.Controls.Add(this.date_Checkin);
            this.Controls.Add(this.txt_IDKhachhang);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.txt_IDDatphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Datphongtruoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đặt phòng trước";
            this.Load += new System.EventHandler(this.frm_Datphongtruoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Reservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhong;
        private System.Windows.Forms.Button btn_Datphongtruoc;
        private System.Windows.Forms.DateTimePicker date_Checkin;
        private System.Windows.Forms.TextBox txt_IDKhachhang;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_IDDatphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.DateTimePicker date_Ngaydatphong;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.ComboBox cb_loaiphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv_Reservation;
    }
}
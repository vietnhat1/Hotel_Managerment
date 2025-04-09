namespace Hotel_Managerment
{
    partial class frm_datphong
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
            this.btn_Datphong = new System.Windows.Forms.Button();
            this.date_Checkout = new System.Windows.Forms.DateTimePicker();
            this.date_Checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_IDKhachhang = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_IDDatphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_loaiphong = new System.Windows.Forms.ComboBox();
            this.dtgv_Booking = new System.Windows.Forms.DataGridView();
            this.flp_dsPhong = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Booking)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Datphong
            // 
            this.btn_Datphong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Datphong.Location = new System.Drawing.Point(1017, 150);
            this.btn_Datphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Datphong.Name = "btn_Datphong";
            this.btn_Datphong.Size = new System.Drawing.Size(116, 46);
            this.btn_Datphong.TabIndex = 27;
            this.btn_Datphong.Text = "Đặt phòng";
            this.btn_Datphong.UseVisualStyleBackColor = false;
            this.btn_Datphong.Click += new System.EventHandler(this.btn_Datphong_Click_1);
            // 
            // date_Checkout
            // 
            this.date_Checkout.CustomFormat = "yyyy-MM-dd";
            this.date_Checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Checkout.Location = new System.Drawing.Point(690, 106);
            this.date_Checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_Checkout.Name = "date_Checkout";
            this.date_Checkout.Size = new System.Drawing.Size(152, 26);
            this.date_Checkout.TabIndex = 25;
            // 
            // date_Checkin
            // 
            this.date_Checkin.CustomFormat = "yyyy-MM-dd";
            this.date_Checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Checkin.Location = new System.Drawing.Point(690, 62);
            this.date_Checkin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_Checkin.Name = "date_Checkin";
            this.date_Checkin.Size = new System.Drawing.Size(152, 26);
            this.date_Checkin.TabIndex = 24;
            // 
            // txt_IDKhachhang
            // 
            this.txt_IDKhachhang.Location = new System.Drawing.Point(1017, 62);
            this.txt_IDKhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDKhachhang.Name = "txt_IDKhachhang";
            this.txt_IDKhachhang.Size = new System.Drawing.Size(134, 26);
            this.txt_IDKhachhang.TabIndex = 23;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(1017, 19);
            this.txt_IDPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(134, 26);
            this.txt_IDPhong.TabIndex = 22;
            // 
            // txt_IDDatphong
            // 
            this.txt_IDDatphong.Location = new System.Drawing.Point(690, 19);
            this.txt_IDDatphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDDatphong.Name = "txt_IDDatphong";
            this.txt_IDDatphong.Size = new System.Drawing.Size(152, 26);
            this.txt_IDDatphong.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(907, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(907, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Đặt phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(907, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tổng tiền";
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(1017, 109);
            this.txt_Tongtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.ReadOnly = true;
            this.txt_Tongtien.Size = new System.Drawing.Size(134, 26);
            this.txt_Tongtien.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Loại phòng";
            // 
            // cb_loaiphong
            // 
            this.cb_loaiphong.FormattingEnabled = true;
            this.cb_loaiphong.Location = new System.Drawing.Point(690, 159);
            this.cb_loaiphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_loaiphong.Name = "cb_loaiphong";
            this.cb_loaiphong.Size = new System.Drawing.Size(152, 28);
            this.cb_loaiphong.TabIndex = 36;
            // 
            // dtgv_Booking
            // 
            this.dtgv_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Booking.Location = new System.Drawing.Point(551, 204);
            this.dtgv_Booking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_Booking.Name = "dtgv_Booking";
            this.dtgv_Booking.RowHeadersWidth = 51;
            this.dtgv_Booking.RowTemplate.Height = 24;
            this.dtgv_Booking.Size = new System.Drawing.Size(854, 336);
            this.dtgv_Booking.TabIndex = 37;
            // 
            // flp_dsPhong
            // 
            this.flp_dsPhong.BackColor = System.Drawing.Color.Gray;
            this.flp_dsPhong.Location = new System.Drawing.Point(14, 15);
            this.flp_dsPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flp_dsPhong.Name = "flp_dsPhong";
            this.flp_dsPhong.Size = new System.Drawing.Size(526, 525);
            this.flp_dsPhong.TabIndex = 48;
            // 
            // frm_datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 562);
            this.Controls.Add(this.flp_dsPhong);
            this.Controls.Add(this.dtgv_Booking);
            this.Controls.Add(this.cb_loaiphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Datphong);
            this.Controls.Add(this.date_Checkout);
            this.Controls.Add(this.date_Checkin);
            this.Controls.Add(this.txt_IDKhachhang);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.txt_IDDatphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_datphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.frm_datphong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Datphong;
        private System.Windows.Forms.DateTimePicker date_Checkout;
        private System.Windows.Forms.DateTimePicker date_Checkin;
        private System.Windows.Forms.TextBox txt_IDKhachhang;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_IDDatphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_loaiphong;
        private System.Windows.Forms.DataGridView dtgv_Booking;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhong;
    }
}
namespace Hotel_Managerment.View
{
    partial class frm_Thanhtoan
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
            this.txt_Tongtien = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_IDBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flp_dsPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Thanhtoan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.dtgv_Thanhtoan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thanhtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Tongtien
            // 
            this.txt_Tongtien.Location = new System.Drawing.Point(978, 28);
            this.txt_Tongtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tongtien.Name = "txt_Tongtien";
            this.txt_Tongtien.Size = new System.Drawing.Size(139, 26);
            this.txt_Tongtien.TabIndex = 60;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(669, 71);
            this.txt_IDPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(139, 26);
            this.txt_IDPhong.TabIndex = 59;
            // 
            // txt_IDBill
            // 
            this.txt_IDBill.Location = new System.Drawing.Point(669, 28);
            this.txt_IDBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IDBill.Name = "txt_IDBill";
            this.txt_IDBill.Size = new System.Drawing.Size(139, 26);
            this.txt_IDBill.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(888, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID Bill";
            // 
            // flp_dsPhong
            // 
            this.flp_dsPhong.BackColor = System.Drawing.Color.Gray;
            this.flp_dsPhong.Location = new System.Drawing.Point(21, 19);
            this.flp_dsPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flp_dsPhong.Name = "flp_dsPhong";
            this.flp_dsPhong.Size = new System.Drawing.Size(497, 525);
            this.flp_dsPhong.TabIndex = 65;
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Thanhtoan.Location = new System.Drawing.Point(811, 504);
            this.btn_Thanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(109, 40);
            this.btn_Thanhtoan.TabIndex = 64;
            this.btn_Thanhtoan.Text = "Thanh toán";
            this.btn_Thanhtoan.UseVisualStyleBackColor = false;
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(889, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ngày tạo";
            // 
            // date_ngaytao
            // 
            this.date_ngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaytao.Location = new System.Drawing.Point(978, 71);
            this.date_ngaytao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_ngaytao.Name = "date_ngaytao";
            this.date_ngaytao.Size = new System.Drawing.Size(139, 26);
            this.date_ngaytao.TabIndex = 72;
            // 
            // dtgv_Thanhtoan
            // 
            this.dtgv_Thanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Thanhtoan.Location = new System.Drawing.Point(556, 164);
            this.dtgv_Thanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_Thanhtoan.Name = "dtgv_Thanhtoan";
            this.dtgv_Thanhtoan.RowHeadersWidth = 51;
            this.dtgv_Thanhtoan.RowTemplate.Height = 24;
            this.dtgv_Thanhtoan.Size = new System.Drawing.Size(800, 332);
            this.dtgv_Thanhtoan.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Trạng thái";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(669, 118);
            this.cb_trangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(136, 28);
            this.cb_trangthai.TabIndex = 75;
            // 
            // frm_Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 562);
            this.Controls.Add(this.cb_trangthai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgv_Thanhtoan);
            this.Controls.Add(this.date_ngaytao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Tongtien);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.txt_IDBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_dsPhong);
            this.Controls.Add(this.btn_Thanhtoan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.frm_Thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thanhtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Tongtien;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_IDBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhong;
        private System.Windows.Forms.Button btn_Thanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_ngaytao;
        private System.Windows.Forms.DataGridView dtgv_Thanhtoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_trangthai;
    }
}
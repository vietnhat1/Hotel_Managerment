using Hotel_Managerment.Controller;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Hotel_Managerment.View
{
    public partial class frm_Thanhtoan : Form
    {
        BillController controller = new BillController();

        public frm_Thanhtoan()
        {
            InitializeComponent();
        }

        private void frm_Thanhtoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachBooking();
            LoadDanhSachHoaDon();

            cb_trangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_trangthai.Items.AddRange(new string[] { "Need Clean", "Ready" });
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataRow row = (DataRow)btn.Tag;

            txt_IDPhong.Text = row["room_id"].ToString();
            txt_IDBill.Text = row["booking_id"].ToString();
            txt_Tongtien.Text = row["total"].ToString();
            date_ngaytao.Value = DateTime.Now;
        }

        private void LoadDanhSachBooking()
        {
            flp_dsPhong.Controls.Clear();
            DataTable dt = controller.LayDanhSachBooking();

            foreach (DataRow row in dt.Rows)
            {
                string roomID = row["room_id"].ToString();

                // Lấy trạng thái phòng từ database
                string sql = $"SELECT status FROM Room WHERE room_id = {roomID}";
                string status = new LopDungChung().Scalar(sql)?.ToString();

                // Chỉ hiển thị phòng đang sử dụng
                if (status == "Occupied")
                {
                    Button btn = new Button();
                    btn.Text = "Phòng " + roomID;
                    btn.Width = 80;
                    btn.Height = 80;
                    btn.Tag = row;
                    btn.Click += Btn_Click;
                    btn.BackColor = Color.OrangeRed;

                    flp_dsPhong.Controls.Add(btn);
                }
            }
        }

        private void LoadDanhSachHoaDon()
        {
            dtgv_Thanhtoan.DataSource = controller.LayTatCaHoaDon();
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_IDBill.Text == "" || txt_Tongtien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = controller.ThanhToan(
     Convert.ToInt32(txt_IDBill.Text.Trim()),
     Convert.ToDecimal(txt_Tongtien.Text),
     date_ngaytao.Value
 );


            if (success)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                controller.CapNhatTrangThaiPhong(txt_IDBill.Text);

                foreach (Control ctrl in flp_dsPhong.Controls)
                {
                    if (ctrl is Button btn && btn.Text.Contains(txt_IDPhong.Text))
                    {
                        flp_dsPhong.Controls.Remove(btn);
                        break;
                    }
                }

                LoadDanhSachHoaDon();

                SystemLogController log = new SystemLogController();
                int customerID = log.GetCustomerIDFromBill(txt_IDBill.Text.Trim());

                log.GhiLogThanhToan(
                    customerID,
                    Convert.ToInt32(txt_IDPhong.Text.Trim()),
                    Convert.ToInt32(txt_IDBill.Text.Trim()),
                    Convert.ToDecimal(txt_Tongtien.Text.Trim())
                );
                log.GhiLogTrangThaiPhong(
                Convert.ToInt32(txt_IDPhong.Text.Trim()),
                "Occupied",                    
                cb_trangthai.Text.Trim()      
                );


                txt_IDBill.Clear();
                txt_IDPhong.Clear();
                txt_Tongtien.Clear();
            }
        }
    }
}
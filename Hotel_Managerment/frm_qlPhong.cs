using Hotel_Managerment.Controller;
using System;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class frm_qlPhong : Form
    {
        private RoomController controller = new RoomController();
        private int selectedRoomID = -1;

        public frm_qlPhong()
        {
            InitializeComponent();
        }

        private void frm_qlPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadLoaiP();
        }

        private void LoadPhong()
        {
            grv_Phong.DataSource = controller.LoadRooms();
            grv_Phong.ClearSelection();
            ResetInputs();
        }

        private void LoadLoaiP()
        {
            cb_loai.DataSource = controller.LoadRoomTypes();
            cb_loai.DisplayMember = "name";
            cb_loai.ValueMember = "room_type_id";
        }

        private void grv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grv_Phong.Rows.Count)
            {
                var row = grv_Phong.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["room_id"].Value?.ToString(), out int id))
                    selectedRoomID = id;
                else
                    selectedRoomID = -1;

                txt_Gia.Text = row.Cells["price"].Value?.ToString();
                txt_TrangThai.Text = row.Cells["status"].Value?.ToString();
                cb_loai.SelectedValue = row.Cells["room_type_id"].Value ?? 0;
            }
        }

        

        private void ResetInputs()
        {
            selectedRoomID = -1;
            txt_Gia.Clear();
            txt_TrangThai.Clear();
            if (cb_loai.Items.Count > 0)
                cb_loai.SelectedIndex = 0;
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (cb_loai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng.");
                return;
            }

            bool result = controller.AddRoom(
                decimal.Parse(txt_Gia.Text),
                txt_TrangThai.Text,
                Convert.ToInt32(cb_loai.SelectedValue));

            if (result)
                LoadPhong();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (selectedRoomID == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa.");
                return;
            }

            bool result = controller.UpdateRoom(
                selectedRoomID,
                decimal.Parse(txt_Gia.Text),
                txt_TrangThai.Text,
                Convert.ToInt32(cb_loai.SelectedValue));

            if (result)
                LoadPhong();
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (selectedRoomID == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.");
                return;
            }

            bool result = controller.DeleteRoom(selectedRoomID);
            if (result)
                LoadPhong();
        }

        private void btn_cap_Click_1(object sender, EventArgs e)
        {
            LoadPhong();
        }
    }
}

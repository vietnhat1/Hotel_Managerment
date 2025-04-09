using Hotel_Managerment.Controller;
using System;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class frm_qlBill : Form
    {
        private BillController controller = new BillController();
        private int selectedBillID = -1;
        public frm_qlBill()
        {
            InitializeComponent();
        }

        private void frm_qlBill_Load(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void LoadBill()
        {
            dtgv_Bill.DataSource = controller.LoadBills();
        }

        private void dtgv_Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_Bill.Rows.Count)
            {
                var row = dtgv_Bill.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["room_id"].Value?.ToString(), out int id))
                    selectedBillID = id;
                else
                    selectedBillID = -1;

                txt_IDBooking.Text = row.Cells["booking_id"].Value?.ToString();
                txt_Total.Text = row.Cells["total"].Value?.ToString();
               
                txt_Createday.Text = row.Cells["created_at"].Value?.ToString();
            }
        }

        

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool result = controller.AddBill(
                int.Parse(txt_IDBooking.Text), decimal.Parse
                (txt_Total.Text),
                DateTime.Parse(txt_Createday.Text));
            if (result)
                LoadBill();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedBillID == -1)
            {
                MessageBox.Show("Vui lòng chọn bill cần sửa.");
                return;
            }

            bool result = controller.UpdateBill(
                selectedBillID,
                 int.Parse(txt_IDBooking.Text), decimal.Parse
                (txt_Total.Text),
                DateTime.Parse(txt_Createday.Text));

            if (result)
                LoadBill();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedBillID == -1)
            {
                MessageBox.Show("Vui lòng chọn bill cần xóa.");
                return;
            }

            bool result = controller.DeleteBill(selectedBillID);
            if (result)
                LoadBill();
        }
    }
}

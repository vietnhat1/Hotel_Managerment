using Hotel_Managerment.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managerment
{
    public partial class frm_SystemLog : Form
    {
        private SystemLogController controller = new SystemLogController();
        private int selectedLogID = -1;
        public frm_SystemLog()
        {
            InitializeComponent();
        }

        private void btn_BillLog_Click(object sender, EventArgs e)
        {
            LoadLogs("BillLog");
        }

        private void btn_UserLog_Click(object sender, EventArgs e)
        {
            LoadLogs("UserLog");
        }

        private void btn_Roomlog_Click(object sender, EventArgs e)
        {
            LoadLogs("RoomLog");
        }
        private void LoadLogs(string logType)
        {
            DataTable table = controller.LoadLogs(logType);
            dgrv_log.DataSource = table;
            foreach (DataGridViewColumn column in dgrv_log.Columns)
            {
                bool allNull = true;
                foreach (DataGridViewRow row in dgrv_log.Rows)
                {
                    if (row.Cells[column.Index].Value != DBNull.Value &&
                        row.Cells[column.Index].Value != null &&
                        !string.IsNullOrWhiteSpace(row.Cells[column.Index].Value.ToString()))
                    {
                        allNull = false;
                        break;
                    }
                }
                column.Visible = !allNull;
            }
        }

        private void frm_SystemLog_Load(object sender, EventArgs e)
        {
            dgrv_log.AutoGenerateColumns = true;
            dgrv_log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
    }
}

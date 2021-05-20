using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChungKhoan_ChuyenDe
{
    public partial class DatLenh : Form
    {
        public DatLenh()
        {
            InitializeComponent();
        }

        private void DatLenh_Load(object sender, EventArgs e)
        {
            if (Program.DBConnect() == 1)
            {
                MessageBox.Show("Kết nối thành công!" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), "GOOD", MessageBoxButtons.OK);
            }
            cbxLoaiLenh.SelectedIndex = 0;
            cbxLoaiGD.SelectedIndex = 0;
            cbxLenhLO.SelectedIndex = 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (txtbMaCK.Text.Trim() == "")
            {
                MessageBox.Show("Mã CK không được để trống", "Lỗi", MessageBoxButtons.OK);
                txtbMaCK.Focus();
                return;
            }
            if (numbKhoiLuong.Value == 0)
            {
                MessageBox.Show("Khối lượng không được để trống", "Lỗi", MessageBoxButtons.OK);
                numbKhoiLuong.Focus();
                return;
            }
            if (numbGia.Value == 0)
            {
                MessageBox.Show("Giá không được để trống", "Lỗi", MessageBoxButtons.OK);
                numbGia.Focus();
                return;
            }

            try
            {
                String loaiGD = (cbxLoaiGD.SelectedIndex == 0) ? "M" : "B";
                String cmd = "exec SP_KHOPLENH_LO '" + txtbMaCK.Text + "','" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "','"
                        + loaiGD + "','" + numbKhoiLuong.Value + "','" + numbGia.Value + "'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Đặt lệnh thành công", "Lỗi", MessageBoxButtons.OK);
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void cbxLoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxLoaiGD.SelectedIndex == 0)
            {
                confirmBtn.Text = "Mua";
            }
            else
            {
                confirmBtn.Text = "Bán";
            }
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            this.txtbMaCK.Text = string.Empty;
            this.numbGia.Value = 0;
            this.numbKhoiLuong.Value = 0;
        }
    }
}

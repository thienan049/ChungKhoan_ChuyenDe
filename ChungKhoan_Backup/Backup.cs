using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChungKhoan_Backup
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.panelSetTime.Visible = false;
            if (Program.DBConnect() == 1)
            {
                MessageBox.Show("Kết nối thành công!" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), "GOOD", MessageBoxButtons.OK);
            }
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ChungKhoanDS.SP_DANHSACH_DB' table. You can move, or remove it, as needed.
            
            this.ChungKhoanDS.EnforceConstraints = false;

            this.sP_DANHSACH_DBTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DANHSACH_DBTableAdapter.Fill(this.ChungKhoanDS.SP_DANHSACH_DB);
            String db = this.listDB.GetItemText(this.listDB.SelectedItem);

            this.sP_BACKUP_POSITIONSTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BACKUP_POSITIONSTableAdapter.Fill(this.ChungKhoanDS.SP_BACKUP_POSITIONS, db);

            this.grCtrlBackupList.Text = db;
        }

        private void btnCreateDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtbDeviceName.Text.Trim() == "")
            {
                MessageBox.Show("Tên device không được để trống", "Lỗi tạo device", MessageBoxButtons.OK);
                txtbDeviceName.Focus();
                return;
            }

            try
            {
                String cmd = "exec sp_addumpdevice 'disk', '" + txtbDeviceName.Text + "','" + "D:\\BACKUP\\" + txtbDeviceName.Text + ".bak'";
                SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Tạo device thành công", "Thành công", MessageBoxButtons.OK);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnBackupDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String db = this.listDB.GetItemText(this.listDB.SelectedItem);
            String message = this.chbxOverwrite.Checked ? "Xác nhận backup database " + db + " và xóa các bản backup cũ?: "
                                                        : "Xác nhận backup database " + db + "?: ";
            if (MessageBox.Show(message, "Backup", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    String cmd = this.chbxOverwrite.Checked ? 
                     "BACKUP DATABASE CHUNGKHOAN TO [Device_ChungKhoan_Backup] WITH INIT, NAME='CHUNGKHOAN-Full Database Backup'"
                   : "BACKUP DATABASE CHUNGKHOAN TO [Device_ChungKhoan_Backup] WITH NAME='CHUNGKHOAN-Full Database Backup'";
                    SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo backup thành công", "Thành công", MessageBoxButtons.OK);
                    this.sP_BACKUP_POSITIONSTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_BACKUP_POSITIONSTableAdapter.Fill(this.ChungKhoanDS.SP_BACKUP_POSITIONS, "CHUNGKHOAN");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    Console.WriteLine(ex.Message);
                }
            }      
        }
        
        private void btnRestoreDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            String db = this.listDB.GetItemText(this.listDB.SelectedItem);
            String position = ((DataRowView)this.sP_BACKUP_POSITIONSBindingSource[this.sP_BACKUP_POSITIONSBindingSource.Position])["Position"].ToString();         
            String timeString = ((DataRowView)this.sP_BACKUP_POSITIONSBindingSource[this.sP_BACKUP_POSITIONSBindingSource.Position])["backup_start_date"].ToString();
            Console.WriteLine(timeString);
            DateTime time = Convert.ToDateTime(timeString);
            timeString = time.ToString("dd/MM/yyyy hh:mm:ss tt");
            String message;

            if (this.chbxTimeSpecified.Checked)
            {
                if (this.dateRestore.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mốc thời gian!", "Restore", MessageBoxButtons.OK);
                    return;
                }

                String date_stop_string = this.dateRestore.DateTime.Month + "/" + this.dateRestore.DateTime.Day + "/" + this.dateRestore.DateTime.Year +
                                    " " + this.timeRestore.Time.Hour + ":" + this.timeRestore.Time.Minute + ":" + this.timeRestore.Time.Second;
                DateTime restoreDate = DateTime.Parse(date_stop_string);            
                if(restoreDate > DateTime.Now)
                {
                    MessageBox.Show("Ngày thực hiện phải trước thời điểm hiện tại", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
                if (restoreDate < time)
                {
                    MessageBox.Show("Ngày thực hiện phải sau thời điểm backup", "Lỗi", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Xác nhận restore database " + db + " về thời điểm " + this.dateRestore.Text + " " + this.timeRestore.Text + "?: ", "Restore", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        String maxPostition = ((DataRowView)this.sP_BACKUP_POSITIONSBindingSource[0])["Position"].ToString();
                        String cmd = 
                            "ALTER DATABASE " + db + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;\n" +           
                            "USE tempdb;\n" +
                            "BACKUP LOG " + db + " TO DISK = 'D:\\BACKUP\\" + db + "_LOG.trn' WITH INIT, NORECOVERY;\n" +
                            "USE tempdb;\n" +
                            "RESTORE DATABASE " + db + " FROM Device_ChungKhoan_Backup WITH FILE = " + maxPostition + ", NORECOVERY;\n" +
                            "SET DATEFORMAT DMY;\n" +
                            "RESTORE DATABASE " + db + " FROM DISK = 'D:\\BACKUP\\" + db + "_LOG.trn' WITH STOPAT = '" + this.dateRestore.Text + " " + this.timeRestore.Text + "', RECOVERY;\n" +
                            "ALTER DATABASE " + db + " SET MULTI_USER;\n";
                        Console.WriteLine(cmd);
                        SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Restore thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Xác nhận restore database " + db + " về thời điểm " + timeString + "?: ", "Restore", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        String cmd =
                            "ALTER DATABASE " + db + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;\n" +
                            "USE tempdb;\n" +
                            "RESTORE DATABASE " + db + " FROM Device_ChungKhoan_Backup WITH FILE = " + position + ", REPLACE;\n" +
                            "ALTER DATABASE " + db + " SET MULTI_USER;\n";
                        SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Restore thành công", "Thành công", MessageBoxButtons.OK);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        Console.WriteLine(ex.Message);
                    }
                }
            }                                              
        }

        private void listDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String db = this.listDB.GetItemText(this.listDB.SelectedItem);
            this.grCtrlBackupList.Text = db;
            this.sP_BACKUP_POSITIONSTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BACKUP_POSITIONSTableAdapter.Fill(this.ChungKhoanDS.SP_BACKUP_POSITIONS, db);
        }

        private void chbxTimeSpecified_CheckedChanged(object sender, EventArgs e)
        {
            this.panelSetTime.Visible = this.chbxTimeSpecified.Checked ? true : false;
        }
    }
}

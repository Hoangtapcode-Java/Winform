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

namespace KiemTraChuong5
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            LopDungChung lopDungChung = new LopDungChung();
            string sql = "Select COUNT(*) from TAIKHOAN where TENDANGNHAP = '" + txt_TaiKhoan.Text + "'and MATKHAU = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopDungChung.LayGT(sql);
            if(kq == 1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                frm_Main main = new frm_Main();
                main.Show();
            }else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo");
            }
        }
    }
}

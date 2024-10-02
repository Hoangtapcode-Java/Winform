using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KiemTraChuong5
{
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        LopDungChung lopDungChung = new LopDungChung();
        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from SINHVIEN ";
            int kq = (int)lopDungChung.LayGT(sql);
            txt_DemSV.Text = kq.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SINHVIEN values('" + txt_MaSV.Text + "','" + txt_HoTen.Text + "','" + txt_DiaChi.Text +"')";
            int kq = lopDungChung.ThemSuaXoa(sql);
            if(kq >= 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE SINHVIEN set HOTEN = '" + txt_HoTen.Text+"', DIACHI = '"+txt_DiaChi.Text+"' where MASV = '" + txt_MaSV.Text+"'" ;
            int kq = lopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE SINHVIEN where MASV = '" + txt_MaSV.Text + "'";
            int kq = lopDungChung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }
    }
}

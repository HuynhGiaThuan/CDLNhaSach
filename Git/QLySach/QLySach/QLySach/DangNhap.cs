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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLySach
{
    public partial class DangNhap : Form
    {
      

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-56FGVUT\SQLEXPRESS; Initial Catalog=QL_NhaSach_THHCDL ;Integrated Security=True ");
            string MaNhanVien = txtTKhoan.Text;
            string Pwd = txtPW.Text;
          
            if (MaNhanVien == null || MaNhanVien.Equals(""))//ký tự trắng ko tồn tại
            {
                MessageBox.Show("Tài Khoản Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Pwd == null || Pwd.Equals(""))
            {
                MessageBox.Show("Mật Khẩu Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            string tk = "select * From NhanVien Where MaNhanVien='" + txtTKhoan.Text + "' and Pwd='" + txtPW.Text + "'";
            SqlCommand cmd = new SqlCommand(tk, con);
            SqlDataReader doc = cmd.ExecuteReader();
            if (doc.Read())
            {
               
                MessageBox.Show("Đăng Nhập Thành Công\nXin Chào" + MaNhanVien, "Đăng Nhập Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainBanSach main = new MainBanSach();
                main.Show();
                Hide();// 
            }
            else
            {
                MessageBox.Show("Tài KHoản Không Tồn Tài", "Đăng Nhập Thất Bại", MessageBoxButtons.OK);
            }
            con.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Chương Trình ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}

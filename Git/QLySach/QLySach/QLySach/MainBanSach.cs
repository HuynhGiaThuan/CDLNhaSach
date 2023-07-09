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

namespace QLySach
{
    public partial class MainBanSach : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = " Data Source=DESKTOP-56FGVUT\\SQLEXPRESS; Initial Catalog=QL_NhaSach_THHCDL ;Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public MainBanSach()
        {
            InitializeComponent();
        }

        private void MainBanSach_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }
        //chức năng
        private void btn_pay_Click(object sender, EventArgs e)
        {
            MainTinhTien TT = new MainTinhTien();
            TT.Show();
            Hide();
        }

        ///Sách
        ///Nhân Viên
        void SanPhamNhanVienDaBanDuoc()
        {

            cmd = con.CreateCommand();
            cmd.CommandText = "EXECUTE SpNVienDaBan '"+ txt_maNV.Text+ "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGView_nhanvien.DataSource = table;
        }

        private void btn_NVBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maNV.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                SanPhamNhanVienDaBanDuoc();
            }
            
        }

       

        ///Khách Hàng
        ///loadTenKhachHang
        void LoadTenKhachHang()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from KhachHang where TenKh like N'"+ txt_tenKH .Text+ "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGView_sach.DataSource = table;
        }

        private void btn_timKH_Click(object sender, EventArgs e)
        {
            LoadTenKhachHang();
        }

        private void DGView_sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGView_sach.CurrentRow.Index;
            txt_tenKH.Text = DGView_sach.Rows[i].Cells[1].Value.ToString();
            mtb_ngaysinhKH.Text = DGView_sach.Rows[i].Cells[2].Value.ToString();
            txt_diachiKH.Text = DGView_sach.Rows[i].Cells[3].Value.ToString();
        }
        void DiemTichLy()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "declare @DIEMTB Float set @DIEMTB=(Select DBO.DiemTichLy(N'"+ txt_tenKH .Text+ "')) select  @DIEMTB ";
              
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGView_sach.DataSource = table;
    
        }

        private void btn_DiemTichLuy_Click(object sender, EventArgs e)
        {
            DiemTichLy();
        }
        //Tác Giả
        void LoadTheTacGia()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "execute TheLoaiSach N'"+ txt_TenTGIa .Text+ "' ";

            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            DGV_TacGia.DataSource = table;
        }
        private void ck_all_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_all.Checked == true)
            {
                label1.Visible = true;
                label5.Visible = true;
                label20.Visible = true;
                label6.Visible = true;
                txt_MTGia.Visible = true;
                txt_NgSinh.Visible = true;
                txtDiaChi.Visible = true;
                txtGioiTinh.Visible = true;
                Btn_Add.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_edit.Enabled = true;
            }
            else
            {
                label1.Visible = false;
                label5.Visible = false;
                label20.Visible = false;
                label6.Visible = false;
                txt_MTGia.Visible = false;
                txt_NgSinh.Visible = false;
                txtDiaChi.Visible = false;
                txtGioiTinh.Visible = false;
                Btn_Add.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_edit.Enabled = false;
            }
        }

        private void ck_ThLoai_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ThLoai.Checked == true)
            {
                LoadTheTacGia();
            }
            else
            {

            }
        }
    }
}

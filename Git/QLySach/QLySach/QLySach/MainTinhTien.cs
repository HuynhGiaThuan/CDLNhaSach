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
    public partial class MainTinhTien : Form
    {


        SqlConnection con;
        SqlCommand cmd;
        string str = " Data Source=DESKTOP-56FGVUT\\SQLEXPRESS; Initial Catalog=QL_NhaSach_THHCDL ;Integrated Security=True ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public MainTinhTien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ck_SvTr_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_SvTr.Checked == true)
            {
                btn_them.Enabled = false;
                txtMaHoaDon.Visible = true;
                btn_tim.Visible = true;
                btn_return.Visible = true;
                btn_Edit.Visible = true;
            }
            else
            {
                btn_them.Enabled = true;
                txtMaHoaDon.Visible = false;
                btn_tim.Visible = false;
                btn_return.Visible = false;
                btn_Edit.Visible = false;
            }
        }

        private void MainTinhTien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }

        //load hóa Đơn
        void loadHoaDon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select*from HoaDon ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            daGV_HoaDon.DataSource = table;
        }


        //thêm sản Phẩm
        void ThemSanPham()
        {
            Random rand = new Random();
            string kytu = "HD";
            string s = "";
            int temp = 9;
            string number;
            int num = 9;
            number = num.ToString();
            List<int> list = new List<int>();
            for (int i = 0; i <= 8; i++)
            {
                list.Add(i);
                //list.Add(rand.Next(a));
            }
            //random
            for (int i = 0; i <= 8; i++)
            {
                temp = rand.Next(list.Count);
                s += list[temp];
                list.RemoveAt(temp);

            }
            txtMaHoaDon.Text = kytu + s;

            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into HoaDon values('" + txtMaHoaDon.Text + "','002','" + txtMaSP.Text + "','" + txtMaKHang.Text + "',Getdate(),Getdate(),'23000')";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                daGV_HoaDon.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Lỗi Không Tìm Thấy Mã Sản Phẩm hoặc Mã Khách HÀng");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemSanPham();
            LoadTheoMaHoaDon();
        }
        //Load Them Ma Hoa Don
        void LoadTheoMaHoaDon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from HoaDon Where MaHoaDon = '"+ txtMaHoaDon .Text+ " '";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            daGV_HoaDon.DataSource = table;
        }
        private void daGV_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = daGV_HoaDon.CurrentRow.Index;
            txtMaSP.Text = daGV_HoaDon.Rows[i].Cells[0].Value.ToString();
            txtMaKHang.Text = daGV_HoaDon.Rows[i].Cells[3].Value.ToString();
           
        }

        //tìm tên khach hàng
        void TimTenKhachHang()
        {

            cmd = con.CreateCommand();
            cmd.CommandText = "EXECUTE TenKHxuatHD N'"+ txtMaHoaDon .Text+ "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            daGV_HoaDon.DataSource = table;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            TimTenKhachHang();

        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            MainBanSach bs = new MainBanSach();
            bs.Show();
            Hide();
        }
    }
}

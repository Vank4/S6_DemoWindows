using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVe
{
    public partial class FrmThemKhuVuc : Form
    {
        // Thuộc tính để lưu dữ liệu trả về
        //public string TenKhuVuc { get; set; }


        // Khai báo sự kiện
        public event Action<string> TenKhuVuc;

        public FrmThemKhuVuc()
        {
            InitializeComponent();
        }

        public FrmThemKhuVuc(string danhSachKhuVuc)
        {
            InitializeComponent();
            lblKhuVuc.Text = danhSachKhuVuc;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtTenKhuVuc.Text))
            {
                MessageBox.Show("Vui lòng nhap tên khu vực!");
                return;
            }
            if (string.IsNullOrEmpty(txtMaDinhDanh.Text))
            {
                MessageBox.Show("Vui lòng nhap Ma dinh danh khu vực!");
                return;
            }
            // Kiểm tra tên khu vực và mã số định danh khu vực đã tồn tại trong cơ sở dữ liệu hay chưa? 
            using (var dbContext = new S6_QuanLyBanVeEntities())
            {
                // Kiểm tra xem mã định danh hoặc tên khu vực đã tồn tại hay chưa
                bool khuVucTonTai = dbContext.KhuVuc
                    .Any(kv => kv.MaDinhDanh == txtMaDinhDanh.Text || kv.Ten == txtTenKhuVuc.Text);

                if (khuVucTonTai)
                {
                    MessageBox.Show("Khu vực đã tồn tại trong CSDL!");
                    return;
                }
                // Thêm khu vực vào CSDL
                var khuVuc = new KhuVuc
                {
                    Ten = txtTenKhuVuc.Text,
                    MaDinhDanh = txtMaDinhDanh.Text
                };
                dbContext.KhuVuc.Add(khuVuc);
                dbContext.SaveChanges();
            }

            //TenKhuVuc = txtTenKhuVuc.Text;
            // Gọi sự kiện để truyền dữ liệu về FrmMain
            TenKhuVuc?.Invoke(txtTenKhuVuc.Text);
            // txtData là TextBox trên FrmSub
            MessageBox.Show("Thêm thành công!");
            // Đóng form
            //this.Close();
        }
    }
}

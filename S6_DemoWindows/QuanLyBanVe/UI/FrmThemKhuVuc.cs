using QuanLyBanVe.BLL;
using QuanLyBanVe.DAL;
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
        private KhuVucBLL khuVucBLL;

        public object Messagebox { get; private set; }

        // Thuộc tính để lưu dữ liệu trả về
        //public string TenKhuVuc { get; set; }


        // Khai báo sự kiện
        public event Action<string, string> OnTenKhuVucAdded;

        public FrmThemKhuVuc()
        {
            InitializeComponent();
            khuVucBLL = new KhuVucBLL();
            BindGrid();
        }

        public FrmThemKhuVuc(string danhSachKhuVuc)
        {
            InitializeComponent();
            lblKhuVuc.Text = danhSachKhuVuc;

            khuVucBLL = new KhuVucBLL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                khuVucBLL.ThemKhuVuc(txtMaDinhDanh.Text, txtTenKhuVuc.Text);
                MessageBox.Show("Thêm thành công!");
                OnTenKhuVucAdded?.Invoke(txtMaDinhDanh.Text ,txtTenKhuVuc.Text);
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void LoadDanhSachKhuVuc()
        {
            try
            {
                // Lấy danh sách khu vực từ BLL (có thể là từ cơ sở dữ liệu)
                var danhSachKhuVuc = khuVucBLL.LayDanhSachKhuVuc();

                // Tạo DataTable để chứa dữ liệu
                var dt = new DataTable();
                dt.Columns.Add("MaDinhDanh", typeof(string)); // Cột mã định danh
                dt.Columns.Add("TenKhuVuc", typeof(string));  // Cột tên khu vực

                // Duyệt qua danh sách và thêm vào DataTable
                foreach (var khuVuc in danhSachKhuVuc)
                {
                    dt.Rows.Add(khuVuc.MaKhuVuc, khuVuc.TenKhuVuc);
                }

                // Gán DataTable cho DataGridView
                dgvKhuVuc.DataSource = dt;

                // Tuỳ chọn: Thiết lập thuộc tính cho DataGridView (có thể tùy chỉnh)
                dgvKhuVuc.Columns["MaDinhDanh"].HeaderText = "Mã Định Danh";
                dgvKhuVuc.Columns["TenKhuVuc"].HeaderText = "Tên Khu Vực";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có vấn đề xảy ra khi tải danh sách khu vực
                MessageBox.Show("Lỗi khi tải danh sách khu vực: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var db = new S6_QuanLyBanVeEntities();
            var existingKhuVuc = db.KhuVuc.FirstOrDefault(kv => kv.MaDinhDanh == txtMaDinhDanh.Text);
            if(existingKhuVuc != null)
            {
                khuVucBLL.SuaKhuVuc(existingKhuVuc.Ma,txtMaDinhDanh.Text, txtTenKhuVuc.Text);
                BindGrid();
            }
            else
            {
                MessageBox.Show("Khu vực không tồn tại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn khu vực nào chưa
                if (dgvKhuVuc.SelectedRows.Count > 0)
                {
                    // Lấy mã định danh của khu vực được chọn
                    string maDinhDanh = dgvKhuVuc.SelectedRows[0].Cells[1].Value.ToString();

                    // Xác nhận việc xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khu vực này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện xóa trong cơ sở dữ liệu
                        using (var db = new S6_QuanLyBanVeEntities())
                        {
                            // Tìm khu vực theo mã định danh
                            var khuVuc = db.KhuVuc.FirstOrDefault(kv => kv.MaDinhDanh == maDinhDanh);
                            if (khuVuc != null)
                            {
                                db.KhuVuc.Remove(khuVuc);  // Xóa khu vực
                                db.SaveChanges();          // Lưu thay đổi vào CSDL

                                MessageBox.Show("Xóa khu vực thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Khu vực không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Cập nhật lại DataGridView sau khi xóa
                        BindGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khu vực để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmThemKhuVuc_Load(object sender, EventArgs e)
        {
            // Load danh sách khu vực khi mở form
            LoadDanhSachKhuVuc();
            BindGrid();
        }


        private void BindGrid()
        {
            var db = new S6_QuanLyBanVeEntities();
            List<KhuVuc> listKhuVuc = db.KhuVuc.ToList();
            dgvKhuVuc.Rows.Clear();
            foreach (var item in listKhuVuc)
            {
                int index = dgvKhuVuc.Rows.Add();

                dgvKhuVuc.Rows[index].Cells[0].Value = item.MaDinhDanh;
                dgvKhuVuc.Rows[index].Cells[1].Value = item.Ten;
            }
        }

        private void dgvKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Không được chọn dòng thuộc tính!");
            }
            else
            {
                txtMaDinhDanh.Text = dgvKhuVuc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenKhuVuc.Text = dgvKhuVuc.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban có muon thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    
}

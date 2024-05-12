using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLNS_GUI
{
    public partial class FormIsM : Form
    {
        public FormIsM()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void FormIsM_Load(object sender, EventArgs e)
        {

        }
        void LoadForm(Form form)
        {
            
            form.TopLevel = false;
            formDialog.Controls.Clear();
            formDialog.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        
        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham form = new FormSanPham();
            LoadForm(form);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChiNhanh form = new FormChiNhanh();
            LoadForm(form);
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien();
            LoadForm(form);
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap form = new FormNhaCungCap();
            LoadForm(form);
        }

        private void chiTiếtCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCTCungCap form = new FormCTCungCap();
            LoadForm(form);
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            LoadForm(form);
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThanhToan form = new FormThanhToan();
            LoadForm(form);
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSHoaDon form = new FormDSHoaDon();
            LoadForm(form);
        }

        private void hìnhThứcKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHTKhyenMai form = new FormHTKhyenMai();
            LoadForm(form);
        }

        private void danhSáchSảnPhẩmKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSPKhuyenMai form = new FormSPKhuyenMai();
            LoadForm(form);
        }
    }
}

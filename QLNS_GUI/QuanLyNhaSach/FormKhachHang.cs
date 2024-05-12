using QLNS_BUS;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_GUI
{
    public partial class FormKhachHang : Form
    {
        BUS_KhachHang khachHang = new BUS_KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            dataGridView1.DataSource = khachHang.LoadKhachHang();

            txtMa.Text = string.Empty;
            txtMa.ReadOnly = false;
            txtTen.Text = string.Empty;
            txtSDT.Text = string.Empty;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        ET_KhachHang LayKhachHang()
        {
            ET_KhachHang kh = new ET_KhachHang
            {
                MaKH = txtMa.Text,
                TenKH = txtTen.Text,
                SDT = txtSDT.Text,
            };
            return kh;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = LayKhachHang();
                if (khachHang.ThemKhachHang(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo");
                }
            }
            catch (Exception ex) { }
            LoadForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                        if (khachHang.XoaKhachHang(txtMa.Text))
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");

                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng không thành công!", "Thông báo");
                        }
                    }
            }
            catch (Exception ex) { }
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = LayKhachHang();
                if (MessageBox.Show("Bạn có muốn sửa khách hàng này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (khachHang.SuaKhachHang(kh))
                    {
                        MessageBox.Show("Sửa khách hàng thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Sửa khách hàng không thành công!", "Thông báo");
                    }
                }

            }
            catch (Exception ex) { }
            LoadForm();
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}

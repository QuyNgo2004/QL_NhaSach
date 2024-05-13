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
    public partial class FormNhanVien : Form
    {
        BUS_NhanVien nhanVien = new BUS_NhanVien();
        BUS_ChiNhanh chiNhanh = new BUS_ChiNhanh();
        BUS_HoaDon hoaDon= new BUS_HoaDon();
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        BUS_KTLoi kTLoi = new BUS_KTLoi();
        string NV;
        string[] chucNang = new string[2] {"QL","NV"};
        
        public FormNhanVien(string maNV)
        {
            InitializeComponent();
            NV = maNV;
        }
        ET_NhanVien LayNhanVien()
        {
            if (!kTLoi.KTSoDT(txtSDT.Text))
            {
                return null;
            }
            ET_NhanVien nv = new ET_NhanVien
            {
                MaNV = txtMa.Text,
                TenNV = txtTen.Text,
                ChucVu = cboCV.Text,
                NgaySinh = DateTime.Parse(dtpNgaySinh.Text),
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
            };
            nv.MaCN.MaCN = cboCN.SelectedValue.ToString();
            if (rbtNam.Checked)
            {
                nv.GioiTinh = rbtNam.Text;
            }
            else
            {
                nv.GioiTinh = rbtNu.Text;
            }
            return nv;
        }
        void LoadForm()
        {
            /*foreach (string i in chucNang)
            {
                cboCV.Items.Add(i.ToString());
            }*/
            cboCV.DataSource = chucNang;
            cboCN.DataSource = chiNhanh.LoadChiNhanh();
            cboCN.DisplayMember = "tenCN";
            cboCN.ValueMember = "maCN";
            dataGridView1.DataSource = nhanVien.LoadNhanVien();

            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;

            txtMa.ReadOnly = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NhanVien nv = LayNhanVien();
                if (nv != null && nhanVien.ThemNhanVien(nv) && tk.ThemTK(txtMa.Text))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!", "Thông báo");
                }
                LoadSP(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ( NV != txtMa.Text && tk.XoaTK(txtMa.Text) && hoaDon.XoaHDNV(new ET_HoaDon { MaNV = new ET_NhanVien {MaNV = txtMa.Text} }) && nhanVien.XoaNhanVien(txtMa.Text)   )
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                ET_NhanVien nv = LayNhanVien();
                if (MessageBox.Show("Bạn có muốn sửa nhân viên này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nv != null && nhanVien.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa nhân viên thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên không thành công!", "Thông báo");
                    }
                }
                LoadSP(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSP(object sender, EventArgs e)
        {
            LoadForm();
        }

        
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            int row = dataGridView1.CurrentCell.RowIndex;
            txtMa.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            if(dataGridView1.Rows[row].Cells[6].Value.ToString() == "Nam")
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

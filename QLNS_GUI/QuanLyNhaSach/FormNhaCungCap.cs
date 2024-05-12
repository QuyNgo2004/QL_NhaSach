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
    public partial class FormNhaCungCap : Form
    {
        BUS_NhaCungCap nhaCungCap = new BUS_NhaCungCap();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

       void LoadForm()
        {
            dataGridView1.DataSource = nhaCungCap.LoadNhaCC();


            txtMa.Text = string.Empty;
            txtMa.ReadOnly = false;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NhaCC ncc = new ET_NhaCC
                {
                    MaNCC = txtMa.Text,
                    TenNCC = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    GhiChu = txtGhiChu.Text,
                };
                if (nhaCungCap.ThemNhaCC(ncc))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công!", "Thông báo");
                }
            }
            catch (Exception ex) { }
            LoadForm();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.Rows.Count > 2)
                    {
                        if (nhaCungCap.XoaNhaCC(txtMa.Text))
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo");

                        }
                        else
                        {
                            MessageBox.Show("Xóa nhà cung cấp không thành công!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp có tối thiểu là 1!", "Thông báo");

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
                ET_NhaCC ncc = new ET_NhaCC
                {
                    MaNCC = txtMa.Text,
                    TenNCC = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    GhiChu = txtGhiChu.Text,
                };
                if (MessageBox.Show("Bạn có muốn sửa nhà cung cấp này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nhaCungCap.SuaNhaCC(ncc))
                    {
                        MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Sửa nhà cung cấp không thành công!", "Thông báo");
                    }
                }

            }
            catch (Exception ex) { }
            LoadForm();
            
        }

       
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

                txtMa.ReadOnly = true;
                int row = dataGridView1.CurrentCell.RowIndex;
                txtMa.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                txtGhiChu.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();

                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}

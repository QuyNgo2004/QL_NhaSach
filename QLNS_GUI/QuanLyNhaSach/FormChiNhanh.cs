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
    public partial class FormChiNhanh : Form
    {
        BUS_ChiNhanh chiNhanh = new BUS_ChiNhanh();
        public FormChiNhanh()
        {
            InitializeComponent();
        }
        void LoadForm(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chiNhanh.LoadChiNhanh();

            txtMa.Text = string.Empty;
            txtMa.ReadOnly = false;
            txtTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;

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
                ET_ChiNhanh cn = new ET_ChiNhanh
                {
                    MaCN = txtMa.Text,
                    TenCN = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                };
                if (chiNhanh.ThemChiNhanh(cn))
                {
                    MessageBox.Show("Thêm chi nhánh thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm chi nhánh không thành công!", "Thông báo");
                }
            }
            catch(Exception ex) { }
            LoadForm(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa chi nhánh này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(dataGridView1.Rows.Count > 2)
                    {
                        if (chiNhanh.XoaChiNhanh(txtMa.Text))
                        {
                            MessageBox.Show("Xóa chi nhánh thành công!", "Thông báo");

                        }
                        else
                        {
                            MessageBox.Show("Xóa chi nhánh không thành công!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chi nhánh có tối thiểu là 1!", "Thông báo");

                    }

                }
               
            }
            catch (Exception ex) { }
            LoadForm(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChiNhanh cn = new ET_ChiNhanh
                {
                    MaCN = txtMa.Text,
                    TenCN = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                };
                if (MessageBox.Show("Bạn có muốn sửa chi nhánh này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (chiNhanh.SuaChiNhanh(cn))
                    {
                        MessageBox.Show("Sửa chi nhánh thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Sửa chi nhánh không thành công!", "Thông báo");
                    }
                }
               
            }
            catch (Exception ex) { }
            LoadForm(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        

        private void FormChiNhanh_Load(object sender, EventArgs e)
        {
            LoadForm(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            int row = dataGridView1.CurrentCell.RowIndex;
            txtMa.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
    }
}

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
    public partial class FormHTKhyenMai : Form
    {
        BUS_HTKhyenMai hTKhuyenMai = new BUS_HTKhyenMai(); 
        BUS_KTLoi kTLoi = new BUS_KTLoi();
        public FormHTKhyenMai()
        {
            InitializeComponent();
        }
        ET_KhuyenMai layKM()
        {
            if (!kTLoi.KTSo(txtGiamGia.Text))
            {
                return null;
            }
            ET_KhuyenMai km = new ET_KhuyenMai
            {
                MaKM = txtMa.Text,
                TenKM = txtTen.Text,
                GiamGia = int.Parse(txtGiamGia.Text),

            };
            return km;
        }
        void LoadForm()
        {
            dataGridView1.DataSource = hTKhuyenMai.LoadKhuyenMai();

            txtMa.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGiamGia.Text = string.Empty;

            txtMa.ReadOnly = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        

        private void FormHTKhyenMai_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhuyenMai km = layKM();
                if (km != null && hTKhuyenMai.ThemKhuyenMai(km))
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm  khuyến mãi không thành công!", "Thông báo");
                }
            }
            catch (Exception ex) { }
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
                txtGiamGia.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
               

                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khuyến mãi này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dataGridView1.Rows.Count > 1)
                    {
                        if (hTKhuyenMai.XoaKhuyenMai(new ET_KhuyenMai { MaKM = txtMa.Text}))
                        {
                            MessageBox.Show("Xóa khuyến mãi thành công!", "Thông báo");

                        }
                        else
                        {
                            MessageBox.Show("Xóa khuyến mãi không thành công!", "Thông báo");
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
                ET_KhuyenMai km = layKM();
                
                if (MessageBox.Show("Bạn có muốn sửa khuyến mãi này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (km != null && hTKhuyenMai.SuaKhuyenMai(km))
                    {
                        MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Sửa khuyến mãi không thành công!", "Thông báo");
                    }
                }

            }
            catch (Exception ex) { }
            LoadForm();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}

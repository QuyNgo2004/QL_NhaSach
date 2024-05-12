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
    public partial class FormCTCungCap : Form
    {
        BUS_SanPham sp = new BUS_SanPham();
        BUS_CTNhaCungCapSP ctsp = new BUS_CTNhaCungCapSP();
        BUS_NhaCungCap ncc = new BUS_NhaCungCap();

        public FormCTCungCap()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            cboNCC.DataSource = ncc.LoadNhaCC();
            cboNCC.DisplayMember = "tenNCC";
            cboNCC.ValueMember = "maNCC";


            dgvSP.DataSource = sp.LoadSP();
            dgvCTCungCap.DataSource = ctsp.LoadDSSPTheoNCC();
            this.dgvCTCungCap.Columns["MaCT"].Visible = false;
            this.dgvCTCungCap.Columns["MaSP"].Visible = false;

            txtMa.Text = string.Empty;
            txtMa.ReadOnly = false;
            txtSL.Text = string.Empty;
            txtGhiChu.Text = string.Empty;

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCTCungCap_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtMa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSP.DataSource = sp.TimMaSP(int.Parse(txtMa.Text));
            }catch(Exception ex) { }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                ET_CTNhaCC cc = new ET_CTNhaCC
                {
                    NgayCC = DateTime.Parse(dtpNgayCC.Text),
                    SL = int.Parse(txtSL.Text),
                    GhiChu = txtGhiChu.Text
                };
                cc.MaSP.MaSP = int.Parse(dgvSP.Rows[0].Cells[0].Value.ToString());
                cc.MaSP.TenSP = dgvSP.Rows[0].Cells[1].Value.ToString();
                cc.MaNCC.MaNCC = cboNCC.SelectedValue.ToString();
                cc.MaNCC.TenNCC = dgvSP.Rows[0].Cells[2].Value.ToString();
                if (ctsp.ThemSPCC(cc))
                {
                    MessageBox.Show("Thêm sản phẩm được cung cấp thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm được cung cấp không thành công!", "Thông báo");
                }
                LoadForm();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm cung cấp này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ctsp.XoaSPCC(new ET_CTNhaCC { MaCTNhaCC = int.Parse(txtMaCC.Text),SL = int.Parse(txtSL.Text) }))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm không thành công!", "Thông báo");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadForm();
        }

        private void dgvCTCungCap_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            int row = dgvCTCungCap.CurrentCell.RowIndex;
            txtMa.Text = dgvCTCungCap.Rows[row].Cells[6].Value.ToString();
            txtSL.Text = dgvCTCungCap.Rows[row].Cells[2].Value.ToString();
            txtGhiChu.Text = dgvCTCungCap.Rows[row].Cells[5].Value.ToString();
            txtMaCC.Text = dgvCTCungCap.Rows[row].Cells[0].Value.ToString();

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            int row = dgvCTCungCap.CurrentCell.RowIndex;
            txtMa.Text = dgvSP.Rows[row].Cells[0].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

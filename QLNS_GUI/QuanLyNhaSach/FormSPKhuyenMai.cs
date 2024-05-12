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
    public partial class FormSPKhuyenMai : Form
    {
        BUS_HTKhyenMai htKhuyenMai = new BUS_HTKhyenMai();
        BUS_ChiTietKhuyenMai ctKhyenMai = new BUS_ChiTietKhuyenMai();
        BUS_SanPham dsSanPham = new BUS_SanPham();

        public FormSPKhuyenMai()
        {
            InitializeComponent();
        }
        void LoadForm()
        {
            dgvSP.DataSource = dsSanPham.LoadSP();
            dgvSPKM.DataSource = ctKhyenMai.LoadCTKM();

            cboHTKM.DataSource = htKhuyenMai.LoadKhuyenMai();
            cboHTKM.DisplayMember = "TênKM";
            cboHTKM.ValueMember = "MãKM";

            this.dgvSPKM.Columns["MãCT"].Visible = false;
            this.dgvSPKM.Columns["MãSP"].Visible = false;
            txtMa.Text = string.Empty;
            txtMa.ReadOnly = false;
            txtMaCTKM.Text = string.Empty;

            btnXoa.Enabled = false;
            btnThem.Enabled = true;

        }
        //Kiem tra trung thoi gian
        bool IsOverlap((DateTime, DateTime) range1, (DateTime, DateTime) range2)
        {
            // Kiểm tra nếu khoảng thời gian range1 chồng lên range2 hoặc ngược lại
            if (range1.Item1 <= range2.Item1 && range2.Item1 <= range1.Item2) {
                return true; }
            else if(range1.Item1 <= range2.Item2 && range2.Item2 <= range1.Item2)
            {
                return true;
            }
            return false;
        }
        ET_CTKhuyenMai CTKM()
        {

            if (dtpNgayBD.Value >= dtpNgayKT.Value)
            {
                return null;
            }
            
            ET_CTKhuyenMai ct = new ET_CTKhuyenMai();
            try
            {
                ct.NgayBD = DateTime.Parse(dtpNgayBD.Value.ToString("d"));
                ct.NgayKT = DateTime.Parse(dtpNgayKT.Value.ToString("d"));
                ct.MaKM.MaKM = cboHTKM.SelectedValue.ToString();
                ct.MaSP.MaSP = int.Parse(txtMa.Text);
                ct.MaSP.TenSP = dgvSP.Rows[0].Cells[0].Value.ToString();
            } catch(Exception ex) {
                MessageBox.Show("Lỗi tạo đối tượng!");
            }
            for(int i = 0; i < dgvSPKM.Rows.Count; i++)
            {
                if(ct.MaSP.MaSP == int.Parse(dgvSPKM.Rows[i].Cells[0].Value.ToString()))
                {
                    DateTime bd = DateTime.Parse(dgvSPKM.Rows[i].Cells[4].Value.ToString());
                    DateTime kt = DateTime.Parse(dgvSPKM.Rows[i].Cells[5].Value.ToString());
                    if (IsOverlap((bd, kt), (ct.NgayBD, ct.NgayKT))){
                        return null;
                    }
                    
                }
            }
            return ct;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa khuyến mãi sản phẩm  này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ctKhyenMai.XoaCTKM(new ET_CTKhuyenMai { MaCTKM = int.Parse(txtMaCTKM.Text) }))
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

        private void FormSPKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dgvSP_Click(object sender, EventArgs e)
        {
            int row = dgvSP.CurrentCell.RowIndex;
            txtMa.Text = dgvSP.Rows[row].Cells[0].Value.ToString();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSP.DataSource = dsSanPham.TimMaSP(int.Parse(txtMa.Text));
            }
            catch (Exception ex) { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                ET_CTKhuyenMai ct = CTKM();
                if(ct == null)
                {
                    MessageBox.Show("Cập nhật lại thời gian!");
                }
                else
                {
                    if (ctKhyenMai.ThemCTKM(ct))
                    {
                        MessageBox.Show("Thêm sản phẩm được thêm khuyến mãi thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm được thêm khuyến mãi không thành công!", "Thông báo");
                    }
                }
                
                LoadForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSPKM_Click(object sender, EventArgs e)
        {
            int row = dgvSPKM.CurrentCell.RowIndex;
            txtMaCTKM.Text = dgvSPKM.Rows[row].Cells[0].Value.ToString();
            txtMa.Text = dgvSPKM.Rows[row].Cells[1].Value.ToString();
            dtpNgayBD.Value = DateTime.Parse(dgvSPKM.Rows[row].Cells[4].Value.ToString());
            dtpNgayKT.Value = DateTime.Parse(dgvSPKM.Rows[row].Cells[5].Value.ToString());

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            txtMa.ReadOnly = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}

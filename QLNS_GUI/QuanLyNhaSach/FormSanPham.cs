using DevExpress.XtraEditors;
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
    public partial class FormSanPham : Form
    {
        BUS_DanhMuc danhMuc = new BUS_DanhMuc();
        BUS_TheLoai theLoai = new BUS_TheLoai();
        BUS_DonVi donVi = new BUS_DonVi();
        BUS_SanPham sanPham = new BUS_SanPham();
        BUS_NhaCungCap nhaCungCap = new BUS_NhaCungCap();
        BUS_CTNhaCungCapSP ctNCC = new BUS_CTNhaCungCapSP();
        public FormSanPham()
        {
            InitializeComponent();
        }
        // Load trang
        void LoadSP(object sender, EventArgs e)
        {
            cboNCC.DataSource = nhaCungCap.LoadNhaCC();
            cboNCC.DisplayMember = "tenNCC";
            cboNCC.ValueMember = "maNCC";

            cboDanhMuc.DataSource = danhMuc.LoadDSDanhMuc();
            cboDanhMuc.DisplayMember = "tenDM";
            cboDanhMuc.ValueMember = "maDM";

            
            dataGridView1.DataSource = sanPham.LoadSP();



            cboDanhMuc_SelectedIndexChanged(sender, e);
            txtMa.Text = string.Empty;
            txtMa.ReadOnly = false;
            txtTenSP.Text = string.Empty;
            txtGiaSP.Text = "0";
            

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void FormSanPham_Load(object sender, EventArgs e)
        {
           LoadSP(sender, e);
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát trang này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
           cboTheLoai.DataSource = theLoai.LoadDSTheLoaiDM(cboDanhMuc.SelectedValue.ToString());
           cboTheLoai.DisplayMember = "TênTL";
           cboTheLoai.ValueMember = "MãTL";

            cboDV.DataSource = donVi.LoadDonViTheoDM(cboDanhMuc.SelectedValue.ToString());
            cboDV.DisplayMember = "ĐơnVị";
            cboDV.ValueMember = "MãDV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_SanPham sp = new ET_SanPham(); 
            sp.MaSP = int.Parse(txtMa.Text); ;
            sp.TenSP = txtTenSP.Text;
            sp.MaNCC.MaNCC = cboNCC.SelectedValue.ToString();
            sp.MaTL.MaTL = cboTheLoai.SelectedValue.ToString();
            sp.MaDV.MaDV = int.Parse(cboDV.SelectedValue.ToString());
            sp.GiaSP = int.Parse(txtGiaSP.Text);
            sp.TKem = 1;
                
            if (sanPham.ThemSP(sp))
            {
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");

            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công!", "Thông báo");
            }
            LoadSP(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            int row = dataGridView1.CurrentCell.RowIndex;
            txtMa.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            txtGiaSP.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa sản phẩm này không!", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctNCC.XoaSPCCMASP(int.Parse(txtMa.Text));
                    if (sanPham.XoaSP(int.Parse(txtMa.Text)))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa sản phẩm không thành công!", "Thông báo");
                    }
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadSP(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_SanPham sp = new ET_SanPham();
                sp.MaSP = int.Parse(txtMa.Text); ;
                sp.TenSP = txtTenSP.Text;
                sp.MaNCC.MaNCC = cboNCC.SelectedValue.ToString();
                sp.MaTL.MaTL = cboTheLoai.SelectedValue.ToString();
                sp.MaDV.MaDV = int.Parse(cboDV.SelectedValue.ToString());
                sp.GiaSP = int.Parse(txtGiaSP.Text);
               
                if (MessageBox.Show("Bạn có muốn sửa sản phẩm này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sanPham.SuaSP(sp))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo");

                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm không thành công!", "Thông báo");
                    }
                }
                LoadSP(sender, e);
            }catch (Exception ex)
            {

            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

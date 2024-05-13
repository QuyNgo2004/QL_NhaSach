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
    public partial class FormThanhToan : Form
    {
        List<ET_CTHoaDon> dsSanPham;
        BUS_SanPham sp = new BUS_SanPham();
        BUS_ChiTietKhuyenMai ctKM = new BUS_ChiTietKhuyenMai();
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_HoaDon hoaDon = new BUS_HoaDon();
        BUS_CTHoaDon cTHoaDon = new BUS_CTHoaDon();
        BUS_KTLoi kTLoi = new BUS_KTLoi();
        
        public FormThanhToan(string maNV)
        {
            InitializeComponent();
            txtMaNV.Text = maNV;
        }
        bool KiemTraSP(string maSP)
        {
            for (int i = 0;i<dgvSPHD.Rows.Count;i++)
            {
                if(dgvSPHD.Rows[i].Cells[3].Value.ToString() == maSP)
                {
                    return false;
                }
            }
            return true;
        }
        void ResetDgvCTHD()
        {
            dgvSPHD.Rows.Clear();
            foreach (ET_CTHoaDon ctHD in  dsSanPham) {
                dgvSPHD.Rows.Add(dgvSPHD.RowCount++, ctHD.MaSP.TenSP, ctHD.SLuong, ctHD.TTien);
            }
        }
        int  TTien()
        {
            return int.Parse(dgvSP.Rows[0].Cells[4].Value.ToString());
        }
        void LoadForm()
        {
            //ResetDgvCTHD();
            dgvSP.DataSource = sp.LoadSP();
            cboKM.SelectedIndex = -1;

            txtMa.Text =string.Empty;
            txtMaCTHD.Text =string.Empty;
            txtSL.Text = "1";

            
        }
       
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
           
            dgvSPHD.Columns.Add("Tên SP", "Tên SP");
            dgvSPHD.Columns.Add("Số lượng", "Số lượng");
            dgvSPHD.Columns.Add("Thành tiền", "Thành tiền");
            dgvSPHD.Columns.Add("Mã SP", "Mã SP");
            this.dgvSPHD.Columns["Mã SP"].Visible = false;
            dsSanPham = new List<ET_CTHoaDon>();
            LoadForm();
            cboKhachHang.DataSource = kh.LoadKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.SelectedIndex = -1;
            dgvSPHD.Rows.Clear();
            txtGia.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSP.DataSource = sp.TimMaSP(int.Parse(txtMa.Text));
                if (ctKM.LoadCTKM(int.Parse(txtMa.Text)) != null)
                {
                    cboKM.DataSource = ctKM.LoadCTKM(int.Parse(txtMa.Text));
                    cboKM.DisplayMember = "TenKM";
                    cboKM.ValueMember = "GiamGia";
                }
                 
            }
            catch (Exception ex) { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if ( txtSL.Text == string.Empty || !kTLoi.KTSo(txtSL.Text) || int.Parse(txtSL.Text) < 0 )
                {
                    MessageBox.Show("Vui lòng nhập số lượng và số lượng lớn hơn 1,");
                    txtSL.Text = "1";
                    return;
                }
                if(int.Parse(dgvSP.Rows[0].Cells[6].Value.ToString()) - int.Parse(txtSL.Text) < 0)
                {
                    MessageBox.Show("Sản phẩm trong kho không đủ!");
                    return;
                }
                if (!KiemTraSP(txtMa.Text))
                {
                    MessageBox.Show("Trùng sản phẩm đã có trong danh sách");
                    txtMa.Text = string.Empty;
                    return;
                }
            

                ET_CTHoaDon ct = new ET_CTHoaDon();
                ct.MaSP.MaSP = int.Parse(dgvSP.Rows[0].Cells[0].Value.ToString());
                ct.MaSP.TenSP = dgvSP.Rows[0].Cells[1].Value.ToString();
                ct.SLuong = int.Parse(txtSL.Text);
                
                ct.TTien = TTien() * ct.SLuong;
                if (cboKM.SelectedItem != null)
                {
                    ct.TTien -= ct.TTien * int.Parse(cboKM.Text) / 100;
                };
                dgvSPHD.Rows.Add( ct.MaSP.TenSP, ct.SLuong, ct.TTien, ct.MaSP.MaSP);
                float TongHD =0;
                for (int i = 0; i < dgvSPHD.Rows.Count; i++)
                {
                    TongHD += float.Parse(dgvSPHD.Rows[i].Cells[2].Value.ToString());
                }
                txtGia.Text = TongHD.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi thêm sản phẩm vào giỏ hàng!");
            }
            LoadForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm();
            dgvSPHD.Rows.Clear();
            txtGia.Text = "0";
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm trong hóa đơn này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int dong = dgvSPHD.CurrentCell.RowIndex;
                    dgvSPHD.Rows.RemoveAt(dong);
                    MessageBox.Show("Xóa sản phẩm trong hóa đơn thành công!", "Thông báo");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa sản phẩm trong hóa đơn không thành công!", "Thông báo");
            }
            LoadForm();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thanh toán không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ET_HoaDon hd = new ET_HoaDon();
                    hoaDon.ThemHD(hd);
                    hd.MaNV.MaNV = txtMaNV.Text;
                    hd.MaHD = int.Parse(hoaDon.LayMaHoaDonMoiTao().ToString());
                    if (cboKhachHang.SelectedItem != null)
                    {
                        hd.MaKH.MaKH = cboKhachHang.SelectedValue.ToString();
                    }
                
                    //Them chi tiet san phẩm
                    for (int i = 0;i < dgvSPHD.Rows.Count; i++)
                    {
                        ET_CTHoaDon ct = new ET_CTHoaDon();
                        ct.MaHD.MaHD = hd.MaHD;
                        ct.MaSP.MaSP = int.Parse(dgvSPHD.Rows[i].Cells[3].Value.ToString());
                        ct.SLuong = int.Parse(dgvSPHD.Rows[i].Cells[1].Value.ToString());
                        ct.MaSP.TenSP = dgvSPHD.Rows[i].Cells[0].Value.ToString();
                        ct.TTien = float.Parse(dgvSPHD.Rows[i].Cells[2].Value.ToString());
                        if (!sp.SuaSLSoLuong(ct.SLuong, ct.MaSP.MaSP))
                        {
                            MessageBox.Show("Lỗi số lượng sản phẩm vào hóa đơn!");
                        }
                        if (!cTHoaDon.ThemCTHD(ct))
                        {
                            MessageBox.Show("Lỗi thêm sản phẩm vào hóa đơn!");
                        }
                    }
                    
                    //MessageBox.Show(hoaDon.LayMaHoaDonMoiTao().ToString());
                    hd.TongHD = float.Parse(txtGia.Text);
               
                    if (hoaDon.SuaHD(hd))
                    {
                        MessageBox.Show("Thanh toán thành công!", "Thông báo");
                        dgvSPHD.Rows.Clear();
                        FormInHD inHoaDon = new FormInHD(hd.MaHD);
                        inHoaDon.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán không thành công!", "Thông báo");
                    }
                }
                

            }
            catch (Exception ex) { }
        }
    }
}

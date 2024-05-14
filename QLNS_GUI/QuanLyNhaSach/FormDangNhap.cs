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
    public partial class FormDangNhap : Form
    {
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        BUS_NhanVien nhanVien = new BUS_NhanVien();
        public ET_NhanVien nv = new ET_NhanVien();
        public FormDangNhap()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tk.KTTaiKhoan((txtTDN.Text, txtMK.Text)) != null)
                {
                    nv = nhanVien.TimNhanVien(tk.KTTaiKhoan((txtTDN.Text, txtMK.Text)));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu !");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }catch(Exception ex) { }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

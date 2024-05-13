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
    public partial class FormDoiMatKhau : Form
    {
        BUS_TaiKhoan tk =new BUS_TaiKhoan();
        public FormDoiMatKhau(string maNV)
        {
            InitializeComponent();
            txtTDN.Text = maNV;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (MessageBox.Show("Bạn có muốn đổi mật khẩu này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtMK.Text == txtMK.Text && txtMK.Text != string.Empty)
                    {
                        if (tk.SuaTK(txtTDN.Text, txtMK.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            this.Close();
                        }
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show("Đổi mật khẩu không thành công!"); }
        }
    }
}

using QLNS_BUS;
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
    public partial class FormServe : Form
    {
        BUS_Data data = new BUS_Data();
        public FormServe()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void FormServe_Load(object sender, EventArgs e)
        {
            if (data.LoadData() == true)
            {
                FormIsM frm = new FormIsM();
                frm.ShowDialog();
                this.Close();
            }

        }

        private void btnThem_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            if (data.LoadData() == false)
            {
                data.SaveData(txtServe.Text);
                FormServe_Load(sender, e);
            }
            else
            {
                FormIsM frm = new FormIsM();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            data.SaveData(txtServe.Text);
            if (data.LoadData() == false)
            {
                data.SaveData(txtServe.Text);
                FormServe_Load(sender, e);
                MessageBox.Show("Lỗi đăng nhập serve!");
            }
            else
            {
                FormIsM frm = new FormIsM();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}

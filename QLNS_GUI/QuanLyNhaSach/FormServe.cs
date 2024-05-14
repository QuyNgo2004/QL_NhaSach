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
            string path = System.IO.Path.Combine(Application.StartupPath);
            if (data.LoadData(path) == true)
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
            
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO.Path.Combine(Application.StartupPath);
                data.SaveData(txtServe.Text, path);
                if (data.LoadData(path) == false)
                {
                    data.SaveData(txtServe.Text, path);
                    FormServe_Load(sender, e);
                    MessageBox.Show("Lỗi đăng nhập serve!");
                }
                else
                {
                    FormIsM frm = new FormIsM();
                    frm.ShowDialog();
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

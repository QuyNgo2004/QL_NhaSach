using QLNS_BUS;
using QLNS_ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        BUS_DanhMuc dsDanhMuc = new BUS_DanhMuc();
        BUS_TheLoai dsTheLoai = new BUS_TheLoai();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
        void LoadDS()
        {
            dataGridView1.DataSource = dsTheLoai.LoadDSTheLoai();
            comboBox1.DataSource = dsDanhMuc.LoadDSDanhMuc();
            this.dataGridView1.Columns["maDM"].Visible = false;
            comboBox1.ValueMember = "maDM";
            comboBox1.DisplayMember = "tenDM";
        }
        private void checkButton1_Click(object sender, EventArgs e)
        {
            ET_DanhMuc dm = new ET_DanhMuc {
                MaDM = textEdit1.Text,
                TenDM = textEdit2.Text,
                GhiChu = textEdit3.Text
            };
            dsDanhMuc.SuaDanhMuc(dm);
            LoadDS();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

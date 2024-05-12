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
    public partial class FormDSHoaDon : Form
    {
        BUS_HoaDon hoaDon = new BUS_HoaDon();
        BUS_CTHoaDon cTHoaDon = new BUS_CTHoaDon();
        public FormDSHoaDon()
        {
            InitializeComponent();
        }
        void LoadDSHD()
        {
            dgvDSHD.DataSource = hoaDon.LoadHD(dtpNgay.Value.Date);
            dgvDSSP.Rows.Clear();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSHD();
        }

        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            int dong = dgvDSHD.CurrentCell.RowIndex;
            dgvDSSP.DataSource = cTHoaDon.LoadCTHD(int.Parse(dgvDSHD.Rows[dong].Cells[0].Value.ToString()));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSHD();
        }
    }
}

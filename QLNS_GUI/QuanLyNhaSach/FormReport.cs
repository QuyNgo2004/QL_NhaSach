using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormReport : Form
    {
        string tenNV;
        string[] dsReport = new string[1] {"Danh sách hóa đơn theo tháng" };
        string[] dsThang = new string[12] {"1","2","3","4","5","6","7","8","9","10","11","12" };
        public FormReport(string tenNV)
        {
            InitializeComponent();
            this.tenNV = tenNV;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                cboReport.DataSource = dsReport;
                cboThang.DataSource = dsThang;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboReport.SelectedItem.ToString() == "Danh sách hóa đơn theo tháng")
            {
                try
                {
                    ReportDocument reportDocument = new ReportDocument();
                    // Lay duong dan tuyet doi

                    string relativePath = System.IO.Path.Combine(Application.StartupPath);
                    relativePath = relativePath.Replace(@"bin\Debug", "");
                    //MessageBox.Show(relativePath.ToString());
                    // Load file Crystal Report (.rpt)
                    reportDocument.Load(relativePath + @"\Report\HoaDonTheoThang.rpt");


                    // Set giá trị cho các tham số
                    reportDocument.SetParameterValue("@Thang", int.Parse(cboThang.Text));
                    reportDocument.SetParameterValue("@TenNV", tenNV.ToString());
                    // reportDocument.SetParameterValues("ArrayParameterName", arrayOfValues);


                    // Hiển thị hoặc in Crystal Report


                    rptBaoCao.ReportSource = reportDocument;
                    rptBaoCao.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể load report!");
                }
            }
        }
    }
}

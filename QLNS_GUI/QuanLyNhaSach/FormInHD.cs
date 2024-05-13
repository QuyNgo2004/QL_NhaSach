using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DevExpress.Xpo.DB;
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
    public partial class FormInHD : Form
    {
        int maHD;
        public FormInHD(int maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument reportDocument = new ReportDocument();
                // Lay duong dan tuyet doi

                string relativePath = System.IO.Path.Combine(Application.StartupPath);
                //relativePath = relativePath.Replace(@"bin\Debug", "");
               // MessageBox.Show(relativePath.ToString());
                // Load file Crystal Report (.rpt)
                reportDocument.Load(relativePath  + @"\Report\HoaDonRPT.rpt");

            
                // Set giá trị cho các tham số
                reportDocument.SetParameterValue("@MAHD", maHD);

                // Nếu bạn có nhiều giá trị cho một tham số kiểu mảng (array)
                // reportDocument.SetParameterValues("ArrayParameterName", arrayOfValues);

               
                // Hiển thị hoặc in Crystal Report

                
                rptInHoaDon.ReportSource = reportDocument;
                rptInHoaDon.Refresh();
            }catch (Exception ex)
            {
                MessageBox.Show("Không thể load report!");
            }
        }

        private void rptInHoaDon_SizeChanged(object sender, EventArgs e)
        {

            rptInHoaDon.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 20);
        }

        private void FormInHD_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace QLNS_GUI
{
    partial class FormInHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rptInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rptInHoaDon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1043, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // rptInHoaDon
            // 
            this.rptInHoaDon.ActiveViewIndex = -1;
            this.rptInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptInHoaDon.Location = new System.Drawing.Point(2, 2);
            this.rptInHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rptInHoaDon.Name = "rptInHoaDon";
            this.rptInHoaDon.Size = new System.Drawing.Size(1039, 446);
            this.rptInHoaDon.TabIndex = 0;
            this.rptInHoaDon.ToolPanelWidth = 250;
            this.rptInHoaDon.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            this.rptInHoaDon.SizeChanged += new System.EventHandler(this.rptInHoaDon_SizeChanged);
            // 
            // FormInHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormInHD";
            this.Text = "FormInHD";
            this.Load += new System.EventHandler(this.FormInHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptInHoaDon;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
       
    }
}
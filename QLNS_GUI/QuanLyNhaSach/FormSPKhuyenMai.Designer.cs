namespace QLNS_GUI
{
    partial class FormSPKhuyenMai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSPKM = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.cboHTKM = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaCTKM = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPKM)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCTKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvSPKM);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 597);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khuyến mãi:";
            // 
            // dgvSPKM
            // 
            this.dgvSPKM.AllowUserToAddRows = false;
            this.dgvSPKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSPKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSPKM.Location = new System.Drawing.Point(3, 18);
            this.dgvSPKM.Name = "dgvSPKM";
            this.dgvSPKM.RowHeadersWidth = 51;
            this.dgvSPKM.RowTemplate.Height = 24;
            this.dgvSPKM.Size = new System.Drawing.Size(372, 576);
            this.dgvSPKM.TabIndex = 0;
            this.dgvSPKM.Click += new System.EventHandler(this.dgvSPKM_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dtpNgayKT);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.dtpNgayBD);
            this.panel1.Controls.Add(this.cboHTKM);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtMaCTKM);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Location = new System.Drawing.Point(397, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 597);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSP);
            this.groupBox2.Location = new System.Drawing.Point(6, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 219);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm:";
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.Location = new System.Drawing.Point(3, 18);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(582, 198);
            this.dgvSP.TabIndex = 0;
            this.dgvSP.Click += new System.EventHandler(this.dgvSP_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(188, 286);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(151, 22);
            this.dtpNgayKT.TabIndex = 60;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 286);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 16);
            this.labelControl6.TabIndex = 59;
            this.labelControl6.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(188, 232);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(151, 22);
            this.dtpNgayBD.TabIndex = 58;
            // 
            // cboHTKM
            // 
            this.cboHTKM.FormattingEnabled = true;
            this.cboHTKM.Location = new System.Drawing.Point(188, 130);
            this.cboHTKM.Name = "cboHTKM";
            this.cboHTKM.Size = new System.Drawing.Size(266, 24);
            this.cboHTKM.TabIndex = 57;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(230, 340);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 23);
            this.btnLoad.TabIndex = 53;
            this.btnLoad.Text = "Làm Mới";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 238);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 16);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Ngày bắt đầu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 16);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Hình thức khuyến mãi:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(140, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 23);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 340);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 23);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "Mã sản phẩm :";
            // 
            // txtMaCTKM
            // 
            this.txtMaCTKM.Location = new System.Drawing.Point(483, 182);
            this.txtMaCTKM.Name = "txtMaCTKM";
            this.txtMaCTKM.Size = new System.Drawing.Size(54, 22);
            this.txtMaCTKM.TabIndex = 46;
            this.txtMaCTKM.Visible = false;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(188, 181);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(270, 22);
            this.txtMa.TabIndex = 47;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // FormSPKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSPKhuyenMai";
            this.Text = "FormSPKhuyenMai";
            this.Load += new System.EventHandler(this.FormSPKhuyenMai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPKM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCTKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSPKM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.ComboBox cboHTKM;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaCTKM;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSP;
    }
}
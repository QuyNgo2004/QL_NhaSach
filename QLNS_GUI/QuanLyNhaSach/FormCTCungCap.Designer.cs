namespace QLNS_GUI
{
    partial class FormCTCungCap
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
            this.dgvCTCungCap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgayCC = new System.Windows.Forms.DateTimePicker();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCC = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCungCap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCTCungCap);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 644);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm được cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvCTCungCap
            // 
            this.dgvCTCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTCungCap.Location = new System.Drawing.Point(3, 18);
            this.dgvCTCungCap.Name = "dgvCTCungCap";
            this.dgvCTCungCap.RowHeadersWidth = 51;
            this.dgvCTCungCap.RowTemplate.Height = 24;
            this.dgvCTCungCap.Size = new System.Drawing.Size(502, 623);
            this.dgvCTCungCap.TabIndex = 0;
            this.dgvCTCungCap.Click += new System.EventHandler(this.dgvCTCungCap_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(512, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 641);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNgayCC);
            this.panel2.Controls.Add(this.cboNCC);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.txtMaCC);
            this.panel2.Controls.Add(this.txtMa);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 390);
            this.panel2.TabIndex = 32;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtpNgayCC
            // 
            this.dtpNgayCC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCC.Location = new System.Drawing.Point(206, 248);
            this.dtpNgayCC.Name = "dtpNgayCC";
            this.dtpNgayCC.Size = new System.Drawing.Size(291, 22);
            this.dtpNgayCC.TabIndex = 44;
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(206, 72);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(287, 24);
            this.cboNCC.TabIndex = 43;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(42, 202);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Số lượng:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(320, 361);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 38;
            this.btnLoad.Text = "Làm Mới";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(206, 300);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(291, 22);
            this.txtGhiChu.TabIndex = 42;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(42, 254);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 16);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Ngày cung cấp:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 16);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Tên nhà cung cấp:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(197, 361);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(42, 299);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 16);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Ghi chú:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(80, 361);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Mã sản phẩm :";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(206, 200);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(291, 22);
            this.txtSL.TabIndex = 30;
            // 
            // txtMaCC
            // 
            this.txtMaCC.Location = new System.Drawing.Point(206, 172);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.Size = new System.Drawing.Size(75, 22);
            this.txtMaCC.TabIndex = 31;
            this.txtMaCC.Visible = false;
            this.txtMaCC.TextChanged += new System.EventHandler(this.txtMa_EditValueChanged);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(206, 140);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(291, 22);
            this.txtMa.TabIndex = 31;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_EditValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSP);
            this.groupBox2.Location = new System.Drawing.Point(3, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 245);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvSP
            // 
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.Location = new System.Drawing.Point(3, 18);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(821, 224);
            this.dgvSP.TabIndex = 0;
            this.dgvSP.Click += new System.EventHandler(this.dgvSP_Click);
            // 
            // FormCTCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCTCungCap";
            this.Text = "FormCTCungCap";
            this.Load += new System.EventHandler(this.FormCTCungCap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTCungCap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCTCungCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgayCC;
        private System.Windows.Forms.ComboBox cboNCC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraEditors.TextEdit txtMaCC;
    }
}
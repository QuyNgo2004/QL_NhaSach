﻿namespace QLNS_GUI
{
    partial class FormThanhToan
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
            this.dgvSPHD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtXoa = new System.Windows.Forms.Button();
            this.cboKM = new System.Windows.Forms.ComboBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSPHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 722);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm trong hóa đơn:";
            // 
            // dgvSPHD
            // 
            this.dgvSPHD.AllowUserToAddRows = false;
            this.dgvSPHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSPHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSPHD.Location = new System.Drawing.Point(3, 18);
            this.dgvSPHD.Name = "dgvSPHD";
            this.dgvSPHD.RowHeadersWidth = 51;
            this.dgvSPHD.RowTemplate.Height = 24;
            this.dgvSPHD.Size = new System.Drawing.Size(479, 701);
            this.dgvSPHD.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtMaCTHD);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtXoa);
            this.panel1.Controls.Add(this.cboKM);
            this.panel1.Controls.Add(this.cboKhachHang);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(488, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 704);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSP);
            this.groupBox2.Location = new System.Drawing.Point(3, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 388);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm:";
            // 
            // dgvSP
            // 
            this.dgvSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(3, 18);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(610, 367);
            this.dgvSP.TabIndex = 0;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(146, 214);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(205, 22);
            this.txtSL.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(32, 276);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 16);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tổng tiền:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 220);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Số Lượng:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(126, 269);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(89, 22);
            this.txtGia.TabIndex = 11;
            this.txtGia.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(417, 110);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(89, 22);
            this.txtMaNV.TabIndex = 11;
            this.txtMaNV.Visible = false;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(512, 110);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(89, 22);
            this.txtMaCTHD.TabIndex = 11;
            this.txtMaCTHD.Visible = false;
            this.txtMaCTHD.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(146, 160);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(205, 22);
            this.txtMa.TabIndex = 11;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(242, 269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(32, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Mã sản phẩm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(390, 166);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Mã khuyến mãi:";
            // 
            // txtXoa
            // 
            this.txtXoa.Location = new System.Drawing.Point(338, 269);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(75, 23);
            this.txtXoa.TabIndex = 13;
            this.txtXoa.Text = "Xóa";
            this.txtXoa.UseVisualStyleBackColor = true;
            this.txtXoa.Click += new System.EventHandler(this.txtXoa_Click);
            // 
            // cboKM
            // 
            this.cboKM.FormattingEnabled = true;
            this.cboKM.Location = new System.Drawing.Point(512, 157);
            this.cboKM.Name = "cboKM";
            this.cboKM.Size = new System.Drawing.Size(89, 24);
            this.cboKM.TabIndex = 9;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(146, 110);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(205, 24);
            this.cboKhachHang.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 118);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 16);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Khách Hàng:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(459, 265);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(108, 23);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Thanh toán";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Tạo hóa đơn mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(133, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 46);
            this.label4.TabIndex = 85;
            this.label4.Text = "THANH TOÁN";
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSPHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSL;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button txtXoa;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.ComboBox cboKM;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
    }
}
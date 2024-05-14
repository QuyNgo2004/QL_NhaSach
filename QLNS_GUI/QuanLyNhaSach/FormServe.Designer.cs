namespace QLNS_GUI
{
    partial class FormServe
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
            this.txtServe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtThem = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtServe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServe
            // 
            this.txtServe.Location = new System.Drawing.Point(165, 62);
            this.txtServe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServe.Name = "txtServe";
            this.txtServe.Size = new System.Drawing.Size(131, 20);
            this.txtServe.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(69, 67);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Serve:";
            // 
            // txtThem
            // 
            this.txtThem.Location = new System.Drawing.Point(137, 112);
            this.txtThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(56, 19);
            this.txtThem.TabIndex = 2;
            this.txtThem.Text = "Thêm";
            this.txtThem.UseVisualStyleBackColor = true;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(81, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(201, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đăng nhập serve";
            // 
            // FormServe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 151);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtServe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormServe";
            this.Text = "FormServe";
            this.Load += new System.EventHandler(this.FormServe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtServe;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button txtThem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
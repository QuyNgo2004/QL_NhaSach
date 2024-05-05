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
            ((System.ComponentModel.ISupportInitialize)(this.txtServe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServe
            // 
            this.txtServe.Location = new System.Drawing.Point(210, 54);
            this.txtServe.Name = "txtServe";
            this.txtServe.Size = new System.Drawing.Size(125, 22);
            this.txtServe.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Serve:";
            // 
            // txtThem
            // 
            this.txtThem.Location = new System.Drawing.Point(158, 114);
            this.txtThem.Name = "txtThem";
            this.txtThem.Size = new System.Drawing.Size(75, 23);
            this.txtThem.TabIndex = 2;
            this.txtThem.Text = "Thêm";
            this.txtThem.UseVisualStyleBackColor = true;
            this.txtThem.Click += new System.EventHandler(this.txtThem_Click);
            // 
            // FormServe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 175);
            this.Controls.Add(this.txtThem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtServe);
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
    }
}
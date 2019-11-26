namespace GiaoDien
{
    partial class FormThem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_AddThuoc1 = new GiaoDien.UC_AddThuoc();
            this.uC_AddEmp1 = new GiaoDien.UC_AddEmp();
            this.uC_AddDichVu1 = new GiaoDien.UC_AddDichVu();
            this.lbWarning = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXong = new System.Windows.Forms.Button();
            this.uC_AddBN1 = new GiaoDien.UC_AddBN();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_AddBN1);
            this.panel1.Controls.Add(this.uC_AddThuoc1);
            this.panel1.Controls.Add(this.uC_AddEmp1);
            this.panel1.Controls.Add(this.uC_AddDichVu1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 315);
            this.panel1.TabIndex = 1;
            // 
            // uC_AddThuoc1
            // 
            this.uC_AddThuoc1.Location = new System.Drawing.Point(3, 3);
            this.uC_AddThuoc1.Name = "uC_AddThuoc1";
            this.uC_AddThuoc1.Size = new System.Drawing.Size(455, 207);
            this.uC_AddThuoc1.TabIndex = 3;
            // 
            // uC_AddEmp1
            // 
            this.uC_AddEmp1.Location = new System.Drawing.Point(3, 3);
            this.uC_AddEmp1.Name = "uC_AddEmp1";
            this.uC_AddEmp1.Size = new System.Drawing.Size(455, 306);
            this.uC_AddEmp1.TabIndex = 2;
            // 
            // uC_AddDichVu1
            // 
            this.uC_AddDichVu1.Location = new System.Drawing.Point(3, 3);
            this.uC_AddDichVu1.Name = "uC_AddDichVu1";
            this.uC_AddDichVu1.Size = new System.Drawing.Size(453, 100);
            this.uC_AddDichVu1.TabIndex = 1;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(63, 330);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(354, 24);
            this.lbWarning.TabIndex = 7;
            this.lbWarning.Text = "WARNING: CÓ CHẮC XOÁ KHÔNG?";
            this.lbWarning.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(309, 374);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 38);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXong
            // 
            this.btnXong.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXong.Location = new System.Drawing.Point(87, 374);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(94, 38);
            this.btnXong.TabIndex = 5;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // uC_AddBN1
            // 
            this.uC_AddBN1.Location = new System.Drawing.Point(5, 3);
            this.uC_AddBN1.Name = "uC_AddBN1";
            this.uC_AddBN1.Size = new System.Drawing.Size(455, 214);
            this.uC_AddBN1.TabIndex = 4;
            // 
            // FormThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.panel1);
            this.Name = "FormThem";
            this.Text = "FormThem";
            this.Load += new System.EventHandler(this.FormThem_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UC_AddEmp uC_AddEmp1;
        private UC_AddDichVu uC_AddDichVu1;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXong;
        private UC_AddThuoc uC_AddThuoc1;
        private UC_AddBN uC_AddBN1;
    }
}
namespace GiaoDien
{
    partial class AdminForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyThuoc = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.uC_Search1 = new GiaoDien.UC_Search();
            this.uC_buttons1 = new GiaoDien.UC_buttons();
            this.uC_Radio1 = new GiaoDien.UC_Radio();
            this.uC_Show1 = new GiaoDien.UC_Show();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnDangXuat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnQuanLyThuoc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDichVu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDoanhThu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNhanVien, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangXuat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(743, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(179, 40);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLyThuoc
            // 
            this.btnQuanLyThuoc.BackColor = System.Drawing.Color.LightGreen;
            this.btnQuanLyThuoc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuoc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnQuanLyThuoc.Location = new System.Drawing.Point(558, 3);
            this.btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            this.btnQuanLyThuoc.Size = new System.Drawing.Size(179, 40);
            this.btnQuanLyThuoc.TabIndex = 3;
            this.btnQuanLyThuoc.Text = "QUẢN LÝ THUỐC";
            this.btnQuanLyThuoc.UseVisualStyleBackColor = false;
            this.btnQuanLyThuoc.Click += new System.EventHandler(this.btnQuanLyThuoc_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.LightGreen;
            this.btnDichVu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDichVu.Location = new System.Drawing.Point(373, 3);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(179, 40);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "DỊCH VỤ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.LightGreen;
            this.btnDoanhThu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDoanhThu.Location = new System.Drawing.Point(188, 3);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(179, 40);
            this.btnDoanhThu.TabIndex = 1;
            this.btnDoanhThu.Text = "DOANH THU";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.LightGreen;
            this.btnNhanVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 3);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(179, 40);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // uC_Search1
            // 
            this.uC_Search1.Location = new System.Drawing.Point(261, 443);
            this.uC_Search1.Name = "uC_Search1";
            this.uC_Search1.Size = new System.Drawing.Size(476, 33);
            this.uC_Search1.TabIndex = 4;
            // 
            // uC_buttons1
            // 
            this.uC_buttons1.Location = new System.Drawing.Point(203, 472);
            this.uC_buttons1.Name = "uC_buttons1";
            this.uC_buttons1.Size = new System.Drawing.Size(551, 48);
            this.uC_buttons1.TabIndex = 3;
            // 
            // uC_Radio1
            // 
            this.uC_Radio1.Location = new System.Drawing.Point(247, 412);
            this.uC_Radio1.Name = "uC_Radio1";
            this.uC_Radio1.Size = new System.Drawing.Size(490, 34);
            this.uC_Radio1.TabIndex = 2;
            this.uC_Radio1.Visible = false;
            // 
            // uC_Show1
            // 
            this.uC_Show1.Location = new System.Drawing.Point(117, 49);
            this.uC_Show1.Name = "uC_Show1";
            this.uC_Show1.Size = new System.Drawing.Size(726, 365);
            this.uC_Show1.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.uC_Search1);
            this.Controls.Add(this.uC_buttons1);
            this.Controls.Add(this.uC_Radio1);
            this.Controls.Add(this.uC_Show1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminForm";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyThuoc;
        private System.Windows.Forms.Button btnDichVu;
        private UC_Radio uC_Radio1;
        private UC_Show uC_Show1;
        private UC_buttons uC_buttons1;
        private UC_Search uC_Search1;
    }
}
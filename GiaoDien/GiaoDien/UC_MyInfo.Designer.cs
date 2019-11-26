namespace GiaoDien
{
    partial class UC_MyInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTen = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSDT = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnNgaySinh = new System.Windows.Forms.Panel();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMKM = new System.Windows.Forms.Panel();
            this.txtMKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnXNMK = new System.Windows.Forms.Panel();
            this.txtXnMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnTen.SuspendLayout();
            this.pnSDT.SuspendLayout();
            this.pnNgaySinh.SuspendLayout();
            this.pnMKM.SuspendLayout();
            this.pnXNMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.04587F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.55963F));
            this.tableLayoutPanel1.Controls.Add(this.btnDoiMatKhau, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCapNhat, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 332);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.DarkRed;
            this.btnDoiMatKhau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(375, 3);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(167, 38);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(194, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(175, 38);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(3, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(185, 38);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnTen);
            this.flowLayoutPanel1.Controls.Add(this.pnSDT);
            this.flowLayoutPanel1.Controls.Add(this.pnNgaySinh);
            this.flowLayoutPanel1.Controls.Add(this.pnMKM);
            this.flowLayoutPanel1.Controls.Add(this.pnXNMK);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(371, 266);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pnTen
            // 
            this.pnTen.Controls.Add(this.txtName);
            this.pnTen.Controls.Add(this.label1);
            this.pnTen.Enabled = false;
            this.pnTen.Location = new System.Drawing.Point(3, 3);
            this.pnTen.Name = "pnTen";
            this.pnTen.Size = new System.Drawing.Size(356, 45);
            this.pnTen.TabIndex = 11;
            this.pnTen.TabStop = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // pnSDT
            // 
            this.pnSDT.Controls.Add(this.txtSDT);
            this.pnSDT.Controls.Add(this.label5);
            this.pnSDT.Enabled = false;
            this.pnSDT.Location = new System.Drawing.Point(3, 54);
            this.pnSDT.Name = "pnSDT";
            this.pnSDT.Size = new System.Drawing.Size(356, 49);
            this.pnSDT.TabIndex = 13;
            this.pnSDT.TabStop = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(105, 13);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // pnNgaySinh
            // 
            this.pnNgaySinh.Controls.Add(this.dtp1);
            this.pnNgaySinh.Controls.Add(this.label2);
            this.pnNgaySinh.Enabled = false;
            this.pnNgaySinh.Location = new System.Drawing.Point(3, 109);
            this.pnNgaySinh.Name = "pnNgaySinh";
            this.pnNgaySinh.Size = new System.Drawing.Size(356, 45);
            this.pnNgaySinh.TabIndex = 12;
            this.pnNgaySinh.TabStop = true;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(105, 10);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày sinh";
            // 
            // pnMKM
            // 
            this.pnMKM.Controls.Add(this.txtMKm);
            this.pnMKM.Controls.Add(this.label3);
            this.pnMKM.Enabled = false;
            this.pnMKM.Location = new System.Drawing.Point(3, 160);
            this.pnMKM.Name = "pnMKM";
            this.pnMKM.Size = new System.Drawing.Size(356, 49);
            this.pnMKM.TabIndex = 14;
            this.pnMKM.TabStop = true;
            // 
            // txtMKm
            // 
            this.txtMKm.Location = new System.Drawing.Point(105, 13);
            this.txtMKm.Name = "txtMKm";
            this.txtMKm.Size = new System.Drawing.Size(214, 20);
            this.txtMKm.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // pnXNMK
            // 
            this.pnXNMK.Controls.Add(this.txtXnMK);
            this.pnXNMK.Controls.Add(this.label4);
            this.pnXNMK.Enabled = false;
            this.pnXNMK.Location = new System.Drawing.Point(3, 215);
            this.pnXNMK.Name = "pnXNMK";
            this.pnXNMK.Size = new System.Drawing.Size(356, 49);
            this.pnXNMK.TabIndex = 15;
            this.pnXNMK.TabStop = true;
            // 
            // txtXnMK
            // 
            this.txtXnMK.Location = new System.Drawing.Point(129, 13);
            this.txtXnMK.Name = "txtXnMK";
            this.txtXnMK.Size = new System.Drawing.Size(214, 20);
            this.txtXnMK.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // UC_MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_MyInfo";
            this.Size = new System.Drawing.Size(645, 441);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnTen.ResumeLayout(false);
            this.pnTen.PerformLayout();
            this.pnSDT.ResumeLayout(false);
            this.pnSDT.PerformLayout();
            this.pnNgaySinh.ResumeLayout(false);
            this.pnNgaySinh.PerformLayout();
            this.pnMKM.ResumeLayout(false);
            this.pnMKM.PerformLayout();
            this.pnXNMK.ResumeLayout(false);
            this.pnXNMK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnTen;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnNgaySinh;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnMKM;
        private System.Windows.Forms.TextBox txtMKm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnXNMK;
        private System.Windows.Forms.TextBox txtXnMK;
        private System.Windows.Forms.Label label4;
    }
}

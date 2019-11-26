namespace GiaoDien
{
    partial class BSForm
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
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnCaNhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_MyInfo1 = new GiaoDien.UC_MyInfo();
            this.uC_Search1 = new GiaoDien.UC_Search();
            this.uC_PatientList1 = new GiaoDien.UC_PatientList();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDangXuat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKhamBenh, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCaNhan, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangXuat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDangXuat.Location = new System.Drawing.Point(469, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(229, 32);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.BackColor = System.Drawing.Color.LightGreen;
            this.btnKhamBenh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhamBenh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnKhamBenh.Location = new System.Drawing.Point(236, 3);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(227, 32);
            this.btnKhamBenh.TabIndex = 2;
            this.btnKhamBenh.Text = "KHÁM BỆNH";
            this.btnKhamBenh.UseVisualStyleBackColor = false;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnCaNhan
            // 
            this.btnCaNhan.BackColor = System.Drawing.Color.LightGreen;
            this.btnCaNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaNhan.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCaNhan.Location = new System.Drawing.Point(3, 3);
            this.btnCaNhan.Name = "btnCaNhan";
            this.btnCaNhan.Size = new System.Drawing.Size(227, 32);
            this.btnCaNhan.TabIndex = 1;
            this.btnCaNhan.Text = "CÁ NHÂN";
            this.btnCaNhan.UseVisualStyleBackColor = false;
            this.btnCaNhan.Click += new System.EventHandler(this.btnCaNhan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_MyInfo1);
            this.panel1.Controls.Add(this.uC_Search1);
            this.panel1.Controls.Add(this.uC_PatientList1);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 524);
            this.panel1.TabIndex = 1;
            // 
            // uC_MyInfo1
            // 
            this.uC_MyInfo1.Location = new System.Drawing.Point(25, 42);
            this.uC_MyInfo1.Name = "uC_MyInfo1";
            this.uC_MyInfo1.Size = new System.Drawing.Size(645, 441);
            this.uC_MyInfo1.TabIndex = 6;
            this.uC_MyInfo1.Load += new System.EventHandler(this.uC_MyInfo1_Load);
            // 
            // uC_Search1
            // 
            this.uC_Search1.Location = new System.Drawing.Point(117, 427);
            this.uC_Search1.Name = "uC_Search1";
            this.uC_Search1.Size = new System.Drawing.Size(474, 29);
            this.uC_Search1.TabIndex = 4;
            // 
            // uC_PatientList1
            // 
            this.uC_PatientList1.Location = new System.Drawing.Point(-2, 12);
            this.uC_PatientList1.Name = "uC_PatientList1";
            this.uC_PatientList1.Size = new System.Drawing.Size(698, 500);
            this.uC_PatientList1.TabIndex = 3;
            this.uC_PatientList1.Load += new System.EventHandler(this.uC_PatientList1_Load_1);
            // 
            // BSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BSForm";
            this.Text = "BSForm";
            this.Load += new System.EventHandler(this.BSForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnCaNhan;
        private System.Windows.Forms.Panel panel1;
        private UC_Search uC_Search1;
        private UC_PatientList uC_PatientList1;
        private UC_MyInfo uC_MyInfo1;
    }
}
namespace GiaoDien
{
    partial class UC_Radio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbThang = new System.Windows.Forms.RadioButton();
            this.rbNgay = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.rbNam);
            this.panel1.Controls.Add(this.rbThang);
            this.panel1.Controls.Add(this.rbNgay);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 27);
            this.panel1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(221, 5);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 9;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Năm";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbThang
            // 
            this.rbThang.AutoSize = true;
            this.rbThang.Location = new System.Drawing.Point(131, 5);
            this.rbThang.Name = "rbThang";
            this.rbThang.Size = new System.Drawing.Size(56, 17);
            this.rbThang.TabIndex = 8;
            this.rbThang.TabStop = true;
            this.rbThang.Text = "Tháng";
            this.rbThang.UseVisualStyleBackColor = true;
            this.rbThang.CheckedChanged += new System.EventHandler(this.rbThang_CheckedChanged);
            // 
            // rbNgay
            // 
            this.rbNgay.AutoSize = true;
            this.rbNgay.Location = new System.Drawing.Point(40, 5);
            this.rbNgay.Name = "rbNgay";
            this.rbNgay.Size = new System.Drawing.Size(50, 17);
            this.rbNgay.TabIndex = 7;
            this.rbNgay.TabStop = true;
            this.rbNgay.Text = "Ngày";
            this.rbNgay.UseVisualStyleBackColor = true;
            this.rbNgay.CheckedChanged += new System.EventHandler(this.rbNgay_CheckedChanged);
            // 
            // UC_Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Radio";
            this.Size = new System.Drawing.Size(488, 34);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbThang;
        private System.Windows.Forms.RadioButton rbNgay;
    }
}

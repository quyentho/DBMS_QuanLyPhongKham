namespace GiaoDien
{
    partial class UC_PatientList
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnToaThuoc = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(3, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(692, 386);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellEnter);
            // 
            // btnToaThuoc
            // 
            this.btnToaThuoc.BackColor = System.Drawing.Color.YellowGreen;
            this.btnToaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToaThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnToaThuoc.Location = new System.Drawing.Point(157, 415);
            this.btnToaThuoc.Name = "btnToaThuoc";
            this.btnToaThuoc.Size = new System.Drawing.Size(162, 65);
            this.btnToaThuoc.TabIndex = 2;
            this.btnToaThuoc.Text = "Tạo Toa Thuốc";
            this.btnToaThuoc.UseVisualStyleBackColor = false;
            this.btnToaThuoc.Click += new System.EventHandler(this.btnToaThuoc_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDichVu.Location = new System.Drawing.Point(368, 415);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(154, 65);
            this.btnDichVu.TabIndex = 3;
            this.btnDichVu.Text = "Chỉ định dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // UC_PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnToaThuoc);
            this.Controls.Add(this.dgv1);
            this.Name = "UC_PatientList";
            this.Size = new System.Drawing.Size(698, 499);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnToaThuoc;
        private System.Windows.Forms.Button btnDichVu;
    }
}

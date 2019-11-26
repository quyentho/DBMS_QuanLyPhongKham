namespace GiaoDien
{
    partial class UC_ChiDinhDV
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
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbBN = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(3, 3);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(265, 230);
            this.rtbShow.TabIndex = 0;
            this.rtbShow.Text = "";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(301, 3);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(365, 230);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellEnter);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(327, 239);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(119, 52);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // lbBN
            // 
            this.lbBN.AutoSize = true;
            this.lbBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBN.Location = new System.Drawing.Point(13, 239);
            this.lbBN.Name = "lbBN";
            this.lbBN.Size = new System.Drawing.Size(58, 22);
            this.lbBN.TabIndex = 3;
            this.lbBN.Text = "label1";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(502, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 52);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Xong";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // UC_ChiDinhDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbBN);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.rtbShow);
            this.Name = "UC_ChiDinhDV";
            this.Size = new System.Drawing.Size(681, 303);
            this.Load += new System.EventHandler(this.UC_ChiDinhDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label lbBN;
        private System.Windows.Forms.Button btnOk;
    }
}

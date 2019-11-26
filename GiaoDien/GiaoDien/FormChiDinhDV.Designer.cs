namespace GiaoDien
{
    partial class FormChiDinhDV
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
            this.uC_ChiDinhDV1 = new GiaoDien.UC_ChiDinhDV();
            this.SuspendLayout();
            // 
            // uC_ChiDinhDV1
            // 
            this.uC_ChiDinhDV1.Location = new System.Drawing.Point(4, 12);
            this.uC_ChiDinhDV1.Name = "uC_ChiDinhDV1";
            this.uC_ChiDinhDV1.Size = new System.Drawing.Size(681, 297);
            this.uC_ChiDinhDV1.TabIndex = 0;
            this.uC_ChiDinhDV1.Load += new System.EventHandler(this.uC_ChiDinhDV1_Load);
            // 
            // FormChiDinhDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 328);
            this.Controls.Add(this.uC_ChiDinhDV1);
            this.Name = "FormChiDinhDV";
            this.Text = "FormChiDinhDV";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ChiDinhDV uC_ChiDinhDV1;
    }
}
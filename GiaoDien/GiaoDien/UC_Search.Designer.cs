namespace GiaoDien
{
    partial class UC_Search
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
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(232, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Items.AddRange(new object[] {
            "Tên",
            "Chức"});
            this.cbLoaiTK.Location = new System.Drawing.Point(3, 5);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiTK.TabIndex = 8;
            this.cbLoaiTK.Visible = false;
            // 
            // UC_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbLoaiTK);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSearch);
            this.Name = "UC_Search";
            this.Size = new System.Drawing.Size(474, 29);
            this.Load += new System.EventHandler(this.UC_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbLoaiTK;
    }
}

namespace GiaoDien
{
    partial class UC_Show
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
            this.dgvXem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXem
            // 
            this.dgvXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXem.Location = new System.Drawing.Point(0, 3);
            this.dgvXem.Name = "dgvXem";
            this.dgvXem.ReadOnly = true;
            this.dgvXem.Size = new System.Drawing.Size(709, 357);
            this.dgvXem.TabIndex = 0;
            this.dgvXem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXem_CellClick);
            this.dgvXem.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXem_CellEnter);
            // 
            // UC_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvXem);
            this.Name = "UC_Show";
            this.Size = new System.Drawing.Size(712, 399);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXem;
    }
}

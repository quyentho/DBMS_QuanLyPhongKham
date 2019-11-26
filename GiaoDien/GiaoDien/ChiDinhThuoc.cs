using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class ChiDinhThuoc : Form
    {
        public int? soLuong;
        public string HDSD;
        public ChiDinhThuoc()
        {
            
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                soLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                txtSoLuong.Focus();
            }
            if (!string.IsNullOrWhiteSpace(rtbHDSD.Text))
            {
                HDSD = rtbHDSD.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Hướng dẫn sử dụng");
                txtSoLuong.Focus();
            }
        }
    }
}

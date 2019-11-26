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
    public partial class YtaForm : Form
    {
        QuanLyPhongKhamEntities _context = new QuanLyPhongKhamEntities();
        private int _chucNang=5;
        private int _idSelected;
        public YtaForm()
        {
            InitializeComponent();

            uC_Show1.dgv_SelectionChanged += new EventHandler(uC_Show1_dgv_SelectionChanged);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?") == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            btnThanhToan.Visible = false;
            btnDichVu.Visible = true;
            btnTao.Visible = true;

            uC_Show1.DgvShow.DataSource = _context.DanhSachBN();

        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            btnThanhToan.Visible = true;
            btnDichVu.Visible = false;
            btnTao.Visible = false;
            uC_Show1.DgvShow.DataSource = _context.DanhSachHDChuaTra();
        }

        private void YtaForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_Show1);

            btnThanhToan.Visible = false;
            btnDichVu.Visible = true;
            btnTao.Visible = true;

            uC_Show1.DgvShow.DataSource = _context.DanhSachBN();

          
        }

        private void F2_UpdateEventHandler1(object sender, FormThem.UpdateEventArgs args)
        {                     
                uC_Show1.DgvShow.DataSource = _context.DanhSachBN();
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            _chucNang = 5;
            using (FormThem fThem = new FormThem(null,_chucNang))
            {
                fThem.UpdateEventHandler += F2_UpdateEventHandler1;// for refresh gridview
                fThem.ShowDialog();
            }
               
        }

        // su kien chon trong dgv
        private void uC_Show1_dgv_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = uC_Show1.DgvShow.CurrentCell.RowIndex;
            _idSelected = Convert.ToInt32(uC_Show1.DgvShow.Rows[selectedRowIndex].Cells[0].Value);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
                using (FormChiDinhDV formChiDinhDV = new FormChiDinhDV(_idSelected))
                {
                    formChiDinhDV.ShowDialog();
                }
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Thông báo", "Bạn muốn xuất hoá đơn thanh toán?",MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)== DialogResult.OK)
            {
                _context.ThanhToanHoaDon(_idSelected);
            }
        }
    }
}

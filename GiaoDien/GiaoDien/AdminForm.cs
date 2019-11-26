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
    public partial class AdminForm : Form
    {
        private QuanLyPhongKhamEntities _context = new QuanLyPhongKhamEntities();
        private int _chucNang = 1;
        public static int tacVu = 1;
        private int _idSelected;


        public AdminForm()
        {
            InitializeComponent();

            uC_buttons1.ButtonThemClick += new EventHandler(uC_buttons1_ButtonThemClick);
            uC_buttons1.ButtonSuaClick += new EventHandler(uC_buttons1_ButtonSuaClick);
            uC_buttons1.ButtonXoaClick += new EventHandler(uC_buttons1_ButtonXoaClick);
            uC_Show1.dgv_SelectionChanged += new EventHandler(uC_Show1_dgv_SelectionChanged);
            uC_Radio1.RbNgayClick += new EventHandler(uC_Radio1_RbNgay_Click);
            uC_Radio1.RbThangClick += new EventHandler(uC_Radio1_RbThang_Click);
            uC_Radio1.RbNamClick += new EventHandler(uC_Radio1_RbNam_Click);
          //  uC_Search1.Search += new EventHandler(uC_Search1_TxtSearch_TextChanged);
            uC_Search1.BtnSearchClick += new EventHandler(uC_Search1_BtnSearchClick);


        }
        private void uC_Search1_BtnSearchClick(object sender, EventArgs e)
        {
            if(_chucNang==1)
            {
                if (uC_Search1.CBLoai.SelectedIndex == 0)//tim theo ten
                {
                    uC_Show1.DgvShow.DataSource = _context.TimNVTheoTen(uC_Search1.TxtSearch.Text);
                }
                else//Tim theo chuc
                {
                    uC_Show1.DgvShow.DataSource = _context.TimNVTheoChuc(uC_Search1.TxtSearch.Text);
                }
            }
            else if(_chucNang == 4)
            {
                uC_Show1.DgvShow.DataSource = _context.TimThuocTheoTen(uC_Search1.TxtSearch.Text);
            }
        
        }
       // private void uC_Search1_TxtSearch_TextChanged(object sender, EventArgs e)
       //{
           
       // }
        private void uC_Radio1_RbNgay_Click(object sender, EventArgs e)
        {
            uC_Show1.DgvShow.DataSource = _context.HienDoanhThuNgay(uC_Radio1.DtpShow.Value);
        }
        private void uC_Radio1_RbThang_Click(object sender, EventArgs e)
        {
            uC_Show1.DgvShow.DataSource = _context.HienDoanhThuThang(uC_Radio1.DtpShow.Value);

        }
        private void uC_Radio1_RbNam_Click(object sender, EventArgs e)
        {
            uC_Show1.DgvShow.DataSource = _context.HienDoanhThuNam();
            
        }
        //Get ID For change
        private void uC_Show1_dgv_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = uC_Show1.DgvShow.CurrentCell.RowIndex;
            if(_chucNang != 2)
            _idSelected = Convert.ToInt32(uC_Show1.DgvShow.Rows[selectedRowIndex].Cells[0].Value);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            uC_Search1.CBLoai.Visible = false;
            uC_Radio1.Visible = true;
            uC_buttons1.Visible = false;
            uC_Search1.Visible = false;
            _chucNang = 2;
            uC_Show1.DgvShow.DataSource = _context.HienDoanhThuNgay(uC_Radio1.DtpShow.Value);
            uC_Radio1.RbNgay.Checked = true;

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            uC_Search1.CBLoai.Visible = true;
            uC_Radio1.Visible = false;
            uC_buttons1.Visible = true;
            uC_Search1.Visible = true;
            uC_Show1.DgvShow.DataSource = _context.DanhSachNV();
            _chucNang = 1;

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            uC_Search1.Visible = false;
            uC_Radio1.Visible = false;
            uC_buttons1.Visible = true;
            uC_Show1.DgvShow.DataSource = _context.DanhSachDV();
            _chucNang = 3;


        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            uC_Search1.CBLoai.Visible = false;
            uC_Search1.Visible = true;
            uC_Radio1.Visible = false;
            uC_buttons1.Visible = true;
            uC_Show1.DgvShow.DataSource = _context.DanhSachThuoc();
            _chucNang = 4;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?") == DialogResult.OK)
            {
                this.Close();
            }
        }

        protected void AdminForm_Load(object sender, EventArgs e)
        {
            uC_Search1.CBLoai.Visible = true;
            uC_Show1.DgvShow.DataSource = _context.DanhSachNV();
        }

        private void F2_UpdateEventHandler1(object sender, FormThem.UpdateEventArgs args)
        {
            if (_chucNang == 1)
                uC_Show1.DgvShow.DataSource = _context.DanhSachNV();
            else if (_chucNang == 3)
                uC_Show1.DgvShow.DataSource = _context.DanhSachDV();
            else if (_chucNang == 4)
                uC_Show1.DgvShow.DataSource = _context.DanhSachThuoc();
           


        }
        protected void uC_buttons1_ButtonThemClick(object sender, EventArgs e)
        {
            tacVu = 1;
            using (FormThem fThem = new FormThem(null,_chucNang))
            {
                fThem.UpdateEventHandler += F2_UpdateEventHandler1;// for refresh gridview
                fThem.ShowDialog();
            }
            
                
        }
        protected void uC_buttons1_ButtonSuaClick(object sender, EventArgs e)
        {
            tacVu = 2;
            FormThem fThem = new FormThem(_idSelected,_chucNang);
            fThem.UpdateEventHandler += F2_UpdateEventHandler1;// for refresh gridview
            fThem.ShowDialog();
        }
        protected void uC_buttons1_ButtonXoaClick(object sender, EventArgs e)
        {
            tacVu = 3;
            using (FormThem fThem = new FormThem(_idSelected,_chucNang))
            {
                if (fThem.ShowDialog() == DialogResult.OK)
                {
                    if (_chucNang == 1)
                        _context.XoaNhanVien(_idSelected);
                    else if (_chucNang == 3)
                        _context.XoaDichVu(_idSelected);
                    else if (_chucNang == 4)
                        _context.XoaThuoc(_idSelected);
                }
            }
                //  fThem.UpdateEventHandler += F2_UpdateEventHandler1;// for refresh gridview
               
        }

      
    }
}

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
    public partial class FormChiDinhDV : Form
    {
        QuanLyPhongKhamEntities _context = new QuanLyPhongKhamEntities();
        private int _idBenhNhan;
        private int _idSelected;
        private int _selectedRowIndex;
        public FormChiDinhDV(int idSelected)
        {
            InitializeComponent();

            _idBenhNhan = idSelected;
            uC_ChiDinhDV1.Dgv_SelectionChanged += new EventHandler(uC_ChiDinhDV1_dgv_SelectionChanged);
            uC_ChiDinhDV1.BtnChonClick += new EventHandler(UC_ChiDinhDV1_BtnChonClick);
            uC_ChiDinhDV1.BtnXongClick += new EventHandler(UC_ChiDinhDV1_BtnXongClick);
        }
        private void UC_ChiDinhDV1_BtnXongClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_ChiDinhDV1_BtnChonClick(object sender, EventArgs e)
        {
            string tenDV = uC_ChiDinhDV1.DgvDichVu.Rows[_selectedRowIndex].Cells[1].Value.ToString();
            
            try
            {
                if (BSForm.tacVu == 2)// // toa thuoc
                {
                    string tenThuoc = _context.TimThuocTheoMa(_idSelected).ToString();
                    int? soLuong = null;
                    string HDSD = "";
                    using (ChiDinhThuoc f = new ChiDinhThuoc())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            soLuong = f.soLuong;
                            HDSD = f.HDSD;
                        }

                    }

                    if (HDSD != null && soLuong != null)
                    {
                        uC_ChiDinhDV1.RtbShow.Text += tenDV + '\n';
                        _context.ThemToaThuoc(_idBenhNhan, tenThuoc, soLuong, Form1.IDNV, HDSD);
                    }
                        
                    else
                        MessageBox.Show("Thêm Toa Thuốc thất bại");




                }
                else
                {
                    uC_ChiDinhDV1.RtbShow.Text += tenDV + '\n';
                    _context.ChiDinhDV(_idBenhNhan, _idSelected);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void uC_ChiDinhDV1_dgv_SelectionChanged(object sender, EventArgs e)
        {
            _selectedRowIndex = uC_ChiDinhDV1.DgvDichVu.CurrentCell.RowIndex;
            _idSelected = Convert.ToInt32(uC_ChiDinhDV1.DgvDichVu.Rows[_selectedRowIndex].Cells[0].Value);
        }

        private void uC_ChiDinhDV1_Load(object sender, EventArgs e)
        {

            uC_ChiDinhDV1.DgvDichVu.DataSource = _context.DanhSachDV();
            if (BSForm.tacVu == 2)//Tao Toa thuoc
            {


                uC_ChiDinhDV1.DgvDichVu.DataSource = _context.DanhSachThuoc();
            }
            uC_ChiDinhDV1.LbShow.Text = "IDBN: " + _idBenhNhan.ToString();
        }
    }
}

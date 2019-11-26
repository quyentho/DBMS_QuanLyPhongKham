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
    public partial class BSForm : Form
    {
        private int _idNhanVien;
        private int _tacVu;
        private int _idSelected;
        public static int tacVu;
       public BSForm()
        {
            InitializeComponent();
        }
        QuanLyPhongKhamEntities _context = new QuanLyPhongKhamEntities();


        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_PatientList1);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_MyInfo1);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?") == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BSForm_Load(object sender, EventArgs e)
        {
            _idNhanVien = Form1.IDNV;

            panel1.Controls.Clear();
            panel1.Controls.Add(uC_MyInfo1);

           
        }

        private void UC_MyInfo1_BtnDoiMKClick(object sender, EventArgs e)
        {
            _tacVu = 2;
            uC_MyInfo1.PMkM.Enabled = true;
            uC_MyInfo1.PXNMK.Enabled = true;
            uC_MyInfo1.BtnCapNhat.Enabled = false;
            uC_MyInfo1.BtnLuu.Enabled = true;
            
           
            

        }

        private void UC_MyInfo1_BtnLuuClick(object sender, EventArgs e)
        {
            uC_MyInfo1.PTen.Enabled = false;
            uC_MyInfo1.PXNMK.Enabled = false;
            uC_MyInfo1.PMkM.Enabled = false;
            uC_MyInfo1.PNgaySinh.Enabled = false;
            uC_MyInfo1.PnSDT.Enabled = false;
            uC_MyInfo1.BtnCapNhat.Enabled = true;
            uC_MyInfo1.BtnDoiMK.Enabled = true;
            uC_MyInfo1.BtnLuu.Enabled = false;


            //Cap nhat du lieu
            if (_tacVu == 1)// cap nhat thong tin
            {
                var nv = _context.TimNVTheoMa(_idNhanVien);
                string chuc = nv.Select(p => p.Chuc).SingleOrDefault();
                int luong = nv.Select(p => p.Luong).SingleOrDefault();
                int tangCa = nv.Select(p => p.TangCa).SingleOrDefault();

                string tenNV = uC_MyInfo1.TxtTen.Text;
                string sdt = uC_MyInfo1.TxtSDT.Text;

                DateTime ngaySinh = uC_MyInfo1.Dtp1.Value;
                _context.SuaNhanVien(_idNhanVien, tenNV, ngaySinh, sdt, chuc, luong, tangCa);
            }
            else if(_tacVu==2)// doi mk
            {
                string pass = uC_MyInfo1.TxtMKM.Text;
                string xacNhanPass = uC_MyInfo1.TxtXnMK.Text;

                // Cap nhat mk
                if(pass != "")
                {
                    if (pass == xacNhanPass)
                        _context.DoiMatKhau(_idNhanVien, pass);
                    else
                        MessageBox.Show("Xác nhận mật khẩu sai");
                }
                else
                {
                    MessageBox.Show("Vui Lòng nhập mật khẩu");
                    uC_MyInfo1.TxtMKM.Focus();
                }
               
            }
          

        }

        private void UC_MyInfo1_BtnCapNhatClick(object sender, EventArgs e)
        {
            _tacVu = 1;
            uC_MyInfo1.PTen.Enabled = true;
            uC_MyInfo1.PXNMK.Enabled = false;
            uC_MyInfo1.PMkM.Enabled = false;
            uC_MyInfo1.PNgaySinh.Enabled = true;
            uC_MyInfo1.PnSDT.Enabled = true;
            uC_MyInfo1.BtnCapNhat.Enabled = false;
            uC_MyInfo1.BtnDoiMK.Enabled = false ;
            uC_MyInfo1.BtnLuu.Enabled = true;

        }

        private void uC_MyInfo1_Load(object sender, EventArgs e)
        {

            uC_MyInfo1.BtnCapNhatClick += new EventHandler(UC_MyInfo1_BtnCapNhatClick);
            uC_MyInfo1.BtnLuuClick += new EventHandler(UC_MyInfo1_BtnLuuClick);
            uC_MyInfo1.BtnDoiMKClick += new EventHandler(UC_MyInfo1_BtnDoiMKClick);

            _idNhanVien = Form1.IDNV;
            var nv = _context.TimNVTheoMa(_idNhanVien);
            string tenNV = nv.Select(p => p.HoTen).Single();
          
            //  var sdt = nv.Select(p => p.SDT).SingleOrDefault();
            uC_MyInfo1.TxtTen.Text = tenNV;
            // uC_MyInfo1.TxtSDT.Text = sdt;

            uC_MyInfo1.Dtp1.Value = nv.Select(p => p.NgaySinh).Single();



        }

        private void uC_PatientList1_Load_1(object sender, EventArgs e)
        {
            uC_PatientList1.Dgv1.DataSource = _context.DanhSachBN();
            uC_PatientList1.BtnToaThuocClick +=new EventHandler( UC_PatientList1_BtnToaThuocClick);
            uC_PatientList1.BtnDichVuClick += new EventHandler(UC_PatientList1_BtnDichVuClick);

            uC_PatientList1.dgv_SelectionChanged += new EventHandler(uC_PatientList1_dgv_SelectionChanged);
        }

        private void uC_PatientList1_dgv_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = uC_PatientList1.Dgv1.CurrentCell.RowIndex;
            _idSelected = Convert.ToInt32(uC_PatientList1.Dgv1.Rows[selectedRowIndex].Cells[0].Value);
        }
       
        private void UC_PatientList1_BtnDichVuClick(object sender, EventArgs e)
        {
            tacVu = 1;
            using (FormChiDinhDV formChiDinhDV = new FormChiDinhDV(_idSelected))
            {
                formChiDinhDV.ShowDialog();
            }
        }

        private void UC_PatientList1_BtnToaThuocClick(object sender, EventArgs e)
        {
            tacVu = 2;
            using (FormChiDinhDV formChiDinhDV = new FormChiDinhDV(_idSelected))
            {
                formChiDinhDV.ShowDialog();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class FormThem : Form
    {
        private QuanLyPhongKhamEntities _context = new QuanLyPhongKhamEntities();
        //for refresh datagridview
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        private int? _idSelected;
        private int? _chucNang;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
        //for refresh datagridview

        public FormThem(int? id,int? chucNang)
        {
            InitializeComponent();
            _idSelected = id;
            _chucNang = chucNang;
        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            if (_chucNang == 1)//Them Control Add NV
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(uC_AddEmp1);
                uC_AddEmp1.NTangCa.Enabled = false;
                if (AdminForm.tacVu != 1)// Sua Hoac Xoa
                {
                    uC_AddEmp1.NTangCa.Enabled = true;
                    // lay nhan vien can sua
                    var nv = _context.TimNVTheoMa(_idSelected);
                    string tenNV = nv.Select(p => p.HoTen).SingleOrDefault();
                    var chuc = nv.Select(p => p.Chuc).SingleOrDefault();
                    DateTime ngaySinh = Convert.ToDateTime(nv.Select(p => p.NgaySinh).Single());
                    var luong = nv.Select(p => p.Luong).SingleOrDefault();
                    var tangCa = nv.Select(p => p.TangCa).SingleOrDefault();
                   // var sdt = nv.Select(p => p.).SingleOrDefault();
                   
                    uC_AddEmp1.txtTenNV.Text = tenNV;
                    uC_AddEmp1.txtChuc.Text = chuc;
                    uC_AddEmp1.txtLuongNV.Text = luong.ToString();
                    uC_AddEmp1.Dtp.Value = ngaySinh;
                    uC_AddEmp1.NTangCa.Value = tangCa;
                  //  uC_AddEmp1.TxtSDT.Text = sdt.ToString();
                    if (AdminForm.tacVu == 3) // Xoa
                    {
                        uC_AddEmp1.txtTenNV.Enabled = false;
                        uC_AddEmp1.txtChuc.Enabled = false;
                        uC_AddEmp1.txtLuongNV.Enabled = false;
                        uC_AddEmp1.Dtp.Enabled = false;
                        uC_AddEmp1.NTangCa.Enabled = false;
                        lbWarning.Visible = true;

                    }
                }

            }
            else if (_chucNang == 3)// Dich vu
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(uC_AddDichVu1);
                if (AdminForm.tacVu != 1)// sua hoac xoa dich vu
                {
                    //Hien thi de sua
                    var dv = _context.TimDVTheoMa(_idSelected);
                    int? gia = dv.Select(d => d.Gia).SingleOrDefault();
                    string tenDv = dv.Select(d => d.TenDV).SingleOrDefault();
                    uC_AddDichVu1.TxtTenDichVu.Text = tenDv;
                    uC_AddDichVu1.TxtGia.Text = gia.ToString();
                    if(AdminForm.tacVu==3)//Xoa
                    {
                        uC_AddDichVu1.TxtTenDichVu.Enabled = false;
                        uC_AddDichVu1.TxtGia.Enabled = false;
                        lbWarning.Visible = true;
                    }
                }
            }
            else if(_chucNang==4)//Thuoc
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(uC_AddThuoc1);
                if(AdminForm.tacVu!=1)//Sua or xoa thuoc
                {
                     var thuoc = _context.TimThuocTheoMa(_idSelected);
                    string tenThuoc = thuoc.Select(t => t.Ten).SingleOrDefault();
                    string donVi = thuoc.Select(t => t.DonVi).SingleOrDefault();
                    int gia = thuoc.Select(t => t.Gia).SingleOrDefault();
                    decimal soLuong = thuoc.Select(t => t.SoLuong).SingleOrDefault();
                    
                    uC_AddThuoc1.TxtTenThuoc.Text = tenThuoc;
                    uC_AddThuoc1.TxtDonVi.Text = donVi;
                    uC_AddThuoc1.TxtGia.Text = gia.ToString();
                    uC_AddThuoc1.TxtSoLuong.Text = soLuong.ToString();
                    if(AdminForm.tacVu==3)//Xoa
                    {
                        uC_AddThuoc1.TxtTenThuoc.Enabled = false;
                        uC_AddThuoc1.TxtDonVi.Enabled = false;
                        uC_AddThuoc1.TxtGia.Enabled = false;
                        uC_AddThuoc1.TxtSoLuong.Enabled = false;
                        lbWarning.Visible = true;
                    }
                }
            }
            else if(_chucNang==5)// Benh nhan
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(uC_AddBN1);
                
            }
        }

    

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_AddEmp1_Load(object sender, EventArgs e)
        {

        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            try
            {
                if (_chucNang == 1)// Chuc nang nhan vien
                {
                    if (AdminForm.tacVu == 1)//Them
                    {
                        string tenNV = uC_AddEmp1.txtTenNV.Text;
                        string chucVu = uC_AddEmp1.txtChuc.Text;
                        int luong = Convert.ToInt32(uC_AddEmp1.txtLuongNV.Text);
                        DateTime ngaySinh = uC_AddEmp1.Dtp.Value;
                        string sdt = uC_AddEmp1.TxtSDT.Text;
                        if(chucVu.Trim().ToLower() != "bác sĩ" && chucVu.Trim().ToLower() !="y tá")
                        {
                            MessageBox.Show("Chức vụ không hợp lệ");
                            uC_AddEmp1.txtChuc.Focus();
                            

                        }
                        else
                        _context.ThemNhanVien(tenNV, ngaySinh, sdt, chucVu, luong);
                    }
                    else if (AdminForm.tacVu == 2)//Sua
                    {
                        string tenNV = uC_AddEmp1.txtTenNV.Text;
                        string chucVu = uC_AddEmp1.txtChuc.Text;
                        int luong = Convert.ToInt32(uC_AddEmp1.txtLuongNV.Text);
                        DateTime ngaySinh = uC_AddEmp1.Dtp.Value;
                        string sdt = uC_AddEmp1.TxtSDT.Text;
                        int tangCa = Convert.ToInt32(uC_AddEmp1.NTangCa.Value);
                        _context.SuaNhanVien(_idSelected, tenNV, ngaySinh, sdt, chucVu, luong, tangCa);
                    }


                }
                else if (_chucNang == 3)//Dich Vu
                {
                    if (AdminForm.tacVu == 1)
                    {
                        string tenDV = uC_AddDichVu1.TxtTenDichVu.Text;
                        int giaDV = Convert.ToInt32(uC_AddDichVu1.TxtGia.Text);
                        _context.ThemDichVu(tenDV, giaDV);
                    }
                    else if (AdminForm.tacVu == 2)
                    {
                        string tenDV = uC_AddDichVu1.TxtTenDichVu.Text;
                        int giaDV = Convert.ToInt32(uC_AddDichVu1.TxtGia.Text);
                        _context.SuaDichVu(_idSelected, tenDV, giaDV);
                    }

                }
                else if(_chucNang==4)// thuoc
                {
                    if(AdminForm.tacVu==1)
                    {
                        string tenThuoc = uC_AddThuoc1.TxtTenThuoc.Text;
                        int soLuong = Convert.ToInt32(uC_AddThuoc1.TxtSoLuong.Text);
                        string donVi = uC_AddThuoc1.TxtDonVi.Text;
                        int gia = Convert.ToInt32(uC_AddThuoc1.TxtGia.Text);
                        _context.ThemThuocMoi(tenThuoc, soLuong, donVi, gia);
                    }
                    else if(AdminForm.tacVu==2)
                    {
                        string tenThuoc = uC_AddThuoc1.TxtTenThuoc.Text;
                        int soLuong = Convert.ToInt32(uC_AddThuoc1.TxtSoLuong.Text);
                        string donVi = uC_AddThuoc1.TxtDonVi.Text;
                        int gia = Convert.ToInt32(uC_AddThuoc1.TxtGia.Text);
                        _context.SuaThuocCu(_idSelected,tenThuoc, soLuong, donVi, gia);
                    }
                   

                }
                else if(_chucNang==5)//Them Benh nhan
                {
                    string tenBN = uC_AddBN1.TxtTen.Text;
                    int Tuoi =Convert.ToInt32(uC_AddBN1.TxtTuoi.Text) ;
                    string SDT = uC_AddBN1.TxtSdt.Text;
                    string GioiTinh = uC_AddBN1.CbGioiTinh.Text.ToString();
                    _context.ThemBenhNhan(tenBN, Tuoi, GioiTinh, SDT);
                }

                raiseUpdate();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

   
    }
}

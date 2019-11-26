using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class UC_MyInfo : UserControl
    {
        public UC_MyInfo()
        {
            InitializeComponent();
        } 
        public Button BtnCapNhat
        {
            get { return btnCapNhat; }
            set { btnCapNhat = value; }
        }
        public Button BtnLuu
        {
            get { return btnLuu; }
            set { btnLuu = value; }
        }
        public Button BtnDoiMK
        {
            get { return btnDoiMatKhau; }
            set { btnDoiMatKhau = value; }
        }

        public TextBox TxtTen
        {
            get { return txtName; }
            set { txtName = value; }
        }
        public TextBox TxtSDT
        {
            get { return txtSDT; }
            set { txtSDT = value; }
        }
        public TextBox TxtMKM
        {
            get { return txtMKm; }
            set { txtMKm = value; }
        }
            
        
        public TextBox TxtXnMK
        {
            get { return txtXnMK; }
            set { txtXnMK = value; }
        }
        public DateTimePicker Dtp1
        {
            get { return dtp1; }
            set { dtp1 = value; }
        }
        public Panel PTen
        {
            get { return pnTen; }
            set { pnTen = value; }
        }
        public Panel PnSDT
        {
            get { return pnSDT; }
            set { pnSDT = value; }
        }
        public Panel PNgaySinh
        {
            get { return pnNgaySinh; }
            set { pnNgaySinh = value; }
        }
        public Panel PMkM
        {
            get { return pnMKM; }
            set { pnMKM = value; }
        }   public Panel PXNMK
        {
            get { return pnXNMK; }
            set { pnXNMK = value; }
        }
        public event EventHandler BtnCapNhatClick;
        public event EventHandler BtnLuuClick;
        public event EventHandler BtnDoiMKClick;

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            this.BtnCapNhatClick?.Invoke(this, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.BtnLuuClick?.Invoke(this, e);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.BtnDoiMKClick?.Invoke(this,e);
        }
    }
}

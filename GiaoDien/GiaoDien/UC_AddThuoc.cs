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
    public partial class UC_AddThuoc : UserControl
    {
        public TextBox TxtTenThuoc
        {
            get { return txtName; }
            set { txtName = value; }
        }
        public TextBox TxtDonVi
        {
            get { return txtDonVi; }
            set { txtDonVi = value; }
        }
        public TextBox TxtSoLuong
        {
            get { return txtSoLuong; }
            set { txtSoLuong = value; }
        }
        public TextBox TxtGia
        {
            get { return txtGia; }
            set { txtGia = value; }
        }
        public UC_AddThuoc()
        {
            InitializeComponent();
        }
    }
}

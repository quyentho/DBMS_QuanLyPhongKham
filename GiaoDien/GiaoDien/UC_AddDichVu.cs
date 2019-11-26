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
    public partial class UC_AddDichVu : UserControl
    {
        public TextBox TxtTenDichVu
        {
            get { return txtTenDichVu; }
            set { txtTenDichVu = value; }
        }
        public TextBox TxtGia
        {
            get { return txtGia; }
            set { txtGia = value; }
        }
        public UC_AddDichVu()
        {
            InitializeComponent();
        }
    }
}

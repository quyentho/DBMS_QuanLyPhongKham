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
    public partial class UC_AddBN : UserControl
    {
        public UC_AddBN()
        {
            InitializeComponent();
        }
        public TextBox TxtTen
        {
            get { return txtName; }
            set { txtName = value; }
        }
        public TextBox TxtSdt
        {
            get { return txtSDT; }
            set { txtSDT = value; }
        }
        public TextBox TxtTuoi
        {
            get { return txtTuoi; }
            set { txtTuoi = value; }
        }
        public ComboBox CbGioiTinh
        {
            get { return cbGioiTinh; }
            set { cbGioiTinh = value; }
        }
    }
}

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
    public partial class UC_AddEmp : UserControl
    {
        public TextBox TxtSDT
        {
            get { return txtSDT; }
            set { txtSDT = value; }
        }
        public NumericUpDown NTangCa
        {
            get { return numericUpDown1; }
            set { numericUpDown1 = value; }
        }
        public TextBox txtTenNV
        {
            get { return txtName; }
            set { txtName = value; }
        }

        public ComboBox txtChuc
        {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }
        public TextBox txtLuongNV
        {
            get { return txtLuong; }
            set { txtLuong = value; }
        }
        public DateTimePicker Dtp
        {
            get { return dateTimePicker1; }
            set { dateTimePicker1 = value; }
        }

        public UC_AddEmp()
        {
            InitializeComponent();
        }
    }
}

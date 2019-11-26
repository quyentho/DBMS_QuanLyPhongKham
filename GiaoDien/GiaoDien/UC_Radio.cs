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
    public partial class UC_Radio : UserControl
    {
        public DateTimePicker DtpShow
        {
            get { return dateTimePicker1; }
            set { dateTimePicker1 = value; }
        }
        public RadioButton RbNgay
        {
            get { return rbNgay; }
            set { rbNgay = value; }
        }
        public RadioButton RbThang
        {
            get { return rbThang; }
            set { rbThang = value; }
        }
        public RadioButton RbNam
        {
            get { return rbNam; }
            set { rbNam = value; }
        }
        public UC_Radio()
        {
            InitializeComponent();
        }

        public event EventHandler RbNgayClick;
        public event EventHandler RbThangClick;
        public event EventHandler RbNamClick;
     
        private void rbNgay_CheckedChanged(object sender, EventArgs e)
        {
            this.RbNgayClick?.Invoke(this, e);
        }

        private void rbThang_CheckedChanged(object sender, EventArgs e)
        {
            this.RbThangClick?.Invoke(this, e);
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            this.RbNamClick?.Invoke(this, e);
        }
    }
}

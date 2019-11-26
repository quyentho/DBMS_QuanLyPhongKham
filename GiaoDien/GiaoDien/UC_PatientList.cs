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
    public partial class UC_PatientList : UserControl
    {
        public UC_PatientList()
        {
            InitializeComponent();
        }
        public Button BtnToaThuoc
        {
            get { return btnToaThuoc; }
            set { btnToaThuoc = value; }
        }
        public Button BtnDichVu
        {
            get { return btnDichVu; }
            set { btnDichVu = value; }
        }
        public DataGridView Dgv1
        {
            get { return dgv1; }
            set { dgv1 = value; }
        }
        public event EventHandler BtnToaThuocClick;
        public event EventHandler BtnDichVuClick;

        private void btnToaThuoc_Click(object sender, EventArgs e)
        {
            this.BtnToaThuocClick?.Invoke(this, e);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            this.BtnDichVuClick?.Invoke(this, e);

        }
        public event EventHandler dgv_SelectionChanged;
        private void dgv1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_SelectionChanged?.Invoke(this, e);
        }
    }
}

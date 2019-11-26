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
    public partial class UC_ChiDinhDV : UserControl
    {
        public UC_ChiDinhDV()
        {
            InitializeComponent();
        }


        public event EventHandler BtnChonClick;
        public event EventHandler BtnXongClick;
        public RichTextBox RtbShow
        {
            get { return rtbShow; }
            set { rtbShow = value; }
        }
        public DataGridView DgvDichVu
        {
            get { return dgvDichVu; }
            set { dgvDichVu = value; }
        }

        public Button BtnChon
        {
            get { return btnChon; }
            set { btnChon = value; }
        
        }
        public Button BtnXong
        {
            get { return btnOk; }
            set { btnOk = value; }
        
        }
        public Label LbShow
        {
            get { return lbBN; }
            set { lbBN = value; }
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            this.BtnChonClick?.Invoke(this, e);
        }

        private void UC_ChiDinhDV_Load(object sender, EventArgs e)
        {
          
        }
        public event EventHandler Dgv_SelectionChanged;
        private void dgvDichVu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_SelectionChanged?.Invoke(this, e);
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.BtnXongClick?.Invoke(this, e);
        }
    }
}

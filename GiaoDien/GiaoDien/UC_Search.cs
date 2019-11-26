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
    public partial class UC_Search : UserControl
    {
        public UC_Search()
        {
            InitializeComponent();
        }
        public event EventHandler Search;
        public event EventHandler BtnSearchClick;
        public TextBox TxtSearch
        {
            get { return txtSearch;}
            set { txtSearch = value; }
        }
        public ComboBox CBLoai
        {
            get { return cbLoaiTK; }
            set { cbLoaiTK = value; }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Search?.Invoke(this, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BtnSearchClick?.Invoke(this, e);
        }

        private void UC_Search_Load(object sender, EventArgs e)
        {
            cbLoaiTK.SelectedIndex = 0;
        }
    }
}

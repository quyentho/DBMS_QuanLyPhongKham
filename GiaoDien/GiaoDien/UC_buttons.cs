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
    public partial class UC_buttons : UserControl
    {
        public UC_buttons()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonThemClick;
        public event EventHandler ButtonSuaClick;
        public event EventHandler ButtonXoaClick;
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.ButtonThemClick?.Invoke(this, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.ButtonSuaClick?.Invoke(this, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.ButtonXoaClick?.Invoke(this, e);
        }

     
    }
}

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
    public partial class UC_Show : UserControl
    {
        public UC_Show()
        {
            InitializeComponent();
        }
        public DataGridView DgvShow
        {
            get { return dgvXem; }
            set { dgvXem = value; }
        }
        public event EventHandler dgv_SelectionChanged;


        private void dgvXem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvXem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_SelectionChanged?.Invoke(this, e);
        }
    }
}

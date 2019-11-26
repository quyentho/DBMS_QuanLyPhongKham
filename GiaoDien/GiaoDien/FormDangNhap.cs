using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        QuanLyPhongKhamEntities _context = new QuanLyPhongKhamEntities();
        public static int IDNV;
        private string _quyen;
        public Form1()
        {
            InitializeComponent();
        }



   

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtUserName != null && txtPass != null)
            {
                string username = txtUserName.Text;
                string pass = txtPass.Text;
                var result=_context.DangNhap(username, pass);
                if(result.SingleOrDefault() != null)
                {
                    IDNV = result.Select(r => r.Ma_NV).Single();
                    _quyen= result.Select(r => r.Quyen).Single();
                    if(_quyen.Trim().ToLower()== "bác sĩ")
                    {
                        using (BSForm bSForm = new BSForm())
                        {
                            this.Hide();
                            bSForm.ShowDialog();
                            this.Show();
                        }

                           
                        
                    }
                    else if(_quyen.Trim().ToLower() == "admin")
                    {
                        using (AdminForm adminForm = new AdminForm())
                        {
                            this.Hide();
                            adminForm.ShowDialog();
                            this.Show();
                        }
                            
                        
                    }
                    else if(_quyen.Trim().ToLower() == "y tá")
                    {
                        using (YtaForm ytaForm = new YtaForm())
                        {
                            this.Hide();
                            ytaForm.ShowDialog();
                            this.Show();
                        }
                           
                    }

                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");
                    txtUserName.Clear();
                    txtPass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản mật khẩu");         
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

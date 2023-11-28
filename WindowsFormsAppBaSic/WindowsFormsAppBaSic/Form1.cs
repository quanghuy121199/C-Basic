using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBaSic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Huyle" && txtPassWord.Text == "123456")
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }
    }
}

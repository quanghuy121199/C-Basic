using LQHSecurity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppBaSic
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkHaveDll = false;
            string msg = "";
            var username = txtUserName.Text.Trim();
            var pass = txtPassWord.Text.Trim();
            bool chkUsername = false;
            bool chkPass = false;
            if (File.Exists($"{Application.StartupPath}/LQHSecurity.dll"))
            {
                Assembly assembly = Assembly.LoadFile($"{Application.StartupPath}/LQHSecurity.dll");
                Type type = assembly.GetType("LQHSecurity.LQHSecurityLib");
                MethodInfo mth = type.GetMethod("CheckUserName");
                var a = mth.Invoke(mth, new object[] { username });

                MethodInfo mthPass = type.GetMethod("CheckPassword");
                var b = (bool)mthPass.Invoke(mthPass, new object[] { pass });
                checkHaveDll = true;
            }

            if (checkHaveDll)
            {
                var lqh = new LQHSecurityLib();
                if (lqh.CheckUserName(txtUserName.Text.Trim()) && lqh.CheckPassWord(txtPassWord.Text.Trim()))
                {
                    msg = "Thành công";
                }
                else
                {
                    msg = "Sai thông tin đăng nhập";
                }
                MessageBox.Show(msg);
            }
            
        }
    }
}

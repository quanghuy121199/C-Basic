﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppControlDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Checkdll();
        }

        public void Checkdll()
        {
            btnLogin.Visible = false;
            btnRegis.Visible = false;
            BtnForgetPass.Visible = false;

            List<Assembly> allAssemblies = new List<Assembly>();
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string dll in Directory.GetFiles(assemblyFolder, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var assembly in allAssemblies)
            {
                var types = assembly.DefinedTypes;
                foreach (var type in types)
                {
                    if (!dic.ContainsKey(type.FullName))
                    {
                        dic.Add(type.FullName, type.FullName + "HuyLe");
                            if (type.FullName == "FormLoginLib.FormLogin")
                            {
                                btnLogin.Visible = true;
                            }
                            if (type.FullName == "FormRegisLib.FormRegister")
                            {
                                btnRegis.Visible = true;
                            }
                            if (type.FullName == "FormForgetPassLib.FormForgetPass")
                            {
                                BtnForgetPass.Visible = true;
                            }
                    }
                }
            }

            //foreach(var assembly in allAssemblies)
            //{
            //    var types = assembly.DefinedTypes;
            //    var modules = assembly.Modules;
            //    foreach (var module in modules)
            //    {
            //        foreach (var type in types)
            //        {
            //            if (type.FullName == "FormLoginLib.FormLogin" && module.Name == "FormLoginLib.dll")
            //            {
            //                btnLogin.Visible = true;
            //            }
            //            if (type.FullName == "FormRegisLib.FormRegister" && module.Name == "FormRegisLib.dll")
            //            {
            //                btnRegis.Visible = true;
            //            }
            //            if (type.FullName == "FormForgetPassLib.FormForgetPass" && module.Name == "FormForgetPassLib.dll")
            //            {
            //                BtnForgetPass.Visible = true;
            //            }
            //        }
            //    }
            //}



                //btnLogin.Visible = false;
                //btnRegis.Visible = false;
                //BtnForgetPass.Visible = false;

                //bool checkFormLoginDll = File.Exists($"{Application.StartupPath}/FormLoginLib.dll");
                //bool checkFormRegisDll = File.Exists($"{Application.StartupPath}/FormRegisLib.dll");
                //bool checkFormFogetPassDll = File.Exists($"{Application.StartupPath}/FormForgetPassLib.dll");
                //if (checkFormLoginDll)
                //{
                //    btnLogin.Visible = true;
                //}
                //if (checkFormRegisDll)
                //{
                //    btnRegis.Visible = true;
                //}
                //if (checkFormFogetPassDll)
                //{
                //    BtnForgetPass.Visible = true;
                //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Assembly> allAssemblies = new List<Assembly>();
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string dll in Directory.GetFiles(assemblyFolder, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var assembly in allAssemblies)
            {
                var types = assembly.DefinedTypes;
                foreach (var type in types)
                {
                    if (!dic.ContainsKey(type.FullName))
                    {
                        dic.Add(type.FullName, type.FullName + "HuyLe");
                        if (type.FullName == "FormLoginLib.FormLogin")
                        {
                            Form frmLogin = Activator.CreateInstance(type) as Form;
                            frmLogin.ShowDialog();
                        }
                    }
                }
            }

            //foreach (var assembly in allAssemblies)
            //{
            //    var types = assembly.DefinedTypes;
            //    var modules = assembly.Modules;
            //    foreach (var module in modules)
            //    {
            //        if (module.Name == "FormLoginLib.dll")
            //        {
            //            foreach (var type in types)
            //            {
            //                if (type.FullName == "FormLoginLib.FormLogin")
            //                {

            //                    Form frmRegis = Activator.CreateInstance(type) as Form;
            //                    frmRegis.ShowDialog();
            //                }
            //            }
            //        }

            //    }
            //}

            //Assembly assembly = Assembly.LoadFile($"{Application.StartupPath}/FormLoginLib.dll");
            //Type type = assembly.GetType("FormLoginLib.FormLogin");
            //Form frmLogin = Activator.CreateInstance(type) as Form;
            //frmLogin.ShowDialog();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            List<Assembly> allAssemblies = new List<Assembly>();
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string dll in Directory.GetFiles(assemblyFolder, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var assembly in allAssemblies)
            {
                var types = assembly.DefinedTypes;
                foreach (var type in types)
                {
                    if (!dic.ContainsKey(type.FullName))
                    {
                        dic.Add(type.FullName, type.FullName + "HuyLe");
                        if (type.FullName == "FormRegisLib.FormRegister")
                        {

                            Form frmLogin = Activator.CreateInstance(type) as Form;
                            frmLogin.ShowDialog();
                        }
                    }
                }
            }

            //foreach (var assembly in allAssemblies)
            //{
            //    var types = assembly.DefinedTypes;
            //    var modules = assembly.Modules;
            //    foreach(var module in modules)
            //    {
            //        if(module.Name == "FormRegisLib.dll")
            //        {
            //            foreach (var type in types)
            //            {
            //                if (type.FullName == "FormRegisLib.FormRegister")
            //                {

            //                    Form frmRegis = Activator.CreateInstance(type) as Form;
            //                    frmRegis.ShowDialog();
            //                }
            //            }
            //        }

            //    }
            //}


            //Assembly assembly = Assembly.LoadFile($"{Application.StartupPath}/FormRegisLib.dll");
            //Type type = assembly.GetType("FormRegisLib.FormRegister");
            //Form frmRegis = Activator.CreateInstance(type) as Form;
            //frmRegis.ShowDialog();
        }

        private void BtnForgetPass_Click(object sender, EventArgs e)
        {
            List<Assembly> allAssemblies = new List<Assembly>();
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string dll in Directory.GetFiles(assemblyFolder, "*.dll"))
            {
                allAssemblies.Add(Assembly.LoadFile(dll));
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var assembly in allAssemblies)
            {
                var types = assembly.DefinedTypes;
                foreach (var type in types)
                {
                    if (!dic.ContainsKey(type.FullName))
                    {
                        dic.Add(type.FullName, type.FullName + "HuyLe");
                        if (type.FullName == "FormForgetPassLib.FormForgetPass")
                        {

                            Form frmForgetPass = Activator.CreateInstance(type) as Form;
                            frmForgetPass.ShowDialog();
                        }
                    }
                }
            }

            //foreach (var assembly in allAssemblies)
            //{
            //    var types = assembly.DefinedTypes;
            //    var modules = assembly.Modules;
            //    foreach (var module in modules)
            //    {
            //        if (module.Name == "FormForgetPassLib.dll")
            //        {
            //            foreach (var type in types)
            //            {
            //                if (type.FullName == "FormForgetPassLib.FormForgetPass")
            //                {

            //                    Form frmRegis = Activator.CreateInstance(type) as Form;
            //                    frmRegis.ShowDialog();
            //                }
            //            }
            //        }

            //    }
            //}

            //Assembly assembly = Assembly.LoadFile($"{Application.StartupPath}/FormForgetPassLib.dll");
            //Type type = assembly.GetType("FormForgetPassLib.FormForgetPass");
            //Form frmForgetPass = Activator.CreateInstance(type) as Form;
            //frmForgetPass.ShowDialog();
        }
    }
}

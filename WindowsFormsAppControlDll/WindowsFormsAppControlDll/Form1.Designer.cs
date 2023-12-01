namespace WindowsFormsAppControlDll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegis = new System.Windows.Forms.Button();
            this.BtnForgetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(45, 57);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 45);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.Location = new System.Drawing.Point(126, 57);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(108, 45);
            this.btnRegis.TabIndex = 1;
            this.btnRegis.Text = "Register";
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // BtnForgetPass
            // 
            this.BtnForgetPass.Location = new System.Drawing.Point(240, 57);
            this.BtnForgetPass.Name = "BtnForgetPass";
            this.BtnForgetPass.Size = new System.Drawing.Size(136, 45);
            this.BtnForgetPass.TabIndex = 2;
            this.BtnForgetPass.Text = "ForgetPassword";
            this.BtnForgetPass.UseVisualStyleBackColor = true;
            this.BtnForgetPass.Click += new System.EventHandler(this.BtnForgetPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 170);
            this.Controls.Add(this.BtnForgetPass);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormControlDll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button BtnForgetPass;
    }
}


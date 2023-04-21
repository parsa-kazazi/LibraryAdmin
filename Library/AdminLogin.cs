using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                this.Close();
                MessageBox.Show("لطفا نام کاربری را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                this.Close();
                MessageBox.Show("لطفا گذرواژه را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtUserName.Text == "admin" && txtPassword.Text == "admin123")
                {
                    this.Close();
                    MainForm.isLogined = true;
                    MessageBox.Show("مدیر، خوش آمدید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Close();
                    MainForm.loginFailed++;
                    MessageBox.Show("نام کاربری یا گذرواژه نادرست است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("Shabnam.ttf");
            this.Font = new Font(font.Families[0], 12, FontStyle.Regular);
        }

        private void ChkShowPass_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '●';
        }
    }
}

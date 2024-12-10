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
    public partial class EditUser : Form
    {
        string setUserCode, setFirstName, setLastName, setNationalCode, setPhone, setAddress, setPicture;
        public bool cancel;

        private void EditUser_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13)
            {
                this.Close();
            }
            else if ((int)e.KeyCode == 27)
            {
                this.Close();
                cancel = true;
            }
        }

        private void BtnCloseEditUser_Click(object sender, EventArgs e)
        {
            this.Close();
            cancel = true;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            txtEditUserCode.Text = setUserCode;
            txtEditFirstName.Text = setFirstName;
            txtEditLastName.Text = setLastName;
            txtEditNationalCode.Text = setNationalCode;
            txtEditPhone.Text = setPhone;
            txtEditAddress.Text = setAddress;
            picEditUser.ImageLocation = setPicture;

            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("CircularSpArab-Book.ttf");
            this.Font = new Font(font.Families[0], 12, FontStyle.Regular);
        }

        public EditUser(string userCode, string firstName, string lastName, string nationalCode, string phone, string address, string picture)
        {
            InitializeComponent();

            setUserCode = userCode;
            setFirstName = firstName;
            setLastName = lastName;
            setNationalCode = nationalCode;
            setPhone = phone;
            setAddress = address;
            setPicture = picture;
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditChooseUserPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "انتخاب تصویر";
            openDialog.ShowDialog();

            picEditUser.ImageLocation = openDialog.FileName;
        }

        public string[] GetValues()
        {
            string[] values = {txtEditUserCode.Text, txtEditFirstName.Text, txtEditLastName.Text, txtEditNationalCode.Text, txtEditPhone.Text, txtEditAddress.Text, picEditUser.ImageLocation};
            return values;
        }
    }
}

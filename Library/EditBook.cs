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
    public partial class EditBook : Form
    {
        string setBookName, setOwner, setTranslator, setPublishier, setSubject, setShabak, setYear, setPicture;

        private void EditBook_KeyDown(object sender, KeyEventArgs e)
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

        public bool cancel;

        private void BtnCloseEditBook_Click(object sender, EventArgs e)
        {
            this.Close();
            cancel = true;
        }

        public EditBook(string bookName, string owner, string translator, string publishier, string subject, string shabak, string year, string picture)
        {
            InitializeComponent();

            setBookName = bookName;
            setOwner = owner;
            setTranslator = translator;
            setPublishier = publishier;
            setSubject = subject;
            setShabak = shabak;
            setYear = year;
            setPicture = picture;
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            txtEditBookName.Text = setBookName;
            txtEditOwnerName.Text = setOwner;
            txtEditTranslator.Text = setTranslator;
            txtEditPublisher.Text = setPublishier;
            txtEditSubject.Text = setSubject;
            txtEditShabak.Text = setShabak;
            picEditBook.ImageLocation = setPicture;

            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("CircularSpArab-Book.ttf");
            this.Font = new Font(font.Families[0], 12, FontStyle.Regular);
        }

        private void BtnEditChooseBookPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "انتخاب تصویر";
            openDialog.ShowDialog();

            picEditBook.ImageLocation = openDialog.FileName;
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] GetValues()
        {
            string[] values = { txtEditBookName.Text, txtEditOwnerName.Text, txtEditTranslator.Text, txtEditPublisher.Text, txtEditSubject.Text, txtEditShabak.Text, comboBoxEditYear.Text, picEditBook.ImageLocation };
            return values;
        }
    }
}

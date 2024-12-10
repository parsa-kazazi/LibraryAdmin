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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile("CircularSpArab-Book.ttf");
            this.Font = new Font(font.Families[0], 12, FontStyle.Regular);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto://parsa-kazazi@protonmail.com");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/parsa-kazazi/");
        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == 13 || (int)e.KeyCode == 27)
                this.Close();
        }
    }
}

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
            font.AddFontFile("Shabnam.ttf");
            this.Font = new Font(font.Families[0], 12, FontStyle.Regular);
        }
    }
}

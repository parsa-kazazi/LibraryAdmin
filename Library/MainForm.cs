using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library
{
    public partial class MainForm : Form
    {
        public static int loginFailed = 0;
        public static bool isLogined = false;
        private int tryLogin = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.booksDataSet.Books);
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

            this.Text = " کتابخانه ─ " + DateTime.Now.ToString();
        }

        private void Login()
        {
            if (loginFailed == 3)
                MessageBox.Show("شما اجازه وارد شدن را ندارید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                tryLogin++;

                AdminLogin frmAdminLogin = new AdminLogin();
                frmAdminLogin.ShowDialog();

                if (isLogined)
                {
                    this.lblUserName.Text = "مدیر";
                    File.AppendAllText("Log.txt", DateTime.Now.ToString() + " : Admin logined");
                    File.AppendAllText("Log.txt", "\n");
                    btnGetLog.Visible = true;
                }
                else if (tryLogin == 3 && loginFailed == 3)
                    timer1.Start();
            }
        }

        private void ToolStripLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void ToolStripColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            this.ForeColor = colorDialog.Color;
        }

        private void ToolStripFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();

            this.Font = fontDialog.Font;
        }

        private void ToolStripHelp_Click(object sender, EventArgs e)
        {
            About frmAbout = new About();
            frmAbout.ShowDialog();
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مایل به خروج هستید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBookName.Text == "" && txtSearchOwnerName.Text == "" && txtSearchSubject.Text == "" && comboBoxSearchYear.Text == "")
                MessageBox.Show("چیزی برای جستجو وارد نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                txtSearchBookName.Text = txtSearchBookName.Text.Trim();
                txtSearchOwnerName.Text = txtSearchOwnerName.Text.Trim();
                txtSearchSubject.Text = txtSearchSubject.Text.Trim();

                if (radioBookName.Checked)
                {
                    txtSearchOwnerName.Text = txtSearchSubject.Text = "";
                    comboBoxSearchYear.SelectedItem = null;
                }
                else if (radioOwnerName.Checked)
                {
                    txtSearchBookName.Text = txtSearchSubject.Text = "";
                    comboBoxSearchYear.SelectedItem = null;
                }
                else if (radioSubject.Checked)
                {
                    txtSearchBookName.Text = txtOwnerName.Text = "";
                    comboBoxSearchYear.SelectedItem = null;
                }
                else if (radioYear.Checked)
                {
                    txtSearchBookName.Text = txtSearchOwnerName.Text = txtSearchSubject.Text = "";
                }

                int year;

                if (comboBoxSearchYear.Text == "")
                    year = 0;
                else
                    year = Convert.ToInt32(comboBoxSearchYear.Text);

                DataTable result = booksTableAdapter.GetDataBy(txtSearchBookName.Text, txtSearchOwnerName.Text, txtSearchSubject.Text, year);
                dgvSearch.DataSource = result;
            }
        }

        private void BtnGetLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveDialog = new FolderBrowserDialog();
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.SelectedPath + @"\Log.txt", File.ReadAllText("Log.txt"));
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            txtSearchBookName.Text = txtSearchOwnerName.Text = txtSearchSubject.Text = "";
            comboBoxSearchYear.SelectedItem = null;
        }

        private void ValidiateOpenTab()
        {
            if (!isLogined)
            {
                MessageBox.Show("شما به این بخش دسترسی ندارید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl1.SelectTab(tabSearch);
            }
        }

        private void TabUsers_Enter(object sender, EventArgs e)
        {
            ValidiateOpenTab();
        }

        private void TabBook_Enter(object sender, EventArgs e)
        {
            ValidiateOpenTab();
        }

        private void TabShowUsers_Enter(object sender, EventArgs e)
        {
            ValidiateOpenTab();
        }

        private void TabShowBooks_Enter(object sender, EventArgs e)
        {
            ValidiateOpenTab();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loginFailed = 0;
            tryLogin = 0;
        }

        private void BtnChooseUserPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "انتخاب تصویر";
            openDialog.ShowDialog();

            picUser.ImageLocation = openDialog.FileName;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            bool success = true;

            try
            {
                usersTableAdapter.InsertQuery(txtFirstName.Text, txtLastName.Text, txtNationalCode.Text, txtPhone.Text, txtAddress.Text, picUser.ImageLocation, Convert.ToInt32(txtUserCode.Text));
                usersTableAdapter.Fill(usersDataSet.Users);
            }
            catch
            {
                MessageBox.Show("عضو ثبت نشد. جزییات:" + e, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            if (success)
            {
                MessageBox.Show("عضو ثبت شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            txtUserCode.Text = txtFirstName.Text = txtLastName.Text = txtNationalCode.Text = txtPhone.Text = txtAddress.Text = "";
            picUser.Image = Library.Properties.Resources.UserIcon;
        }

        private void BtnChooseBookPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "انتخاب تصویر";
            openDialog.ShowDialog();

            picBook.ImageLocation = openDialog.FileName;
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            bool success = true;

            int year;

            if (comboBoxYear.Text == "")
                year = 0;
            else
                year = Convert.ToInt32(comboBoxYear.Text);

            try
            {
                booksTableAdapter.InsertQuery(txtBookName.Text, txtOwnerName.Text, txtTranslator.Text, txtPublisher.Text, txtSubject.Text, txtShabak.Text, year, picBook.ImageLocation);
                booksTableAdapter.Fill(booksDataSet.Books);
            }
            catch
            {
                MessageBox.Show("کتاب ثبت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            if (success)
            {
                MessageBox.Show("کتاب ثبت شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            txtBookName.Text = txtOwnerName.Text = txtTranslator.Text = txtPublisher.Text = txtSubject.Text = txtShabak.Text = "";
            picBook.Image = Library.Properties.Resources.BookIcon;
        }

        private void TxtOwnerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter((char)e.KeyChar) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void TsbEditUser_Click(object sender, EventArgs e)
        {
            bool success = true;

            EditUser frmEditUser = new EditUser(dgvUsers.CurrentRow.Cells[1].Value.ToString(),
                dgvUsers.CurrentRow.Cells[2].Value.ToString(),
                dgvUsers.CurrentRow.Cells[3].Value.ToString(),
                dgvUsers.CurrentRow.Cells[4].Value.ToString(),
                dgvUsers.CurrentRow.Cells[5].Value.ToString(),
                dgvUsers.CurrentRow.Cells[6].Value.ToString(),
                dgvUsers.CurrentRow.Cells[7].Value.ToString());

            frmEditUser.ShowDialog();

            string[] values = frmEditUser.GetValues();

            try
            {
                usersTableAdapter.UpdateQuery(values[0], values[1], values[2], values[3], values[4], values[5], Convert.ToInt32(values[6]), Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
                usersTableAdapter.Fill(usersDataSet.Users);
            }
            catch
            {
                MessageBox.Show("عضو ویرایش نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            if (success)
            {
                MessageBox.Show("عضو ویرایش شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TsbDeleteUser_Click(object sender, EventArgs e)
        {
            bool success = true;

            if (MessageBox.Show("حذف عضو؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    usersTableAdapter.DeleteQuery(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
                    usersTableAdapter.Fill(usersDataSet.Users);
                }
                catch
                {
                    MessageBox.Show("عضو حذف نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }

                if (success)
                {
                    MessageBox.Show("عضو حذف شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TsbEditBook_Click(object sender, EventArgs e)
        {
            bool success = true;

            EditBook frmEditBook = new EditBook(dgvBooks.CurrentRow.Cells[1].Value.ToString(),
                dgvBooks.CurrentRow.Cells[2].Value.ToString(),
                dgvBooks.CurrentRow.Cells[3].Value.ToString(),
                dgvBooks.CurrentRow.Cells[4].Value.ToString(),
                dgvBooks.CurrentRow.Cells[5].Value.ToString(),
                dgvBooks.CurrentRow.Cells[6].Value.ToString(),
                dgvBooks.CurrentRow.Cells[7].Value.ToString(),
                dgvBooks.CurrentRow.Cells[8].Value.ToString());

            frmEditBook.ShowDialog();

            string[] values = frmEditBook.GetValues();

            try
            {
                booksTableAdapter.UpdateQuery(values[0], values[1], values[2], values[3], values[4], values[5], Convert.ToInt32(values[6]), values[7], Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value));
                booksTableAdapter.Fill(booksDataSet.Books);
            }
            catch
            {
                MessageBox.Show("کتاب ویرایش نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            if (success)
            {
                MessageBox.Show("کتاب ویرایش شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TsbDeleteBook_Click(object sender, EventArgs e)
        {
            bool success = true;

            if (MessageBox.Show("حذف کتاب؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    booksTableAdapter.DeleteQuery(Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value));
                    booksTableAdapter.Fill(booksDataSet.Books);
                }
                catch
                {
                    MessageBox.Show("کتاب حذف نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }

                if (success)
                {
                    MessageBox.Show("کتاب حذف شد", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

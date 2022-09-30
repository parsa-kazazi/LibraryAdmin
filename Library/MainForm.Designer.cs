namespace Library
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnGetLog = new System.Windows.Forms.Button();
            this.comboBoxSearchYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.txtSearchOwnerName = new System.Windows.Forms.TextBox();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioYear = new System.Windows.Forms.RadioButton();
            this.radioSubject = new System.Windows.Forms.RadioButton();
            this.radioOwnerName = new System.Windows.Forms.RadioButton();
            this.radioBookName = new System.Windows.Forms.RadioButton();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnChooseUserPicture = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.tabBook = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnChooseBookPicture = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtShabak = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTranslator = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.tabShowUsers = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEditUser = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new Library.UsersDataSet();
            this.tabShowBooks = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbEditBook = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteBook = new System.Windows.Forms.ToolStripButton();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shabakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new Library.BooksDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.usersTableAdapter = new Library.UsersDataSetTableAdapters.UsersTableAdapter();
            this.booksTableAdapter = new Library.BooksDataSetTableAdapters.BooksTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.tabBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.tabShowUsers.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.tabShowBooks.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabBook);
            this.tabControl1.Controls.Add(this.tabShowUsers);
            this.tabControl1.Controls.Add(this.tabShowBooks);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.White;
            this.tabSearch.Controls.Add(this.dgvSearch);
            this.tabSearch.Controls.Add(this.btnGetLog);
            this.tabSearch.Controls.Add(this.comboBoxSearchYear);
            this.tabSearch.Controls.Add(this.label2);
            this.tabSearch.Controls.Add(this.btnErase);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.txtSearchSubject);
            this.tabSearch.Controls.Add(this.txtSearchOwnerName);
            this.tabSearch.Controls.Add(this.txtSearchBookName);
            this.tabSearch.Controls.Add(this.label6);
            this.tabSearch.Controls.Add(this.label5);
            this.tabSearch.Controls.Add(this.label4);
            this.tabSearch.Controls.Add(this.label3);
            this.tabSearch.Controls.Add(this.radioYear);
            this.tabSearch.Controls.Add(this.radioSubject);
            this.tabSearch.Controls.Add(this.radioOwnerName);
            this.tabSearch.Controls.Add(this.radioBookName);
            this.tabSearch.Controls.Add(this.btnAdminLogin);
            this.tabSearch.Controls.Add(this.lblUserName);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Location = new System.Drawing.Point(4, 27);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(876, 456);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "جستجو";
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(108, 155);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(437, 243);
            this.dgvSearch.TabIndex = 21;
            // 
            // btnGetLog
            // 
            this.btnGetLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(112)))));
            this.btnGetLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLog.ForeColor = System.Drawing.Color.White;
            this.btnGetLog.Location = new System.Drawing.Point(104, 6);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(110, 30);
            this.btnGetLog.TabIndex = 20;
            this.btnGetLog.Text = "دریافت پرونده";
            this.btnGetLog.UseVisualStyleBackColor = false;
            this.btnGetLog.Visible = false;
            this.btnGetLog.Click += new System.EventHandler(this.BtnGetLog_Click);
            // 
            // comboBoxSearchYear
            // 
            this.comboBoxSearchYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchYear.FormattingEnabled = true;
            this.comboBoxSearchYear.Items.AddRange(new object[] {
            "1401",
            "1400",
            "1399",
            "1398",
            "1397",
            "1396",
            "1395",
            "1394",
            "1393",
            "1392",
            "1391",
            "1390"});
            this.comboBoxSearchYear.Location = new System.Drawing.Point(630, 297);
            this.comboBoxSearchYear.Name = "comboBoxSearchYear";
            this.comboBoxSearchYear.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSearchYear.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "جستجو بر اساس";
            // 
            // btnErase
            // 
            this.btnErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.ForeColor = System.Drawing.Color.White;
            this.btnErase.Location = new System.Drawing.Point(595, 346);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 30);
            this.btnErase.TabIndex = 17;
            this.btnErase.Text = "پاک کردن";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(676, 346);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearchSubject.Location = new System.Drawing.Point(551, 265);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(200, 26);
            this.txtSearchSubject.TabIndex = 14;
            // 
            // txtSearchOwnerName
            // 
            this.txtSearchOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOwnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearchOwnerName.Location = new System.Drawing.Point(551, 233);
            this.txtSearchOwnerName.Name = "txtSearchOwnerName";
            this.txtSearchOwnerName.Size = new System.Drawing.Size(200, 26);
            this.txtSearchOwnerName.TabIndex = 13;
            // 
            // txtSearchBookName
            // 
            this.txtSearchBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearchBookName.Location = new System.Drawing.Point(551, 201);
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.Size = new System.Drawing.Size(200, 26);
            this.txtSearchBookName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(757, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "سال چاپ:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "موضوع:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "نام مولف:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "نام کتاب:";
            // 
            // radioYear
            // 
            this.radioYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioYear.AutoSize = true;
            this.radioYear.Location = new System.Drawing.Point(408, 127);
            this.radioYear.Name = "radioYear";
            this.radioYear.Size = new System.Drawing.Size(86, 22);
            this.radioYear.TabIndex = 7;
            this.radioYear.Text = "سال چاپ";
            this.radioYear.UseVisualStyleBackColor = true;
            // 
            // radioSubject
            // 
            this.radioSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioSubject.AutoSize = true;
            this.radioSubject.Location = new System.Drawing.Point(520, 127);
            this.radioSubject.Name = "radioSubject";
            this.radioSubject.Size = new System.Drawing.Size(69, 22);
            this.radioSubject.TabIndex = 6;
            this.radioSubject.Text = "موضوع";
            this.radioSubject.UseVisualStyleBackColor = true;
            // 
            // radioOwnerName
            // 
            this.radioOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioOwnerName.AutoSize = true;
            this.radioOwnerName.Location = new System.Drawing.Point(615, 127);
            this.radioOwnerName.Name = "radioOwnerName";
            this.radioOwnerName.Size = new System.Drawing.Size(81, 22);
            this.radioOwnerName.TabIndex = 5;
            this.radioOwnerName.Text = "نام مولف";
            this.radioOwnerName.UseVisualStyleBackColor = true;
            // 
            // radioBookName
            // 
            this.radioBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBookName.AutoSize = true;
            this.radioBookName.Checked = true;
            this.radioBookName.Location = new System.Drawing.Point(722, 127);
            this.radioBookName.Name = "radioBookName";
            this.radioBookName.Size = new System.Drawing.Size(76, 22);
            this.radioBookName.TabIndex = 4;
            this.radioBookName.TabStop = true;
            this.radioBookName.Text = "نام کتاب";
            this.radioBookName.UseVisualStyleBackColor = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(112)))));
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(8, 6);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(90, 30);
            this.btnAdminLogin.TabIndex = 2;
            this.btnAdminLogin.Text = "ورود مدیر";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.BtnAdminLogin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.SystemColors.Window;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.lblUserName.Location = new System.Drawing.Point(749, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "میهمان";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربر:";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.White;
            this.tabUsers.Controls.Add(this.picUser);
            this.tabUsers.Controls.Add(this.btnNewUser);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.btnChooseUserPicture);
            this.tabUsers.Controls.Add(this.label12);
            this.tabUsers.Controls.Add(this.label11);
            this.tabUsers.Controls.Add(this.label10);
            this.tabUsers.Controls.Add(this.label9);
            this.tabUsers.Controls.Add(this.label8);
            this.tabUsers.Controls.Add(this.label7);
            this.tabUsers.Controls.Add(this.txtAddress);
            this.tabUsers.Controls.Add(this.txtPhone);
            this.tabUsers.Controls.Add(this.txtLastName);
            this.tabUsers.Controls.Add(this.txtNationalCode);
            this.tabUsers.Controls.Add(this.txtFirstName);
            this.tabUsers.Controls.Add(this.txtUserCode);
            this.tabUsers.Location = new System.Drawing.Point(4, 27);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(876, 456);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "اعضا";
            this.tabUsers.Enter += new System.EventHandler(this.TabUsers_Enter);
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(54, 100);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(90, 90);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 17;
            this.picUser.TabStop = false;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(54, 318);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(90, 30);
            this.btnNewUser.TabIndex = 16;
            this.btnNewUser.Text = "عضو جدید";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(112)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(54, 282);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(90, 30);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "ثبت عضو";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnChooseUserPicture
            // 
            this.btnChooseUserPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(112)))));
            this.btnChooseUserPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseUserPicture.ForeColor = System.Drawing.Color.White;
            this.btnChooseUserPicture.Location = new System.Drawing.Point(54, 246);
            this.btnChooseUserPicture.Name = "btnChooseUserPicture";
            this.btnChooseUserPicture.Size = new System.Drawing.Size(90, 30);
            this.btnChooseUserPicture.TabIndex = 14;
            this.btnChooseUserPicture.Text = "درج تصویر";
            this.btnChooseUserPicture.UseVisualStyleBackColor = false;
            this.btnChooseUserPicture.Click += new System.EventHandler(this.BtnChooseUserPicture_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(773, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "نشانی:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(773, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "کد ملی:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(773, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "تلفن:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(773, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "نام خوانوادگی:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(773, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "نام:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(773, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "کد عضویت:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(467, 228);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(300, 100);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(567, 196);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 26);
            this.txtPhone.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(567, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalCode.Location = new System.Drawing.Point(567, 164);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(200, 26);
            this.txtNationalCode.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(567, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserCode.Location = new System.Drawing.Point(567, 68);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(200, 26);
            this.txtUserCode.TabIndex = 0;
            // 
            // tabBook
            // 
            this.tabBook.BackColor = System.Drawing.Color.White;
            this.tabBook.Controls.Add(this.label19);
            this.tabBook.Controls.Add(this.comboBoxYear);
            this.tabBook.Controls.Add(this.txtOwnerName);
            this.tabBook.Controls.Add(this.btnNewBook);
            this.tabBook.Controls.Add(this.btnAddBook);
            this.tabBook.Controls.Add(this.btnChooseBookPicture);
            this.tabBook.Controls.Add(this.label18);
            this.tabBook.Controls.Add(this.txtShabak);
            this.tabBook.Controls.Add(this.label13);
            this.tabBook.Controls.Add(this.label14);
            this.tabBook.Controls.Add(this.label15);
            this.tabBook.Controls.Add(this.label16);
            this.tabBook.Controls.Add(this.label17);
            this.tabBook.Controls.Add(this.txtSubject);
            this.tabBook.Controls.Add(this.txtTranslator);
            this.tabBook.Controls.Add(this.txtPublisher);
            this.tabBook.Controls.Add(this.txtBookName);
            this.tabBook.Controls.Add(this.picBook);
            this.tabBook.Location = new System.Drawing.Point(4, 27);
            this.tabBook.Name = "tabBook";
            this.tabBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabBook.Size = new System.Drawing.Size(876, 456);
            this.tabBook.TabIndex = 2;
            this.tabBook.Text = "کتاب";
            this.tabBook.Enter += new System.EventHandler(this.TabBook_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(788, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 18);
            this.label19.TabIndex = 30;
            this.label19.Text = "سال چاپ:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1401",
            "1400",
            "1399",
            "1398",
            "1397",
            "1396",
            "1395",
            "1394",
            "1393",
            "1392",
            "1391",
            "1390"});
            this.comboBoxYear.Location = new System.Drawing.Point(661, 282);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 26);
            this.comboBoxYear.TabIndex = 29;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOwnerName.Location = new System.Drawing.Point(582, 123);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(200, 26);
            this.txtOwnerName.TabIndex = 28;
            this.txtOwnerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOwnerName_KeyPress);
            // 
            // btnNewBook
            // 
            this.btnNewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            this.btnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBook.ForeColor = System.Drawing.Color.White;
            this.btnNewBook.Location = new System.Drawing.Point(54, 314);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(90, 30);
            this.btnNewBook.TabIndex = 26;
            this.btnNewBook.Text = "کتاب جدید";
            this.btnNewBook.UseVisualStyleBackColor = false;
            this.btnNewBook.Click += new System.EventHandler(this.BtnNewBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(112)))));
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(54, 278);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(90, 30);
            this.btnAddBook.TabIndex = 25;
            this.btnAddBook.Text = "ثبت کتاب";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // btnChooseBookPicture
            // 
            this.btnChooseBookPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(112)))));
            this.btnChooseBookPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseBookPicture.ForeColor = System.Drawing.Color.White;
            this.btnChooseBookPicture.Location = new System.Drawing.Point(54, 242);
            this.btnChooseBookPicture.Name = "btnChooseBookPicture";
            this.btnChooseBookPicture.Size = new System.Drawing.Size(90, 30);
            this.btnChooseBookPicture.TabIndex = 24;
            this.btnChooseBookPicture.Text = "درج تصویر";
            this.btnChooseBookPicture.UseVisualStyleBackColor = false;
            this.btnChooseBookPicture.Click += new System.EventHandler(this.BtnChooseBookPicture_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(788, 253);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 18);
            this.label18.TabIndex = 23;
            this.label18.Text = "شابک:";
            // 
            // txtShabak
            // 
            this.txtShabak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShabak.Location = new System.Drawing.Point(482, 250);
            this.txtShabak.Name = "txtShabak";
            this.txtShabak.Size = new System.Drawing.Size(300, 26);
            this.txtShabak.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(788, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "انتشارات:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(788, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "موضوع:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(788, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 19;
            this.label15.Text = "مترجم:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(788, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 18);
            this.label16.TabIndex = 18;
            this.label16.Text = "مولف:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(788, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "نام کتاب:";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(582, 219);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 26);
            this.txtSubject.TabIndex = 16;
            // 
            // txtTranslator
            // 
            this.txtTranslator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTranslator.Location = new System.Drawing.Point(582, 155);
            this.txtTranslator.Name = "txtTranslator";
            this.txtTranslator.Size = new System.Drawing.Size(200, 26);
            this.txtTranslator.TabIndex = 15;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Location = new System.Drawing.Point(582, 187);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(200, 26);
            this.txtPublisher.TabIndex = 14;
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Location = new System.Drawing.Point(582, 91);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 26);
            this.txtBookName.TabIndex = 12;
            // 
            // picBook
            // 
            this.picBook.Image = ((System.Drawing.Image)(resources.GetObject("picBook.Image")));
            this.picBook.Location = new System.Drawing.Point(54, 91);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(90, 90);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBook.TabIndex = 27;
            this.picBook.TabStop = false;
            // 
            // tabShowUsers
            // 
            this.tabShowUsers.BackColor = System.Drawing.Color.White;
            this.tabShowUsers.Controls.Add(this.toolStrip1);
            this.tabShowUsers.Controls.Add(this.dgvUsers);
            this.tabShowUsers.Location = new System.Drawing.Point(4, 27);
            this.tabShowUsers.Name = "tabShowUsers";
            this.tabShowUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowUsers.Size = new System.Drawing.Size(876, 456);
            this.tabShowUsers.TabIndex = 3;
            this.tabShowUsers.Text = "نمایش اعضا";
            this.tabShowUsers.Enter += new System.EventHandler(this.TabShowUsers_Enter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditUser,
            this.tsbDeleteUser});
            this.toolStrip1.Location = new System.Drawing.Point(3, 428);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(870, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbEditUser
            // 
            this.tsbEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditUser.Image")));
            this.tsbEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditUser.Name = "tsbEditUser";
            this.tsbEditUser.Size = new System.Drawing.Size(78, 22);
            this.tsbEditUser.Text = "ویرایش عضو";
            this.tsbEditUser.Click += new System.EventHandler(this.TsbEditUser_Click);
            // 
            // tsbDeleteUser
            // 
            this.tsbDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteUser.Image")));
            this.tsbDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteUser.Name = "tsbDeleteUser";
            this.tsbDeleteUser.Size = new System.Drawing.Size(67, 22);
            this.tsbDeleteUser.Text = "حذف عضو";
            this.tsbDeleteUser.Click += new System.EventHandler(this.TsbDeleteUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.userCodeDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.nationalCodeDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.pictureDataGridViewTextBoxColumn1});
            this.dgvUsers.DataSource = this.usersBindingSource;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(870, 450);
            this.dgvUsers.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userCodeDataGridViewTextBoxColumn1
            // 
            this.userCodeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userCodeDataGridViewTextBoxColumn1.DataPropertyName = "UserCode";
            this.userCodeDataGridViewTextBoxColumn1.HeaderText = "کد عضو";
            this.userCodeDataGridViewTextBoxColumn1.Name = "userCodeDataGridViewTextBoxColumn1";
            this.userCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "نام";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "نام خوانوادگی";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nationalCodeDataGridViewTextBoxColumn1
            // 
            this.nationalCodeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nationalCodeDataGridViewTextBoxColumn1.DataPropertyName = "NationalCode";
            this.nationalCodeDataGridViewTextBoxColumn1.HeaderText = "کد ملی";
            this.nationalCodeDataGridViewTextBoxColumn1.Name = "nationalCodeDataGridViewTextBoxColumn1";
            this.nationalCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "تلفن";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "نشانی";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pictureDataGridViewTextBoxColumn1
            // 
            this.pictureDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pictureDataGridViewTextBoxColumn1.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn1.HeaderText = "تصویر";
            this.pictureDataGridViewTextBoxColumn1.Name = "pictureDataGridViewTextBoxColumn1";
            this.pictureDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabShowBooks
            // 
            this.tabShowBooks.BackColor = System.Drawing.Color.White;
            this.tabShowBooks.Controls.Add(this.toolStrip2);
            this.tabShowBooks.Controls.Add(this.dgvBooks);
            this.tabShowBooks.Location = new System.Drawing.Point(4, 27);
            this.tabShowBooks.Name = "tabShowBooks";
            this.tabShowBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowBooks.Size = new System.Drawing.Size(876, 456);
            this.tabShowBooks.TabIndex = 4;
            this.tabShowBooks.Text = "نمایش کتاب ها";
            this.tabShowBooks.Enter += new System.EventHandler(this.TabShowBooks_Enter);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditBook,
            this.tsbDeleteBook});
            this.toolStrip2.Location = new System.Drawing.Point(3, 428);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(870, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbEditBook
            // 
            this.tsbEditBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditBook.Image")));
            this.tsbEditBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditBook.Name = "tsbEditBook";
            this.tsbEditBook.Size = new System.Drawing.Size(80, 22);
            this.tsbEditBook.Text = "ویرایش کتاب";
            this.tsbEditBook.Click += new System.EventHandler(this.TsbEditBook_Click);
            // 
            // tsbDeleteBook
            // 
            this.tsbDeleteBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteBook.Image")));
            this.tsbDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteBook.Name = "tsbDeleteBook";
            this.tsbDeleteBook.Size = new System.Drawing.Size(69, 22);
            this.tsbDeleteBook.Text = "حذف کتاب";
            this.tsbDeleteBook.Click += new System.EventHandler(this.TsbDeleteBook_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoGenerateColumns = false;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.translatorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.shabakDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn});
            this.dgvBooks.DataSource = this.booksBindingSource;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 3);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(870, 450);
            this.dgvBooks.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "نام کتاب";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "مولف";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // translatorDataGridViewTextBoxColumn
            // 
            this.translatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.translatorDataGridViewTextBoxColumn.DataPropertyName = "Translator";
            this.translatorDataGridViewTextBoxColumn.HeaderText = "مترجم";
            this.translatorDataGridViewTextBoxColumn.Name = "translatorDataGridViewTextBoxColumn";
            this.translatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "ناشر";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "موضوع";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shabakDataGridViewTextBoxColumn
            // 
            this.shabakDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shabakDataGridViewTextBoxColumn.DataPropertyName = "Shabak";
            this.shabakDataGridViewTextBoxColumn.HeaderText = "شابک";
            this.shabakDataGridViewTextBoxColumn.Name = "shabakDataGridViewTextBoxColumn";
            this.shabakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "سال چاپ";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "تصویر";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.booksDataSet;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripHelp,
            this.toolStripExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLogin});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "مدیر";
            // 
            // toolStripLogin
            // 
            this.toolStripLogin.Name = "toolStripLogin";
            this.toolStripLogin.Size = new System.Drawing.Size(180, 22);
            this.toolStripLogin.Text = "ورود";
            this.toolStripLogin.Click += new System.EventHandler(this.ToolStripLogin_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripColor,
            this.toolStripFont});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem2.Text = "ویرایش";
            // 
            // toolStripColor
            // 
            this.toolStripColor.Name = "toolStripColor";
            this.toolStripColor.Size = new System.Drawing.Size(180, 22);
            this.toolStripColor.Text = "رنگ";
            this.toolStripColor.Click += new System.EventHandler(this.ToolStripColor_Click);
            // 
            // toolStripFont
            // 
            this.toolStripFont.Name = "toolStripFont";
            this.toolStripFont.Size = new System.Drawing.Size(180, 22);
            this.toolStripFont.Text = "فونت";
            this.toolStripFont.Click += new System.EventHandler(this.ToolStripFont_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(54, 20);
            this.toolStripHelp.Text = "راهنما";
            this.toolStripHelp.Click += new System.EventHandler(this.ToolStripHelp_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(47, 20);
            this.toolStripExit.Text = "خروج";
            this.toolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.tabBook.ResumeLayout(false);
            this.tabBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.tabShowUsers.ResumeLayout(false);
            this.tabShowUsers.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.tabShowBooks.ResumeLayout(false);
            this.tabShowBooks.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.RadioButton radioYear;
        private System.Windows.Forms.RadioButton radioSubject;
        private System.Windows.Forms.RadioButton radioOwnerName;
        private System.Windows.Forms.RadioButton radioBookName;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private System.Windows.Forms.TextBox txtSearchOwnerName;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnChooseUserPicture;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnChooseBookPicture;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtShabak;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTranslator;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripLogin;
        private System.Windows.Forms.ToolStripMenuItem toolStripColor;
        private System.Windows.Forms.ToolStripMenuItem toolStripFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchYear;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TabPage tabShowUsers;
        private System.Windows.Forms.TabPage tabShowBooks;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ToolStripButton tsbEditUser;
        private System.Windows.Forms.ToolStripButton tsbDeleteUser;
        private System.Windows.Forms.ToolStripButton tsbEditBook;
        private System.Windows.Forms.ToolStripButton tsbDeleteBook;
        private System.Windows.Forms.Button btnGetLog;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BooksDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shabakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
    }
}
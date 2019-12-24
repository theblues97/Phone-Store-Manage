namespace PhoneStore
{
    partial class ManageEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployees));
            this.pnlME = new System.Windows.Forms.Panel();
            this.tabMEMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.txtSearchEmp = new System.Windows.Forms.TextBox();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.datBirth = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pnlContract = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datStart = new System.Windows.Forms.DateTimePicker();
            this.cbbContract = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvME = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlToolMenu = new System.Windows.Forms.Panel();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlME.SuspendLayout();
            this.tabMEMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlInformation.SuspendLayout();
            this.pnlContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvME)).BeginInit();
            this.pnlToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlME
            // 
            this.pnlME.Controls.Add(this.tabMEMain);
            this.pnlME.Controls.Add(this.pnlToolMenu);
            this.pnlME.Controls.Add(this.label1);
            this.pnlME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlME.Location = new System.Drawing.Point(0, 0);
            this.pnlME.Name = "pnlME";
            this.pnlME.Size = new System.Drawing.Size(1038, 593);
            this.pnlME.TabIndex = 46;
            // 
            // tabMEMain
            // 
            this.tabMEMain.Controls.Add(this.tabPage1);
            this.tabMEMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMEMain.Location = new System.Drawing.Point(3, 80);
            this.tabMEMain.Name = "tabMEMain";
            this.tabMEMain.SelectedIndex = 0;
            this.tabMEMain.Size = new System.Drawing.Size(1035, 512);
            this.tabMEMain.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEmpSearch);
            this.tabPage1.Controls.Add(this.txtSearchEmp);
            this.tabPage1.Controls.Add(this.pnlInformation);
            this.tabPage1.Controls.Add(this.pnlContract);
            this.tabPage1.Controls.Add(this.dgvME);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmpSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpSearch.BackgroundImage")));
            this.btnEmpSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpSearch.Location = new System.Drawing.Point(539, 10);
            this.btnEmpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(32, 32);
            this.btnEmpSearch.TabIndex = 22;
            this.btnEmpSearch.UseVisualStyleBackColor = false;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // txtSearchEmp
            // 
            this.txtSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmp.Location = new System.Drawing.Point(383, 16);
            this.txtSearchEmp.Name = "txtSearchEmp";
            this.txtSearchEmp.Size = new System.Drawing.Size(150, 21);
            this.txtSearchEmp.TabIndex = 21;
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.label13);
            this.pnlInformation.Controls.Add(this.radFemale);
            this.pnlInformation.Controls.Add(this.label8);
            this.pnlInformation.Controls.Add(this.txtSalary);
            this.pnlInformation.Controls.Add(this.radMale);
            this.pnlInformation.Controls.Add(this.datBirth);
            this.pnlInformation.Controls.Add(this.label12);
            this.pnlInformation.Controls.Add(this.label11);
            this.pnlInformation.Controls.Add(this.txtID);
            this.pnlInformation.Controls.Add(this.txtEmail);
            this.pnlInformation.Controls.Add(this.label15);
            this.pnlInformation.Controls.Add(this.label10);
            this.pnlInformation.Controls.Add(this.label9);
            this.pnlInformation.Controls.Add(this.txtAdress);
            this.pnlInformation.Controls.Add(this.txtName);
            this.pnlInformation.Controls.Add(this.label2);
            this.pnlInformation.Controls.Add(this.txtPhone);
            this.pnlInformation.Enabled = false;
            this.pnlInformation.Location = new System.Drawing.Point(615, 53);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(409, 205);
            this.pnlInformation.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Nhân viên";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(354, 41);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(41, 19);
            this.radFemale.TabIndex = 15;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lương";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(274, 80);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(121, 21);
            this.txtSalary.TabIndex = 12;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(296, 41);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(52, 19);
            this.radMale.TabIndex = 14;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // datBirth
            // 
            this.datBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBirth.Location = new System.Drawing.Point(80, 38);
            this.datBirth.Name = "datBirth";
            this.datBirth.Size = new System.Drawing.Size(104, 21);
            this.datBirth.TabIndex = 13;
            this.datBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Giới tính";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(315, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 21);
            this.txtID.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(80, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 21);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(267, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Mã NV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Địa chỉ";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(80, 157);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(259, 40);
            this.txtAdress.TabIndex = 17;
            this.txtAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(80, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 21);
            this.txtName.TabIndex = 10;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số đ.thoại";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(80, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(131, 21);
            this.txtPhone.TabIndex = 27;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // pnlContract
            // 
            this.pnlContract.Controls.Add(this.txtPassword);
            this.pnlContract.Controls.Add(this.label7);
            this.pnlContract.Controls.Add(this.cbbPosition);
            this.pnlContract.Controls.Add(this.label16);
            this.pnlContract.Controls.Add(this.txtUsername);
            this.pnlContract.Controls.Add(this.label6);
            this.pnlContract.Controls.Add(this.label5);
            this.pnlContract.Controls.Add(this.datEnd);
            this.pnlContract.Controls.Add(this.label4);
            this.pnlContract.Controls.Add(this.datStart);
            this.pnlContract.Controls.Add(this.cbbContract);
            this.pnlContract.Controls.Add(this.label3);
            this.pnlContract.Enabled = false;
            this.pnlContract.Location = new System.Drawing.Point(615, 283);
            this.pnlContract.Name = "pnlContract";
            this.pnlContract.Size = new System.Drawing.Size(410, 145);
            this.pnlContract.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(297, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(104, 21);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Password";
            // 
            // cbbPosition
            // 
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(294, 0);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(104, 23);
            this.cbbPosition.TabIndex = 45;
            this.cbbPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(218, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Chức vụ";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(80, 81);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(104, 21);
            this.txtUsername.TabIndex = 35;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngày k.thúc";
            // 
            // datEnd
            // 
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datEnd.Location = new System.Drawing.Point(294, 42);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(104, 21);
            this.datEnd.TabIndex = 33;
            this.datEnd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày b.đầu";
            // 
            // datStart
            // 
            this.datStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datStart.Location = new System.Drawing.Point(80, 41);
            this.datStart.Name = "datStart";
            this.datStart.Size = new System.Drawing.Size(104, 21);
            this.datStart.TabIndex = 31;
            this.datStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // cbbContract
            // 
            this.cbbContract.FormattingEnabled = true;
            this.cbbContract.Items.AddRange(new object[] {
            "Toàn thời gian",
            "Bán thời gian"});
            this.cbbContract.Location = new System.Drawing.Point(80, 0);
            this.cbbContract.Name = "cbbContract";
            this.cbbContract.Size = new System.Drawing.Size(121, 23);
            this.cbbContract.TabIndex = 30;
            this.cbbContract.SelectedIndexChanged += new System.EventHandler(this.cbbContract_SelectedIndexChanged);
            this.cbbContract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Loại h.đồng";
            // 
            // dgvME
            // 
            this.dgvME.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvME.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvME.Location = new System.Drawing.Point(3, 53);
            this.dgvME.Name = "dgvME";
            this.dgvME.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvME.Size = new System.Drawing.Size(605, 428);
            this.dgvME.TabIndex = 0;
            this.dgvME.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvME_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(931, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlToolMenu
            // 
            this.pnlToolMenu.Controls.Add(this.btnRefesh);
            this.pnlToolMenu.Controls.Add(this.btnDel);
            this.pnlToolMenu.Controls.Add(this.btnEdit);
            this.pnlToolMenu.Controls.Add(this.btnAdd);
            this.pnlToolMenu.Location = new System.Drawing.Point(3, 37);
            this.pnlToolMenu.Name = "pnlToolMenu";
            this.pnlToolMenu.Size = new System.Drawing.Size(1031, 40);
            this.pnlToolMenu.TabIndex = 1;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefesh.BackgroundImage = global::PhoneStore.Properties.Resources.update;
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(123, 4);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(32, 32);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDel.BackgroundImage = global::PhoneStore.Properties.Resources.delete;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.Location = new System.Drawing.Point(85, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(32, 32);
            this.btnDel.TabIndex = 8;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.BackgroundImage = global::PhoneStore.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(47, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::PhoneStore.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.pnlME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployees";
            this.Text = "ManageAccounts";
            this.pnlME.ResumeLayout(false);
            this.pnlME.PerformLayout();
            this.tabMEMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlContract.ResumeLayout(false);
            this.pnlContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvME)).EndInit();
            this.pnlToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlME;
        private System.Windows.Forms.TabControl tabMEMain;
        private System.Windows.Forms.Panel pnlToolMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvME;
        private System.Windows.Forms.Panel pnlContract;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datBirth;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datStart;
        private System.Windows.Forms.ComboBox cbbContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.TextBox txtSearchEmp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.Button btnRefesh;
    }
}
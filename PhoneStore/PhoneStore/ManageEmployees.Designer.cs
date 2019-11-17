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
            this.pnlME = new System.Windows.Forms.Panel();
            this.tabMEMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMEArea = new System.Windows.Forms.Panel();
            this.txtMEPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbMEPos = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMEID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMEUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datMEEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datMEStart = new System.Windows.Forms.DateTimePicker();
            this.cbbMEContract = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMEPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMESave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMEName = new System.Windows.Forms.TextBox();
            this.txtMESalary = new System.Windows.Forms.TextBox();
            this.txtMEAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMEEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datMEBirth = new System.Windows.Forms.DateTimePicker();
            this.radMEMale = new System.Windows.Forms.RadioButton();
            this.radMEFemale = new System.Windows.Forms.RadioButton();
            this.dgvME = new System.Windows.Forms.DataGridView();
            this.pnlToolMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlME.SuspendLayout();
            this.tabMEMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMEArea.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.pnlMEArea);
            this.tabPage1.Controls.Add(this.dgvME);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlMEArea
            // 
            this.pnlMEArea.Controls.Add(this.txtMEPass);
            this.pnlMEArea.Controls.Add(this.label7);
            this.pnlMEArea.Controls.Add(this.cbbMEPos);
            this.pnlMEArea.Controls.Add(this.label16);
            this.pnlMEArea.Controls.Add(this.txtMEID);
            this.pnlMEArea.Controls.Add(this.label15);
            this.pnlMEArea.Controls.Add(this.txtMEUsername);
            this.pnlMEArea.Controls.Add(this.label6);
            this.pnlMEArea.Controls.Add(this.label5);
            this.pnlMEArea.Controls.Add(this.datMEEnd);
            this.pnlMEArea.Controls.Add(this.label4);
            this.pnlMEArea.Controls.Add(this.datMEStart);
            this.pnlMEArea.Controls.Add(this.cbbMEContract);
            this.pnlMEArea.Controls.Add(this.label3);
            this.pnlMEArea.Controls.Add(this.txtMEPhone);
            this.pnlMEArea.Controls.Add(this.label2);
            this.pnlMEArea.Controls.Add(this.btnMESave);
            this.pnlMEArea.Controls.Add(this.label13);
            this.pnlMEArea.Controls.Add(this.txtMEName);
            this.pnlMEArea.Controls.Add(this.txtMESalary);
            this.pnlMEArea.Controls.Add(this.txtMEAdress);
            this.pnlMEArea.Controls.Add(this.label8);
            this.pnlMEArea.Controls.Add(this.label9);
            this.pnlMEArea.Controls.Add(this.label10);
            this.pnlMEArea.Controls.Add(this.txtMEEmail);
            this.pnlMEArea.Controls.Add(this.label11);
            this.pnlMEArea.Controls.Add(this.label12);
            this.pnlMEArea.Controls.Add(this.datMEBirth);
            this.pnlMEArea.Controls.Add(this.radMEMale);
            this.pnlMEArea.Controls.Add(this.radMEFemale);
            this.pnlMEArea.Location = new System.Drawing.Point(614, 3);
            this.pnlMEArea.Name = "pnlMEArea";
            this.pnlMEArea.Size = new System.Drawing.Size(415, 480);
            this.pnlMEArea.TabIndex = 16;
            // 
            // txtMEPass
            // 
            this.txtMEPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEPass.Location = new System.Drawing.Point(81, 370);
            this.txtMEPass.Name = "txtMEPass";
            this.txtMEPass.PasswordChar = '*';
            this.txtMEPass.Size = new System.Drawing.Size(104, 21);
            this.txtMEPass.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Password";
            // 
            // cbbMEPos
            // 
            this.cbbMEPos.FormattingEnabled = true;
            this.cbbMEPos.Items.AddRange(new object[] {
            "Administrator",
            "Quản lý",
            "Nhân viên"});
            this.cbbMEPos.Location = new System.Drawing.Point(295, 241);
            this.cbbMEPos.Name = "cbbMEPos";
            this.cbbMEPos.Size = new System.Drawing.Size(104, 23);
            this.cbbMEPos.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(239, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Chức vụ";
            // 
            // txtMEID
            // 
            this.txtMEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEID.Location = new System.Drawing.Point(316, 18);
            this.txtMEID.Name = "txtMEID";
            this.txtMEID.Size = new System.Drawing.Size(80, 21);
            this.txtMEID.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(268, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "MSNV";
            // 
            // txtMEUsername
            // 
            this.txtMEUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEUsername.Location = new System.Drawing.Point(81, 329);
            this.txtMEUsername.Name = "txtMEUsername";
            this.txtMEUsername.Size = new System.Drawing.Size(104, 21);
            this.txtMEUsername.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngày k.thúc";
            // 
            // datMEEnd
            // 
            this.datMEEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datMEEnd.Location = new System.Drawing.Point(295, 286);
            this.datMEEnd.Name = "datMEEnd";
            this.datMEEnd.Size = new System.Drawing.Size(104, 21);
            this.datMEEnd.TabIndex = 33;
            this.datMEEnd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ngày b.đầu";
            // 
            // datMEStart
            // 
            this.datMEStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datMEStart.Location = new System.Drawing.Point(84, 286);
            this.datMEStart.Name = "datMEStart";
            this.datMEStart.Size = new System.Drawing.Size(104, 21);
            this.datMEStart.TabIndex = 31;
            this.datMEStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbbMEContract
            // 
            this.cbbMEContract.FormattingEnabled = true;
            this.cbbMEContract.Items.AddRange(new object[] {
            "Toàn thời gian",
            "Bán thời gian"});
            this.cbbMEContract.Location = new System.Drawing.Point(81, 241);
            this.cbbMEContract.Name = "cbbMEContract";
            this.cbbMEContract.Size = new System.Drawing.Size(121, 23);
            this.cbbMEContract.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Loại h.đồng";
            // 
            // txtMEPhone
            // 
            this.txtMEPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEPhone.Location = new System.Drawing.Point(82, 98);
            this.txtMEPhone.Name = "txtMEPhone";
            this.txtMEPhone.Size = new System.Drawing.Size(141, 21);
            this.txtMEPhone.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số đ.thoại";
            // 
            // btnMESave
            // 
            this.btnMESave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMESave.Location = new System.Drawing.Point(319, 440);
            this.btnMESave.Name = "btnMESave";
            this.btnMESave.Size = new System.Drawing.Size(88, 34);
            this.btnMESave.TabIndex = 20;
            this.btnMESave.Text = "Lưu";
            this.btnMESave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Nhân viên";
            // 
            // txtMEName
            // 
            this.txtMEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEName.Location = new System.Drawing.Point(81, 18);
            this.txtMEName.Name = "txtMEName";
            this.txtMEName.Size = new System.Drawing.Size(160, 21);
            this.txtMEName.TabIndex = 10;
            // 
            // txtMESalary
            // 
            this.txtMESalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMESalary.Location = new System.Drawing.Point(316, 98);
            this.txtMESalary.Name = "txtMESalary";
            this.txtMESalary.Size = new System.Drawing.Size(80, 21);
            this.txtMESalary.TabIndex = 12;
            // 
            // txtMEAdress
            // 
            this.txtMEAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEAdress.Location = new System.Drawing.Point(82, 180);
            this.txtMEAdress.Multiline = true;
            this.txtMEAdress.Name = "txtMEAdress";
            this.txtMEAdress.Size = new System.Drawing.Size(259, 40);
            this.txtMEAdress.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày sinh";
            // 
            // txtMEEmail
            // 
            this.txtMEEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMEEmail.Location = new System.Drawing.Point(82, 140);
            this.txtMEEmail.Name = "txtMEEmail";
            this.txtMEEmail.Size = new System.Drawing.Size(211, 21);
            this.txtMEEmail.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(234, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // datMEBirth
            // 
            this.datMEBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datMEBirth.Location = new System.Drawing.Point(82, 56);
            this.datMEBirth.Name = "datMEBirth";
            this.datMEBirth.Size = new System.Drawing.Size(104, 21);
            this.datMEBirth.TabIndex = 13;
            this.datMEBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radMEMale
            // 
            this.radMEMale.AutoSize = true;
            this.radMEMale.Location = new System.Drawing.Point(297, 59);
            this.radMEMale.Name = "radMEMale";
            this.radMEMale.Size = new System.Drawing.Size(52, 19);
            this.radMEMale.TabIndex = 14;
            this.radMEMale.TabStop = true;
            this.radMEMale.Text = "Nam";
            this.radMEMale.UseVisualStyleBackColor = true;
            // 
            // radMEFemale
            // 
            this.radMEFemale.AutoSize = true;
            this.radMEFemale.Location = new System.Drawing.Point(355, 59);
            this.radMEFemale.Name = "radMEFemale";
            this.radMEFemale.Size = new System.Drawing.Size(41, 19);
            this.radMEFemale.TabIndex = 15;
            this.radMEFemale.TabStop = true;
            this.radMEFemale.Text = "Nữ";
            this.radMEFemale.UseVisualStyleBackColor = true;
            // 
            // dgvME
            // 
            this.dgvME.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvME.Location = new System.Drawing.Point(6, 52);
            this.dgvME.Name = "dgvME";
            this.dgvME.Size = new System.Drawing.Size(602, 428);
            this.dgvME.TabIndex = 0;
            this.dgvME.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvME_CellClick);
            // 
            // pnlToolMenu
            // 
            this.pnlToolMenu.Controls.Add(this.button3);
            this.pnlToolMenu.Controls.Add(this.button2);
            this.pnlToolMenu.Controls.Add(this.btnAddOrder);
            this.pnlToolMenu.Location = new System.Drawing.Point(3, 37);
            this.pnlToolMenu.Name = "pnlToolMenu";
            this.pnlToolMenu.Size = new System.Drawing.Size(1031, 40);
            this.pnlToolMenu.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(101, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Del";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(55, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(9, 4);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(40, 32);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
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
            this.pnlMEArea.ResumeLayout(false);
            this.pnlMEArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvME)).EndInit();
            this.pnlToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlME;
        private System.Windows.Forms.TabControl tabMEMain;
        private System.Windows.Forms.Panel pnlToolMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvME;
        private System.Windows.Forms.Panel pnlMEArea;
        private System.Windows.Forms.TextBox txtMEPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMESave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMEName;
        private System.Windows.Forms.TextBox txtMESalary;
        private System.Windows.Forms.TextBox txtMEAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMEEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datMEBirth;
        private System.Windows.Forms.RadioButton radMEMale;
        private System.Windows.Forms.RadioButton radMEFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datMEEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datMEStart;
        private System.Windows.Forms.ComboBox cbbMEContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMEUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMEID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbMEPos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMEPass;
        private System.Windows.Forms.Label label7;
    }
}
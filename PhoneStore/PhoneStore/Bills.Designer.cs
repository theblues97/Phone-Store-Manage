namespace PhoneStore
{
    partial class Bills
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSalebills = new System.Windows.Forms.Panel();
            this.tabMainBill = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.datWarranty = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.datBuy = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.cbbPayMethod = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbBuyMethod = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pnlCustomerArea = new System.Windows.Forms.Panel();
            this.btnPhoneNumFill = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datBirth = new System.Windows.Forms.DateTimePicker();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.pnlBillPhoneArea = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvDetailBillPhones = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGift = new System.Windows.Forms.TextBox();
            this.txtPhoneFilled = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAvailble = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlPhoneArea = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.cbbColors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPhoneSearch = new System.Windows.Forms.Button();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.pnlBillListMain = new System.Windows.Forms.Panel();
            this.pnlToolMenu = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSalebills.SuspendLayout();
            this.tabMainBill.SuspendLayout();
            this.tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCustomerArea.SuspendLayout();
            this.tab2.SuspendLayout();
            this.pnlBillPhoneArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBillPhones)).BeginInit();
            this.pnlPhoneArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.pnlToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSalebills
            // 
            this.pnlSalebills.Controls.Add(this.tabMainBill);
            this.pnlSalebills.Controls.Add(this.pnlBillListMain);
            this.pnlSalebills.Controls.Add(this.pnlToolMenu);
            this.pnlSalebills.Controls.Add(this.label1);
            this.pnlSalebills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalebills.Location = new System.Drawing.Point(0, 0);
            this.pnlSalebills.Name = "pnlSalebills";
            this.pnlSalebills.Size = new System.Drawing.Size(1038, 593);
            this.pnlSalebills.TabIndex = 2;
            this.pnlSalebills.Leave += new System.EventHandler(this.pnlSalebills_Leave);
            // 
            // tabMainBill
            // 
            this.tabMainBill.Controls.Add(this.tab1);
            this.tabMainBill.Controls.Add(this.tab2);
            this.tabMainBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainBill.Location = new System.Drawing.Point(3, 80);
            this.tabMainBill.Name = "tabMainBill";
            this.tabMainBill.SelectedIndex = 0;
            this.tabMainBill.Size = new System.Drawing.Size(1037, 514);
            this.tabMainBill.TabIndex = 38;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.panel1);
            this.tab1.Controls.Add(this.pnlCustomerArea);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1029, 486);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Thông tin hóa đơn";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmployeeName);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.txtEmployeeID);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.datWarranty);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.datBuy);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.cbbPayMethod);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.cbbBuyMethod);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(520, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 480);
            this.panel1.TabIndex = 16;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Enabled = false;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(166, 81);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(175, 21);
            this.txtEmployeeName.TabIndex = 36;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(66, 84);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 15);
            this.label29.TabIndex = 37;
            this.label29.Text = "Tên nhân viên";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(166, 41);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(84, 21);
            this.txtEmployeeID.TabIndex = 27;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(66, 44);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 15);
            this.label28.TabIndex = 28;
            this.label28.Text = "Mã nhân viên";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(411, 440);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 34);
            this.btnSelect.TabIndex = 27;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // datWarranty
            // 
            this.datWarranty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datWarranty.Location = new System.Drawing.Point(166, 163);
            this.datWarranty.Name = "datWarranty";
            this.datWarranty.Size = new System.Drawing.Size(104, 21);
            this.datWarranty.TabIndex = 35;
            this.datWarranty.Value = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(66, 166);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 15);
            this.label27.TabIndex = 34;
            this.label27.Text = "Hạn bảo hành";
            // 
            // datBuy
            // 
            this.datBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBuy.Location = new System.Drawing.Point(166, 122);
            this.datBuy.Name = "datBuy";
            this.datBuy.Size = new System.Drawing.Size(104, 21);
            this.datBuy.TabIndex = 27;
            this.datBuy.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(66, 126);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 15);
            this.label26.TabIndex = 32;
            this.label26.Text = "Ngày mua";
            // 
            // cbbPayMethod
            // 
            this.cbbPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPayMethod.FormattingEnabled = true;
            this.cbbPayMethod.ItemHeight = 15;
            this.cbbPayMethod.Items.AddRange(new object[] {
            "Thanh toán trực tiếp",
            "Thanh toán bằng thẻ"});
            this.cbbPayMethod.Location = new System.Drawing.Point(166, 245);
            this.cbbPayMethod.Name = "cbbPayMethod";
            this.cbbPayMethod.Size = new System.Drawing.Size(145, 23);
            this.cbbPayMethod.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(66, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 15);
            this.label20.TabIndex = 29;
            this.label20.Text = "P.t mua hàng";
            // 
            // cbbBuyMethod
            // 
            this.cbbBuyMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuyMethod.FormattingEnabled = true;
            this.cbbBuyMethod.ItemHeight = 15;
            this.cbbBuyMethod.Items.AddRange(new object[] {
            "Mua tại cửa hàng",
            "Giao hàng tại nhà"});
            this.cbbBuyMethod.Location = new System.Drawing.Point(166, 205);
            this.cbbBuyMethod.Name = "cbbBuyMethod";
            this.cbbBuyMethod.Size = new System.Drawing.Size(145, 23);
            this.cbbBuyMethod.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(66, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 31;
            this.label21.Text = "P.t thanh toán";
            // 
            // pnlCustomerArea
            // 
            this.pnlCustomerArea.Controls.Add(this.btnPhoneNumFill);
            this.pnlCustomerArea.Controls.Add(this.label13);
            this.pnlCustomerArea.Controls.Add(this.txtSearchCus);
            this.pnlCustomerArea.Controls.Add(this.txtCustomer);
            this.pnlCustomerArea.Controls.Add(this.txtAdress);
            this.pnlCustomerArea.Controls.Add(this.label8);
            this.pnlCustomerArea.Controls.Add(this.label9);
            this.pnlCustomerArea.Controls.Add(this.label10);
            this.pnlCustomerArea.Controls.Add(this.txtEmail);
            this.pnlCustomerArea.Controls.Add(this.label11);
            this.pnlCustomerArea.Controls.Add(this.label12);
            this.pnlCustomerArea.Controls.Add(this.datBirth);
            this.pnlCustomerArea.Controls.Add(this.radMale);
            this.pnlCustomerArea.Controls.Add(this.radFemale);
            this.pnlCustomerArea.Location = new System.Drawing.Point(3, 3);
            this.pnlCustomerArea.Name = "pnlCustomerArea";
            this.pnlCustomerArea.Size = new System.Drawing.Size(511, 480);
            this.pnlCustomerArea.TabIndex = 15;
            // 
            // btnPhoneNumFill
            // 
            this.btnPhoneNumFill.Location = new System.Drawing.Point(352, 36);
            this.btnPhoneNumFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhoneNumFill.Name = "btnPhoneNumFill";
            this.btnPhoneNumFill.Size = new System.Drawing.Size(40, 32);
            this.btnPhoneNumFill.TabIndex = 11;
            this.btnPhoneNumFill.Text = "Tìm";
            this.btnPhoneNumFill.UseVisualStyleBackColor = true;
            this.btnPhoneNumFill.Click += new System.EventHandler(this.btnPhoneNumFill_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Số điện thoại";
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCus.Location = new System.Drawing.Point(133, 42);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(175, 21);
            this.txtSearchCus.TabIndex = 10;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(133, 82);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(211, 21);
            this.txtCustomer.TabIndex = 12;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(133, 239);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(259, 40);
            this.txtAdress.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày sinh";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 21);
            this.txtEmail.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // datBirth
            // 
            this.datBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBirth.Location = new System.Drawing.Point(133, 124);
            this.datBirth.Name = "datBirth";
            this.datBirth.Size = new System.Drawing.Size(104, 21);
            this.datBirth.TabIndex = 13;
            this.datBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(133, 162);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(52, 19);
            this.radMale.TabIndex = 14;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(198, 162);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(41, 19);
            this.radFemale.TabIndex = 15;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.pnlBillPhoneArea);
            this.tab2.Controls.Add(this.pnlPhoneArea);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1029, 486);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "Chọn điện thoại";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // pnlBillPhoneArea
            // 
            this.pnlBillPhoneArea.Controls.Add(this.btnCancel);
            this.pnlBillPhoneArea.Controls.Add(this.btnCreate);
            this.pnlBillPhoneArea.Controls.Add(this.dgvDetailBillPhones);
            this.pnlBillPhoneArea.Controls.Add(this.label15);
            this.pnlBillPhoneArea.Controls.Add(this.lblTotalMoney);
            this.pnlBillPhoneArea.Controls.Add(this.label5);
            this.pnlBillPhoneArea.Controls.Add(this.label4);
            this.pnlBillPhoneArea.Controls.Add(this.txtGift);
            this.pnlBillPhoneArea.Controls.Add(this.txtPhoneFilled);
            this.pnlBillPhoneArea.Controls.Add(this.label14);
            this.pnlBillPhoneArea.Controls.Add(this.txtColor);
            this.pnlBillPhoneArea.Controls.Add(this.txtPrice);
            this.pnlBillPhoneArea.Controls.Add(this.txtAvailble);
            this.pnlBillPhoneArea.Controls.Add(this.label7);
            this.pnlBillPhoneArea.Controls.Add(this.label6);
            this.pnlBillPhoneArea.Location = new System.Drawing.Point(618, 0);
            this.pnlBillPhoneArea.Name = "pnlBillPhoneArea";
            this.pnlBillPhoneArea.Size = new System.Drawing.Size(408, 483);
            this.pnlBillPhoneArea.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(10, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 34);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(313, 443);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 34);
            this.btnCreate.TabIndex = 40;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvDetailBillPhones
            // 
            this.dgvDetailBillPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailBillPhones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetailBillPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailBillPhones.Location = new System.Drawing.Point(7, 246);
            this.dgvDetailBillPhones.Name = "dgvDetailBillPhones";
            this.dgvDetailBillPhones.Size = new System.Drawing.Size(394, 182);
            this.dgvDetailBillPhones.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 49;
            this.label15.Text = "Khuyến mãi";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(101, 217);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(14, 15);
            this.lblTotalMoney.TabIndex = 36;
            this.lblTotalMoney.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Thành tiền:";
            // 
            // txtGift
            // 
            this.txtGift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGift.Location = new System.Drawing.Point(104, 156);
            this.txtGift.Multiline = true;
            this.txtGift.Name = "txtGift";
            this.txtGift.Size = new System.Drawing.Size(272, 40);
            this.txtGift.TabIndex = 48;
            // 
            // txtPhoneFilled
            // 
            this.txtPhoneFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneFilled.Location = new System.Drawing.Point(104, 36);
            this.txtPhoneFilled.Name = "txtPhoneFilled";
            this.txtPhoneFilled.Size = new System.Drawing.Size(235, 21);
            this.txtPhoneFilled.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(241, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 47;
            this.label14.Text = "Giá";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(104, 76);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(59, 21);
            this.txtColor.TabIndex = 41;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(285, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(91, 21);
            this.txtPrice.TabIndex = 45;
            // 
            // txtAvailble
            // 
            this.txtAvailble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailble.Location = new System.Drawing.Point(104, 116);
            this.txtAvailble.Name = "txtAvailble";
            this.txtAvailble.Size = new System.Drawing.Size(39, 21);
            this.txtAvailble.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Màu";
            // 
            // pnlPhoneArea
            // 
            this.pnlPhoneArea.Controls.Add(this.label16);
            this.pnlPhoneArea.Controls.Add(this.dgvPhones);
            this.pnlPhoneArea.Controls.Add(this.cbbColors);
            this.pnlPhoneArea.Controls.Add(this.label3);
            this.pnlPhoneArea.Controls.Add(this.cbbBrand);
            this.pnlPhoneArea.Controls.Add(this.btnAddPhone);
            this.pnlPhoneArea.Controls.Add(this.label2);
            this.pnlPhoneArea.Controls.Add(this.btnPhoneSearch);
            this.pnlPhoneArea.Controls.Add(this.txtSearchPhone);
            this.pnlPhoneArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPhoneArea.Location = new System.Drawing.Point(3, 3);
            this.pnlPhoneArea.Name = "pnlPhoneArea";
            this.pnlPhoneArea.Size = new System.Drawing.Size(612, 483);
            this.pnlPhoneArea.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(364, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 15);
            this.label16.TabIndex = 40;
            this.label16.Text = "Tên";
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToAddRows = false;
            this.dgvPhones.AllowUserToResizeColumns = false;
            this.dgvPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhones.Location = new System.Drawing.Point(3, 46);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPhones.Size = new System.Drawing.Size(606, 378);
            this.dgvPhones.TabIndex = 0;
            this.dgvPhones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhones_CellClick);
            // 
            // cbbColors
            // 
            this.cbbColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbColors.FormattingEnabled = true;
            this.cbbColors.ItemHeight = 15;
            this.cbbColors.Location = new System.Drawing.Point(175, 16);
            this.cbbColors.Name = "cbbColors";
            this.cbbColors.Size = new System.Drawing.Size(108, 23);
            this.cbbColors.TabIndex = 38;
            this.cbbColors.SelectedIndexChanged += new System.EventHandler(this.cbbColors_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Màu";
            // 
            // cbbBrand
            // 
            this.cbbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.ItemHeight = 15;
            this.cbbBrand.Location = new System.Drawing.Point(47, 16);
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(70, 23);
            this.cbbBrand.TabIndex = 4;
            this.cbbBrand.SelectedIndexChanged += new System.EventHandler(this.cbbBrand_SelectedIndexChanged);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhone.Location = new System.Drawing.Point(398, 440);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(88, 34);
            this.btnAddPhone.TabIndex = 9;
            this.btnAddPhone.Text = "Thêm";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hãng";
            // 
            // btnPhoneSearch
            // 
            this.btnPhoneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneSearch.Location = new System.Drawing.Point(547, 10);
            this.btnPhoneSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhoneSearch.Name = "btnPhoneSearch";
            this.btnPhoneSearch.Size = new System.Drawing.Size(40, 32);
            this.btnPhoneSearch.TabIndex = 6;
            this.btnPhoneSearch.Text = "Tìm";
            this.btnPhoneSearch.UseVisualStyleBackColor = true;
            this.btnPhoneSearch.Click += new System.EventHandler(this.btnPhoneSearch_Click);
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPhone.Location = new System.Drawing.Point(398, 16);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(143, 21);
            this.txtSearchPhone.TabIndex = 5;
            // 
            // pnlBillListMain
            // 
            this.pnlBillListMain.Location = new System.Drawing.Point(3, 80);
            this.pnlBillListMain.Name = "pnlBillListMain";
            this.pnlBillListMain.Size = new System.Drawing.Size(1037, 517);
            this.pnlBillListMain.TabIndex = 3;
            // 
            // pnlToolMenu
            // 
            this.pnlToolMenu.Controls.Add(this.btnDel);
            this.pnlToolMenu.Controls.Add(this.btnEdit);
            this.pnlToolMenu.Controls.Add(this.btnAdd);
            this.pnlToolMenu.Location = new System.Drawing.Point(3, 37);
            this.pnlToolMenu.Name = "pnlToolMenu";
            this.pnlToolMenu.Size = new System.Drawing.Size(1032, 40);
            this.pnlToolMenu.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Enabled = false;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.Location = new System.Drawing.Point(101, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(40, 32);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(55, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.pnlSalebills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bills";
            this.Text = "Bills";
            this.pnlSalebills.ResumeLayout(false);
            this.pnlSalebills.PerformLayout();
            this.tabMainBill.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCustomerArea.ResumeLayout(false);
            this.pnlCustomerArea.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.pnlBillPhoneArea.ResumeLayout(false);
            this.pnlBillPhoneArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailBillPhones)).EndInit();
            this.pnlPhoneArea.ResumeLayout(false);
            this.pnlPhoneArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.pnlToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalebills;
        private System.Windows.Forms.TabControl tabMainBill;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DateTimePicker datWarranty;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker datBuy;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbbPayMethod;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbBuyMethod;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel pnlCustomerArea;
        private System.Windows.Forms.Button btnPhoneNumFill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.TextBox txtCustomer;
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
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Panel pnlBillPhoneArea;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvDetailBillPhones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGift;
        private System.Windows.Forms.TextBox txtPhoneFilled;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAvailble;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlPhoneArea;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.ComboBox cbbColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPhoneSearch;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Panel pnlBillListMain;
        private System.Windows.Forms.Panel pnlToolMenu;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label16;
    }
}
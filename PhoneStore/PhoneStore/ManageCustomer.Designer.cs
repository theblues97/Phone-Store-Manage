namespace PhoneStore
{
    partial class ManageCustomer
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.pnlArea = new System.Windows.Forms.Panel();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCus = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datBirth = new System.Windows.Forms.DateTimePicker();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.dgvMC = new System.Windows.Forms.DataGridView();
            this.pnlBillListMain = new System.Windows.Forms.Panel();
            this.pnlToolMenu = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhoneNumFill = new System.Windows.Forms.Button();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.pnl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tab1.SuspendLayout();
            this.pnlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMC)).BeginInit();
            this.pnlToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.tabMain);
            this.pnl1.Controls.Add(this.pnlBillListMain);
            this.pnl1.Controls.Add(this.pnlToolMenu);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1038, 593);
            this.pnl1.TabIndex = 3;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tab1);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(3, 80);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1037, 514);
            this.tabMain.TabIndex = 38;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btnPhoneNumFill);
            this.tab1.Controls.Add(this.txtSearchCus);
            this.tab1.Controls.Add(this.pnlArea);
            this.tab1.Controls.Add(this.dgvMC);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1029, 486);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Danh sách khách hàng";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.txtCusID);
            this.pnlArea.Controls.Add(this.label15);
            this.pnlArea.Controls.Add(this.txtPhone);
            this.pnlArea.Controls.Add(this.label2);
            this.pnlArea.Controls.Add(this.btnSave);
            this.pnlArea.Controls.Add(this.label13);
            this.pnlArea.Controls.Add(this.txtCus);
            this.pnlArea.Controls.Add(this.txtAdress);
            this.pnlArea.Controls.Add(this.label9);
            this.pnlArea.Controls.Add(this.label10);
            this.pnlArea.Controls.Add(this.txtEmail);
            this.pnlArea.Controls.Add(this.label11);
            this.pnlArea.Controls.Add(this.label12);
            this.pnlArea.Controls.Add(this.datBirth);
            this.pnlArea.Controls.Add(this.radMale);
            this.pnlArea.Controls.Add(this.radFemale);
            this.pnlArea.Location = new System.Drawing.Point(613, 3);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(413, 480);
            this.pnlArea.TabIndex = 17;
            // 
            // txtCusID
            // 
            this.txtCusID.Enabled = false;
            this.txtCusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(93, 46);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(80, 21);
            this.txtCusID.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Mã KH";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(94, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 21);
            this.txtPhone.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Số đ.thoại";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(318, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Khách hàng";
            // 
            // txtCus
            // 
            this.txtCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCus.Location = new System.Drawing.Point(93, 86);
            this.txtCus.Name = "txtCus";
            this.txtCus.Size = new System.Drawing.Size(160, 21);
            this.txtCus.TabIndex = 10;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(94, 288);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(259, 40);
            this.txtAdress.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày sinh";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(94, 248);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 21);
            this.txtEmail.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // datBirth
            // 
            this.datBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBirth.Location = new System.Drawing.Point(94, 124);
            this.datBirth.Name = "datBirth";
            this.datBirth.Size = new System.Drawing.Size(104, 21);
            this.datBirth.TabIndex = 13;
            this.datBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(93, 165);
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
            this.radFemale.Location = new System.Drawing.Point(151, 165);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(41, 19);
            this.radFemale.TabIndex = 15;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // dgvMC
            // 
            this.dgvMC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMC.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMC.Location = new System.Drawing.Point(6, 52);
            this.dgvMC.Name = "dgvMC";
            this.dgvMC.Size = new System.Drawing.Size(602, 428);
            this.dgvMC.TabIndex = 1;
            this.dgvMC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMC_CellClick);
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
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(101, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(40, 32);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
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
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // btnPhoneNumFill
            // 
            this.btnPhoneNumFill.Location = new System.Drawing.Point(557, 10);
            this.btnPhoneNumFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhoneNumFill.Name = "btnPhoneNumFill";
            this.btnPhoneNumFill.Size = new System.Drawing.Size(40, 32);
            this.btnPhoneNumFill.TabIndex = 19;
            this.btnPhoneNumFill.Text = "Tìm";
            this.btnPhoneNumFill.UseVisualStyleBackColor = true;
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCus.Location = new System.Drawing.Point(358, 16);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(175, 21);
            this.txtSearchCus.TabIndex = 18;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMC)).EndInit();
            this.pnlToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Panel pnlBillListMain;
        private System.Windows.Forms.Panel pnlToolMenu;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMC;
        private System.Windows.Forms.Panel pnlArea;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCus;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datBirth;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Button btnPhoneNumFill;
        private System.Windows.Forms.TextBox txtSearchCus;
    }
}
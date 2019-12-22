namespace PhoneStore
{
    partial class ManagePhones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.pnlPhone = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtEntryPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbEditBrand = new System.Windows.Forms.ComboBox();
            this.radPhoneMode = new System.Windows.Forms.RadioButton();
            this.radPhoneSampleMode = new System.Windows.Forms.RadioButton();
            this.radBrandMode = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPhoneSample = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneSampleID = new System.Windows.Forms.TextBox();
            this.txtPhoneSample = new System.Windows.Forms.TextBox();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.datManufacturing = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhoneSamples = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBrandFilter = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlToolMenu = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tab2.SuspendLayout();
            this.pnlPhone.SuspendLayout();
            this.pnlPhoneSample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneSamples)).BeginInit();
            this.pnlToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabMain);
            this.panel1.Controls.Add(this.pnlToolMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 593);
            this.panel1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tab2);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(1, 80);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1037, 513);
            this.tabMain.TabIndex = 39;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.pnlPhone);
            this.tab2.Controls.Add(this.cbbEditBrand);
            this.tab2.Controls.Add(this.radPhoneMode);
            this.tab2.Controls.Add(this.radPhoneSampleMode);
            this.tab2.Controls.Add(this.radBrandMode);
            this.tab2.Controls.Add(this.label4);
            this.tab2.Controls.Add(this.pnlPhoneSample);
            this.tab2.Controls.Add(this.dgvPhoneSamples);
            this.tab2.Controls.Add(this.btnClean);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.cbbBrandFilter);
            this.tab2.Controls.Add(this.btnSave);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(1029, 485);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "Mẫu điện thoại";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // pnlPhone
            // 
            this.pnlPhone.Controls.Add(this.label12);
            this.pnlPhone.Controls.Add(this.label9);
            this.pnlPhone.Controls.Add(this.txtSalePrice);
            this.pnlPhone.Controls.Add(this.cbbColor);
            this.pnlPhone.Controls.Add(this.label11);
            this.pnlPhone.Controls.Add(this.txtNumber);
            this.pnlPhone.Controls.Add(this.txtEntryPrice);
            this.pnlPhone.Controls.Add(this.label10);
            this.pnlPhone.Enabled = false;
            this.pnlPhone.Location = new System.Drawing.Point(613, 356);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Size = new System.Drawing.Size(413, 81);
            this.pnlPhone.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 62;
            this.label12.Text = "Giá bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "Màu";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(287, 38);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(124, 21);
            this.txtSalePrice.TabIndex = 63;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // cbbColor
            // 
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Location = new System.Drawing.Point(81, 0);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(86, 23);
            this.cbbColor.TabIndex = 57;
            this.cbbColor.SelectedIndexChanged += new System.EventHandler(this.cbbColor_SelectedIndexChanged);
            this.cbbColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 60;
            this.label11.Text = "Giá nhập";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(288, 0);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(34, 21);
            this.txtNumber.TabIndex = 59;
            // 
            // txtEntryPrice
            // 
            this.txtEntryPrice.Location = new System.Drawing.Point(81, 41);
            this.txtEntryPrice.Name = "txtEntryPrice";
            this.txtEntryPrice.Size = new System.Drawing.Size(124, 21);
            this.txtEntryPrice.TabIndex = 61;
            this.txtEntryPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "Số lượng";
            // 
            // cbbEditBrand
            // 
            this.cbbEditBrand.Enabled = false;
            this.cbbEditBrand.FormattingEnabled = true;
            this.cbbEditBrand.Location = new System.Drawing.Point(694, 54);
            this.cbbEditBrand.Name = "cbbEditBrand";
            this.cbbEditBrand.Size = new System.Drawing.Size(86, 23);
            this.cbbEditBrand.TabIndex = 55;
            this.cbbEditBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // radPhoneMode
            // 
            this.radPhoneMode.AutoSize = true;
            this.radPhoneMode.Location = new System.Drawing.Point(929, 20);
            this.radPhoneMode.Name = "radPhoneMode";
            this.radPhoneMode.Size = new System.Drawing.Size(81, 19);
            this.radPhoneMode.TabIndex = 59;
            this.radPhoneMode.TabStop = true;
            this.radPhoneMode.Text = "Điện thoại";
            this.radPhoneMode.UseVisualStyleBackColor = true;
            this.radPhoneMode.CheckedChanged += new System.EventHandler(this.radHandle_CheckedChange);
            // 
            // radPhoneSampleMode
            // 
            this.radPhoneSampleMode.AutoSize = true;
            this.radPhoneSampleMode.Location = new System.Drawing.Point(772, 20);
            this.radPhoneSampleMode.Name = "radPhoneSampleMode";
            this.radPhoneSampleMode.Size = new System.Drawing.Size(106, 19);
            this.radPhoneSampleMode.TabIndex = 58;
            this.radPhoneSampleMode.TabStop = true;
            this.radPhoneSampleMode.Text = "Loại điện thoại";
            this.radPhoneSampleMode.UseVisualStyleBackColor = true;
            this.radPhoneSampleMode.CheckedChanged += new System.EventHandler(this.radHandle_CheckedChange);
            // 
            // radBrandMode
            // 
            this.radBrandMode.AutoSize = true;
            this.radBrandMode.Location = new System.Drawing.Point(619, 20);
            this.radBrandMode.Name = "radBrandMode";
            this.radBrandMode.Size = new System.Drawing.Size(55, 19);
            this.radBrandMode.TabIndex = 57;
            this.radBrandMode.TabStop = true;
            this.radBrandMode.Text = "Hãng";
            this.radBrandMode.UseVisualStyleBackColor = true;
            this.radBrandMode.CheckedChanged += new System.EventHandler(this.radHandle_CheckedChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hãng";
            // 
            // pnlPhoneSample
            // 
            this.pnlPhoneSample.Controls.Add(this.label3);
            this.pnlPhoneSample.Controls.Add(this.label6);
            this.pnlPhoneSample.Controls.Add(this.label8);
            this.pnlPhoneSample.Controls.Add(this.label7);
            this.pnlPhoneSample.Controls.Add(this.txtPhoneSampleID);
            this.pnlPhoneSample.Controls.Add(this.txtPhoneSample);
            this.pnlPhoneSample.Controls.Add(this.txtPromotion);
            this.pnlPhoneSample.Controls.Add(this.datManufacturing);
            this.pnlPhoneSample.Controls.Add(this.txtDescription);
            this.pnlPhoneSample.Controls.Add(this.label5);
            this.pnlPhoneSample.Enabled = false;
            this.pnlPhoneSample.Location = new System.Drawing.Point(613, 95);
            this.pnlPhoneSample.Name = "pnlPhoneSample";
            this.pnlPhoneSample.Size = new System.Drawing.Size(413, 244);
            this.pnlPhoneSample.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mô tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Mã MDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Năm s.x";
            // 
            // txtPhoneSampleID
            // 
            this.txtPhoneSampleID.Enabled = false;
            this.txtPhoneSampleID.Location = new System.Drawing.Point(287, 38);
            this.txtPhoneSampleID.Name = "txtPhoneSampleID";
            this.txtPhoneSampleID.Size = new System.Drawing.Size(74, 21);
            this.txtPhoneSampleID.TabIndex = 47;
            // 
            // txtPhoneSample
            // 
            this.txtPhoneSample.Location = new System.Drawing.Point(81, 0);
            this.txtPhoneSample.Name = "txtPhoneSample";
            this.txtPhoneSample.Size = new System.Drawing.Size(224, 21);
            this.txtPhoneSample.TabIndex = 37;
            this.txtPhoneSample.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(81, 80);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.Size = new System.Drawing.Size(327, 21);
            this.txtPromotion.TabIndex = 39;
            this.txtPromotion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // datManufacturing
            // 
            this.datManufacturing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datManufacturing.Location = new System.Drawing.Point(81, 38);
            this.datManufacturing.Name = "datManufacturing";
            this.datManufacturing.Size = new System.Drawing.Size(104, 21);
            this.datManufacturing.TabIndex = 45;
            this.datManufacturing.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datManufacturing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(81, 120);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(325, 120);
            this.txtDescription.TabIndex = 44;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Khuyến mãi";
            // 
            // dgvPhoneSamples
            // 
            this.dgvPhoneSamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhoneSamples.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhoneSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneSamples.Location = new System.Drawing.Point(3, 54);
            this.dgvPhoneSamples.Name = "dgvPhoneSamples";
            this.dgvPhoneSamples.Size = new System.Drawing.Size(605, 428);
            this.dgvPhoneSamples.TabIndex = 53;
            this.dgvPhoneSamples.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhoneSamples_CellClick);
            // 
            // btnClean
            // 
            this.btnClean.Enabled = false;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(619, 443);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(88, 34);
            this.btnClean.TabIndex = 54;
            this.btnClean.Text = "Tẩy";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hãng";
            // 
            // cbbBrandFilter
            // 
            this.cbbBrandFilter.FormattingEnabled = true;
            this.cbbBrandFilter.Location = new System.Drawing.Point(53, 17);
            this.cbbBrandFilter.Name = "cbbBrandFilter";
            this.cbbBrandFilter.Size = new System.Drawing.Size(86, 23);
            this.cbbBrandFilter.TabIndex = 50;
            this.cbbBrandFilter.SelectedIndexChanged += new System.EventHandler(this.cbbBrand_SelectedIndexChanged);
            this.cbbBrandFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.infoHandle_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(938, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlToolMenu
            // 
            this.pnlToolMenu.Controls.Add(this.btnDel);
            this.pnlToolMenu.Controls.Add(this.btnEdit);
            this.pnlToolMenu.Controls.Add(this.btnAdd);
            this.pnlToolMenu.Location = new System.Drawing.Point(3, 37);
            this.pnlToolMenu.Name = "pnlToolMenu";
            this.pnlToolMenu.Size = new System.Drawing.Size(1032, 40);
            this.pnlToolMenu.TabIndex = 2;
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
            this.btnDel.TabIndex = 5;
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
            this.btnEdit.TabIndex = 4;
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
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý điện thoại";
            // 
            // ManagePhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 593);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagePhones";
            this.Text = "ManagePhones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.pnlPhone.ResumeLayout(false);
            this.pnlPhone.PerformLayout();
            this.pnlPhoneSample.ResumeLayout(false);
            this.pnlPhoneSample.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneSamples)).EndInit();
            this.pnlToolMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Panel pnlPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtEntryPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbEditBrand;
        private System.Windows.Forms.RadioButton radPhoneMode;
        private System.Windows.Forms.RadioButton radPhoneSampleMode;
        private System.Windows.Forms.RadioButton radBrandMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPhoneSample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneSampleID;
        private System.Windows.Forms.TextBox txtPhoneSample;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.DateTimePicker datManufacturing;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPhoneSamples;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbBrandFilter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlToolMenu;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}
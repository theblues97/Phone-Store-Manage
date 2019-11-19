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
            this.tabMainBill = new System.Windows.Forms.TabControl();
            this.tabMP = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.datProduce = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneSample = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.pnlToolMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhoneSamples = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabMainBill.SuspendLayout();
            this.tabMP.SuspendLayout();
            this.pnlToolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneSamples)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabMainBill);
            this.panel1.Controls.Add(this.pnlToolMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 593);
            this.panel1.TabIndex = 0;
            // 
            // tabMainBill
            // 
            this.tabMainBill.Controls.Add(this.tabMP);
            this.tabMainBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainBill.Location = new System.Drawing.Point(1, 80);
            this.tabMainBill.Name = "tabMainBill";
            this.tabMainBill.SelectedIndex = 0;
            this.tabMainBill.Size = new System.Drawing.Size(1037, 513);
            this.tabMainBill.TabIndex = 39;
            // 
            // tabMP
            // 
            this.tabMP.Controls.Add(this.dgvPhoneSamples);
            this.tabMP.Controls.Add(this.btnSave);
            this.tabMP.Controls.Add(this.datProduce);
            this.tabMP.Controls.Add(this.txtDescription);
            this.tabMP.Controls.Add(this.label7);
            this.tabMP.Controls.Add(this.label6);
            this.tabMP.Controls.Add(this.txtPromotion);
            this.tabMP.Controls.Add(this.label5);
            this.tabMP.Controls.Add(this.txtPhoneSample);
            this.tabMP.Controls.Add(this.label3);
            this.tabMP.Controls.Add(this.txtBrand);
            this.tabMP.Controls.Add(this.label4);
            this.tabMP.Controls.Add(this.label2);
            this.tabMP.Controls.Add(this.cbbBrand);
            this.tabMP.Location = new System.Drawing.Point(4, 24);
            this.tabMP.Name = "tabMP";
            this.tabMP.Padding = new System.Windows.Forms.Padding(3);
            this.tabMP.Size = new System.Drawing.Size(1029, 485);
            this.tabMP.TabIndex = 1;
            this.tabMP.Text = "Danh sách điện thoại";
            this.tabMP.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(933, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // datProduce
            // 
            this.datProduce.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datProduce.Location = new System.Drawing.Point(738, 140);
            this.datProduce.Name = "datProduce";
            this.datProduce.Size = new System.Drawing.Size(104, 21);
            this.datProduce.TabIndex = 45;
            this.datProduce.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(738, 244);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 140);
            this.txtDescription.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Năm sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mô tả";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(738, 182);
            this.txtPromotion.Multiline = true;
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.Size = new System.Drawing.Size(222, 40);
            this.txtPromotion.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Khuyến mãi";
            // 
            // txtPhoneSample
            // 
            this.txtPhoneSample.Location = new System.Drawing.Point(738, 101);
            this.txtPhoneSample.Name = "txtPhoneSample";
            this.txtPhoneSample.Size = new System.Drawing.Size(200, 21);
            this.txtPhoneSample.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mẫu điện thoại";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(738, 61);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 21);
            this.txtBrand.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Hãng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hãng";
            // 
            // cbbBrand
            // 
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(53, 21);
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(86, 23);
            this.cbbBrand.TabIndex = 2;
            this.cbbBrand.SelectedIndexChanged += new System.EventHandler(this.cbbBrand_SelectedIndexChanged);
            // 
            // pnlToolMenu
            // 
            this.pnlToolMenu.Controls.Add(this.button3);
            this.pnlToolMenu.Controls.Add(this.button2);
            this.pnlToolMenu.Controls.Add(this.btnAddOrder);
            this.pnlToolMenu.Location = new System.Drawing.Point(3, 37);
            this.pnlToolMenu.Name = "pnlToolMenu";
            this.pnlToolMenu.Size = new System.Drawing.Size(1032, 40);
            this.pnlToolMenu.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý điện thoại";
            // 
            // dgvPhoneSamples
            // 
            this.dgvPhoneSamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhoneSamples.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhoneSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneSamples.Location = new System.Drawing.Point(3, 54);
            this.dgvPhoneSamples.Name = "dgvPhoneSamples";
            this.dgvPhoneSamples.Size = new System.Drawing.Size(602, 428);
            this.dgvPhoneSamples.TabIndex = 47;
            this.dgvPhoneSamples.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhoneSamples_CellClick);
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
            this.tabMainBill.ResumeLayout(false);
            this.tabMP.ResumeLayout(false);
            this.tabMP.PerformLayout();
            this.pnlToolMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneSamples)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlToolMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TabControl tabMainBill;
        private System.Windows.Forms.TabPage tabMP;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneSample;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker datProduce;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPhoneSamples;
    }
}
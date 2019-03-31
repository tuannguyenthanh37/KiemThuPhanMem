namespace PMQLSanCauLong
{
    partial class FormDSKHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSKHang));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateNgaySDSan = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdiSDT = new System.Windows.Forms.RadioButton();
            this.rdiTenKH = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.dgvCTDV = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaSan = new System.Windows.Forms.Button();
            this.dgvCTTS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInPTS = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1235, 68);
            this.label9.TabIndex = 39;
            this.label9.Text = "BẢNG DANH SÁCH KHÁCH HÀNG";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dateNgaySDSan);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 70);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày KH Thuê";
            // 
            // dateNgaySDSan
            // 
            this.dateNgaySDSan.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySDSan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySDSan.Location = new System.Drawing.Point(6, 21);
            this.dateNgaySDSan.Name = "dateNgaySDSan";
            this.dateNgaySDSan.Size = new System.Drawing.Size(140, 22);
            this.dateNgaySDSan.TabIndex = 0;
            this.dateNgaySDSan.ValueChanged += new System.EventHandler(this.dateNgaySDSan_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdiSDT);
            this.groupBox2.Controls.Add(this.rdiTenKH);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(194, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 70);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác tìm kiếm";
            // 
            // rdiSDT
            // 
            this.rdiSDT.AutoSize = true;
            this.rdiSDT.Location = new System.Drawing.Point(246, 47);
            this.rdiSDT.Name = "rdiSDT";
            this.rdiSDT.Size = new System.Drawing.Size(139, 18);
            this.rdiSDT.TabIndex = 25;
            this.rdiSDT.Text = "Tìm kiếm theo SĐT";
            this.rdiSDT.UseVisualStyleBackColor = true;
            // 
            // rdiTenKH
            // 
            this.rdiTenKH.AutoSize = true;
            this.rdiTenKH.Checked = true;
            this.rdiTenKH.Location = new System.Drawing.Point(246, 12);
            this.rdiTenKH.Name = "rdiTenKH";
            this.rdiTenKH.Size = new System.Drawing.Size(157, 18);
            this.rdiTenKH.TabIndex = 25;
            this.rdiTenKH.TabStop = true;
            this.rdiTenKH.Text = "Tìm kiếm theo tên KH";
            this.rdiTenKH.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(153, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 42);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(21, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(126, 22);
            this.txtTimKiem.TabIndex = 23;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnXoaDV);
            this.groupBox5.Controls.Add(this.dgvCTDV);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(611, 382);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(531, 230);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết đặt DV";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDV.BackgroundImage")));
            this.btnXoaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.Location = new System.Drawing.Point(231, 188);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(58, 37);
            this.btnXoaDV.TabIndex = 53;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // dgvCTDV
            // 
            this.dgvCTDV.AllowUserToResizeColumns = false;
            this.dgvCTDV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDV.Location = new System.Drawing.Point(7, 21);
            this.dgvCTDV.Name = "dgvCTDV";
            this.dgvCTDV.ReadOnly = true;
            this.dgvCTDV.Size = new System.Drawing.Size(518, 161);
            this.dgvCTDV.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnXoaSan);
            this.groupBox4.Controls.Add(this.dgvCTTS);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(611, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 233);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết đặt sân";
            // 
            // btnXoaSan
            // 
            this.btnXoaSan.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaSan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaSan.BackgroundImage")));
            this.btnXoaSan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaSan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSan.Location = new System.Drawing.Point(231, 190);
            this.btnXoaSan.Name = "btnXoaSan";
            this.btnXoaSan.Size = new System.Drawing.Size(58, 37);
            this.btnXoaSan.TabIndex = 52;
            this.btnXoaSan.Text = "Xóa";
            this.btnXoaSan.UseVisualStyleBackColor = false;
            this.btnXoaSan.Click += new System.EventHandler(this.btnXoaSan_Click);
            // 
            // dgvCTTS
            // 
            this.dgvCTTS.AllowUserToResizeColumns = false;
            this.dgvCTTS.AllowUserToResizeRows = false;
            this.dgvCTTS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCTTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTTS.Location = new System.Drawing.Point(3, 23);
            this.dgvCTTS.Name = "dgvCTTS";
            this.dgvCTTS.ReadOnly = true;
            this.dgvCTTS.Size = new System.Drawing.Size(564, 167);
            this.dgvCTTS.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnInPTS);
            this.groupBox1.Controls.Add(this.dgvKH);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 463);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng đã đặt";
            // 
            // btnInPTS
            // 
            this.btnInPTS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInPTS.BackgroundImage")));
            this.btnInPTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInPTS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInPTS.Location = new System.Drawing.Point(379, 403);
            this.btnInPTS.Name = "btnInPTS";
            this.btnInPTS.Size = new System.Drawing.Size(121, 49);
            this.btnInPTS.TabIndex = 40;
            this.btnInPTS.UseVisualStyleBackColor = true;
            this.btnInPTS.Click += new System.EventHandler(this.btnInPTS_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToResizeColumns = false;
            this.dgvKH.AllowUserToResizeRows = false;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(5, 28);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.Size = new System.Drawing.Size(597, 369);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKH.BackgroundImage")));
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Location = new System.Drawing.Point(189, 407);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(82, 41);
            this.btnXoaKH.TabIndex = 27;
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.Color.Transparent;
            this.btnTrove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrove.BackgroundImage")));
            this.btnTrove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Location = new System.Drawing.Point(567, 624);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(93, 52);
            this.btnTrove.TabIndex = 45;
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // FormDSKHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1235, 734);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Name = "FormDSKHang";
            this.Text = "FormDSKHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDSKHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTTS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateNgaySDSan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdiSDT;
        private System.Windows.Forms.RadioButton rdiTenKH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.DataGridView dgvCTDV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaSan;
        private System.Windows.Forms.DataGridView dgvCTTS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInPTS;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnTrove;
    }
}
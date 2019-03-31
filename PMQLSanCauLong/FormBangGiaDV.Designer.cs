namespace PMQLSanCauLong
{
    partial class FormBangGiaDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangGiaDV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSDichVu = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrove = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnKhongDV = new System.Windows.Forms.Button();
            this.btnGhiDV = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvDSDichVu);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(261, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 297);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // dgvDSDichVu
            // 
            this.dgvDSDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDV,
            this.DonViTinh,
            this.DonGia});
            this.dgvDSDichVu.Location = new System.Drawing.Point(10, 17);
            this.dgvDSDichVu.Name = "dgvDSDichVu";
            this.dgvDSDichVu.ReadOnly = true;
            this.dgvDSDichVu.Size = new System.Drawing.Size(713, 262);
            this.dgvDSDichVu.TabIndex = 1;
            this.dgvDSDichVu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDichVu_RowEnter);
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "madv";
            this.MaDV.HeaderText = "Mã DV";
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            this.MaDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaDV.Width = 120;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "tendv";
            this.TenDV.HeaderText = "Tên DV";
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            this.TenDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenDV.Width = 250;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "donvitinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DonViTinh.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "dongia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DonGia.Width = 150;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1284, 68);
            this.label9.TabIndex = 38;
            this.label9.Text = "BẢNG HÀNG HÓA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(427, 138);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(141, 20);
            this.txtDongia.TabIndex = 44;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(735, 92);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(141, 20);
            this.txtDVT.TabIndex = 43;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(427, 92);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(141, 20);
            this.txtTenHH.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Đơn vị tính :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên DV :";
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.Color.Transparent;
            this.btnTrove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrove.BackgroundImage")));
            this.btnTrove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Location = new System.Drawing.Point(609, 587);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(122, 66);
            this.btnTrove.TabIndex = 51;
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.BackgroundImage")));
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(464, 187);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(122, 66);
            this.btnCapNhat.TabIndex = 50;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.Transparent;
            this.btnThemDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemDV.BackgroundImage")));
            this.btnThemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemDV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.Location = new System.Drawing.Point(325, 187);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(122, 66);
            this.btnThemDV.TabIndex = 49;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnKhongDV
            // 
            this.btnKhongDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKhongDV.BackgroundImage")));
            this.btnKhongDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhongDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhongDV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongDV.Location = new System.Drawing.Point(632, 187);
            this.btnKhongDV.Name = "btnKhongDV";
            this.btnKhongDV.Size = new System.Drawing.Size(122, 66);
            this.btnKhongDV.TabIndex = 45;
            this.btnKhongDV.UseVisualStyleBackColor = true;
            this.btnKhongDV.Click += new System.EventHandler(this.btnKhongDV_Click);
            // 
            // btnGhiDV
            // 
            this.btnGhiDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGhiDV.BackgroundImage")));
            this.btnGhiDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGhiDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGhiDV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiDV.Location = new System.Drawing.Point(450, 187);
            this.btnGhiDV.Name = "btnGhiDV";
            this.btnGhiDV.Size = new System.Drawing.Size(122, 66);
            this.btnGhiDV.TabIndex = 46;
            this.btnGhiDV.UseVisualStyleBackColor = true;
            this.btnGhiDV.Click += new System.EventHandler(this.btnGhiDV_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(740, 187);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 66);
            this.btnSua.TabIndex = 47;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaDV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDV.BackgroundImage")));
            this.btnXoaDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaDV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.Location = new System.Drawing.Point(528, 187);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(122, 66);
            this.btnXoaDV.TabIndex = 48;
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // FormBangGiaDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.btnKhongDV);
            this.Controls.Add(this.btnGhiDV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBangGiaDV";
            this.Text = "FormBangGiaDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBangGiaDV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnKhongDV;
        private System.Windows.Forms.Button btnGhiDV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.DataGridView dgvDSDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}
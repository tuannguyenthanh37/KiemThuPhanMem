namespace PMQLSanCauLong
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTrove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDTDV = new System.Windows.Forms.DataGridView();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThueDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDTDVu = new System.Windows.Forms.TextBox();
            this.txtDTTP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDTSan = new System.Windows.Forms.DataGridView();
            this.ngaythue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDTSan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaythue = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTDV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTSan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1185, 68);
            this.label9.TabIndex = 40;
            this.label9.Text = "BẢNG THỐNG KÊ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.Color.Transparent;
            this.btnTrove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrove.BackgroundImage")));
            this.btnTrove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Location = new System.Drawing.Point(457, 568);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(143, 74);
            this.btnTrove.TabIndex = 45;
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Doanh thu toàn phần:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvDTDV);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtDTDVu);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(523, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 367);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doanh thu từ Dịch Vụ";
            // 
            // dgvDTDV
            // 
            this.dgvDTDV.AllowUserToResizeColumns = false;
            this.dgvDTDV.AllowUserToResizeRows = false;
            this.dgvDTDV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDV,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien,
            this.NgayThueDV});
            this.dgvDTDV.Location = new System.Drawing.Point(14, 22);
            this.dgvDTDV.Name = "dgvDTDV";
            this.dgvDTDV.ReadOnly = true;
            this.dgvDTDV.Size = new System.Drawing.Size(565, 279);
            this.dgvDTDV.TabIndex = 7;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "tendv";
            this.TenDV.HeaderText = "Tên DV";
            this.TenDV.Name = "TenDV";
            this.TenDV.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "dongia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soluong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "thanhtien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // NgayThueDV
            // 
            this.NgayThueDV.DataPropertyName = "ngaythue";
            this.NgayThueDV.HeaderText = "Ngày Thuê";
            this.NgayThueDV.Name = "NgayThueDV";
            this.NgayThueDV.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(458, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đồng";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(51, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng doanh thu của DV";
            // 
            // txtDTDVu
            // 
            this.txtDTDVu.Location = new System.Drawing.Point(237, 319);
            this.txtDTDVu.Name = "txtDTDVu";
            this.txtDTDVu.Size = new System.Drawing.Size(195, 23);
            this.txtDTDVu.TabIndex = 3;
            // 
            // txtDTTP
            // 
            this.txtDTTP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTTP.Location = new System.Drawing.Point(799, 106);
            this.txtDTTP.Name = "txtDTTP";
            this.txtDTTP.Size = new System.Drawing.Size(239, 33);
            this.txtDTTP.TabIndex = 47;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dgvDTSan);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDTSan);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 367);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh thu từ Sân";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(426, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đồng";
            // 
            // dgvDTSan
            // 
            this.dgvDTSan.AllowUserToResizeColumns = false;
            this.dgvDTSan.AllowUserToResizeRows = false;
            this.dgvDTSan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDTSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDTSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngaythue,
            this.dataGridViewTextBoxColumn5,
            this.TenSan,
            this.maca,
            this.GiaSan});
            this.dgvDTSan.Location = new System.Drawing.Point(6, 22);
            this.dgvDTSan.Name = "dgvDTSan";
            this.dgvDTSan.ReadOnly = true;
            this.dgvDTSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDTSan.Size = new System.Drawing.Size(492, 280);
            this.dgvDTSan.TabIndex = 3;
            // 
            // ngaythue
            // 
            this.ngaythue.DataPropertyName = "ngaythue";
            this.ngaythue.HeaderText = "Ngày thuê";
            this.ngaythue.Name = "ngaythue";
            this.ngaythue.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "masan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã sân";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // TenSan
            // 
            this.TenSan.DataPropertyName = "tensan";
            this.TenSan.HeaderText = "Tên Sân";
            this.TenSan.Name = "TenSan";
            this.TenSan.ReadOnly = true;
            // 
            // maca
            // 
            this.maca.DataPropertyName = "maca";
            this.maca.HeaderText = "Mã ca";
            this.maca.Name = "maca";
            this.maca.ReadOnly = true;
            this.maca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maca.Width = 80;
            // 
            // GiaSan
            // 
            this.GiaSan.DataPropertyName = "giasan";
            this.GiaSan.HeaderText = "Giá Sân";
            this.GiaSan.Name = "GiaSan";
            this.GiaSan.ReadOnly = true;
            this.GiaSan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.GiaSan.Width = 120;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng doanh thu của Sân";
            // 
            // txtDTSan
            // 
            this.txtDTSan.Location = new System.Drawing.Point(204, 319);
            this.txtDTSan.Name = "txtDTSan";
            this.txtDTSan.Size = new System.Drawing.Size(195, 23);
            this.txtDTSan.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.datengaythue);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 100);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo ngày";
            // 
            // datengaythue
            // 
            this.datengaythue.CustomFormat = "dd/MM/yyyy";
            this.datengaythue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datengaythue.Location = new System.Drawing.Point(11, 41);
            this.datengaythue.Name = "datengaythue";
            this.datengaythue.Size = new System.Drawing.Size(227, 23);
            this.datengaythue.TabIndex = 17;
            this.datengaythue.ValueChanged += new System.EventHandler(this.datengaythue_ValueChanged);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1185, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtDTTP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.label9);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTDV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTSan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThueDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDTDVu;
        private System.Windows.Forms.TextBox txtDTTP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDTSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maca;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDTSan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datengaythue;
    }
}
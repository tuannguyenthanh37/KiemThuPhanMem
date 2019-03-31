using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PMQLSanCauLong
{
    public partial class FormDatSan : Form
    {
        string strcon = @"server=DESKTOP-JCSIIUM;database=DBSanCauLong;integrated security=true";
        int co;


        SqlDataAdapter dtpDSSan;
        SqlDataAdapter dtpCT;
        SqlDataAdapter dtpPTS;
        SqlDataAdapter dtpKH;
        SqlDataAdapter dtpDSDV;

        DataSet dts = new DataSet();
        BindingSource bdsSCL = new BindingSource();
        BindingSource bdsCT = new BindingSource();
        BindingSource bdsKH = new BindingSource();

        BindingSource bdsPTS = new BindingSource();
        BindingSource bdsCTTS = new BindingSource();
        BindingSource bdsCTSan = new BindingSource();
        BindingSource bdsDSDV = new BindingSource();

        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        public FormDatSan()
        {
            InitializeComponent();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDatSan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);

            btnGhiKH.Enabled = false;
            dtpDSSan = new SqlDataAdapter("select * from sancaulong", strcon);
            dtpDSSan.FillSchema(dts, SchemaType.Source, "sancaulong");
            dtpDSSan.Fill(dts, "sancaulong");
            bdsSCL.DataSource = dts;
            bdsSCL.DataMember = "sancaulong";
            dgvSanCL.DataSource = bdsSCL;

            dtpDSDV = new SqlDataAdapter("select * from dichvu", strcon);
            dtpDSDV.FillSchema(dts, SchemaType.Source, "dichvu");
            dtpDSDV.Fill(dts, "dichvu");
            bdsDSDV.DataSource = dts;
            bdsDSDV.DataMember = "dichvu";

            this.cboTenDV.DataSource = dts.Tables["dichvu"];
            this.cboTenDV.DisplayMember = "tendv";
            this.cboTenDV.ValueMember = "madv";

            dtpCT = new SqlDataAdapter("select * from cathue", strcon);
            dtpCT.FillSchema(dts, SchemaType.Source, "cathue");
            dtpCT.Fill(dts, "cathue");
            bdsCT.DataSource = dts;
            bdsCT.DataMember = "cathue";
            dgvTrangThai.DataSource = bdsCT;


            dtpPTS = new SqlDataAdapter("select * from phieuthuesan", strcon);
            dtpPTS.FillSchema(dts, SchemaType.Source, "phieuthuesan");
            dtpPTS.Fill(dts, "phieuthuesan");
            bdsPTS.DataSource = dts;
            bdsPTS.DataMember = "phieuthuesan";

            dtpPTS = new SqlDataAdapter("select * from ctthuesan", strcon);
            dtpPTS.FillSchema(dts, SchemaType.Source, "ctthuesan");
            dtpPTS.Fill(dts, "ctthuesan");
            bdsPTS.DataSource = dts;
            bdsPTS.DataMember = "ctthuesan";

            dtpKH = new SqlDataAdapter("select * from khachhang", strcon);
            dtpKH.FillSchema(dts, SchemaType.Source, "khachhang");
            dtpKH.Fill(dts, "khachhang");
            bdsKH.DataSource = dts;
            bdsKH.DataMember = "khachhang";

            //cboCathue.DataSource = bdsCT;
            //cboCathue.DisplayMember = "MaCa";
            //cboCathue.ValueMember = "";

            //cboTenSan.DataSource = bdsSCL;
            //cboTenSan.DisplayMember = "MaSan";
            //cboTenSan.ValueMember = "MaSan";

            dgvSanCL.RowHeadersVisible = false;
            dgvTrangThai.RowHeadersVisible = false;
            dgvKH.RowHeadersVisible = false;
            dgvCTSAN.RowHeadersVisible = false;
            dgvDatDV.RowHeadersVisible = false;
            //thiết lập chế độ đánh dấu chọn cả dòng
            dgvSanCL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrangThai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTSAN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //thiết lập k cho phép ng` dùng thay đổi kích thước
            dgvSanCL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTrangThai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSanCL.ColumnHeadersHeight = 30;
            dgvTrangThai.ColumnHeadersHeight = 30;
            //thiet lap luoi o che do ko cho them va xoa
            dgvSanCL.AllowUserToAddRows = false;
            dgvSanCL.AllowUserToDeleteRows = false;
            dgvTrangThai.AllowUserToAddRows = false;
            dgvTrangThai.AllowUserToDeleteRows = false;
            dgvCTSAN.AllowUserToAddRows = false;
            dgvDatDV.AllowUserToAddRows = false;
            dgvKH.AllowUserToDeleteRows = false;
            dgvKH.AllowUserToAddRows = false;
            //ko cho sửa combo
            this.cboTenDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dgvTrangThai.Enabled = false;

            //chon doi tuong luoi la hien hanh
            dgvSanCL.Rows[0].Selected = true;
            dgvTrangThai.Rows[0].Selected = true;
            //thiet lap che do chi chon 1 dong trong luoi tai 1 thoi diem
            dgvSanCL.MultiSelect = false;

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.HeaderText = "Chọn";
            dgvCTSAN.Columns.Add(col);

            DataGridViewCheckBoxColumn coldv = new DataGridViewCheckBoxColumn();
            coldv.HeaderText = "Chọn";
            dgvDatDV.Columns.Add(coldv);

            //an text
            //cboTenSan.Enabled = false;
            //cboCathue.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            txtGhiChu.Enabled = false;
            txtSDT.Enabled = false;
            btnGhiKH.Enabled = false;

            btnInPTS.Enabled = false;
            dgvTrangThai_Click(sender, e);
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            int LayMAKH;
            int count = 0;
            
            if (string.IsNullOrEmpty(this.txtTenKH.Text) || string.IsNullOrEmpty(this.txtSDT.Text) || string.IsNullOrEmpty(this.txtDiaChi.Text))
            {
                
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (co == 1)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO khachhang VALUES(N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "', N'" + txtSDT.Text + "')", conn);
                    count = cmd.ExecuteNonQuery();

                    string QueryMaKH = "SELECT MAX(makh) FROM khachhang";
                    SqlCommand cmdMaKH = new SqlCommand(QueryMaKH, conn);
                    LayMAKH = (int)cmdMaKH.ExecuteScalar();
                }
                else
                {
                    count = 1;
                    LayMAKH = int.Parse(dgvKH.CurrentRow.Cells["makh"].Value.ToString());
                }

                SqlDataAdapter dtpPTS = new SqlDataAdapter("SELECT * FROM phieuthuesan", conn);
                SqlCommandBuilder cmbdPTS = new SqlCommandBuilder(dtpPTS);
                dtpPTS.Fill(dts, "phieuthuesan");
                DataRow rowPTS = dts.Tables["phieuthuesan"].NewRow();
                rowPTS["makh"] = LayMAKH;
                rowPTS["ngaythue"] = DateTime.Today;
                rowPTS["TongTien"] = txtTongTienThanhToan.Text;
                dts.Tables["phieuthuesan"].Rows.Add(rowPTS);
                dtpPTS.Update(dts, "phieuthuesan");

                string queryPTS = "SELECT MAX(maphieuthue) FROM phieuthuesan";
                SqlCommand cmdP = new SqlCommand(queryPTS, conn);
                int MAPTS = (int)cmdP.ExecuteScalar();

                for (int i = 0; i < dgvCTSAN.Rows.Count; i++)
                {
                    if (dgvCTSAN.Rows[i].Cells[i].Value != null)
                    {
                        string ms = dgvCTSAN.Rows[i].Cells["MaSann"].Value.ToString();
                        string ts = dgvCTSAN.Rows[i].Cells["TenSann"].Value.ToString();
                        string mc = dgvCTSAN.Rows[i].Cells["MaCaa"].Value.ToString();
                        string ngaysdsan = dgvCTSAN.Rows[i].Cells["NgaySDSan"].Value.ToString();
                        string gs = dgvCTSAN.Rows[i].Cells["GiaSann"].Value.ToString();

                        SqlDataAdapter dtpCTTS = new SqlDataAdapter("SELECT * FROM ctthuesan", conn);
                        SqlCommandBuilder cmbdCTTS = new SqlCommandBuilder(dtpCTTS);
                        dtpCTTS.Fill(dts, "ctthuesan");
                        DataRow rowCTTS = dts.Tables["ctthuesan"].NewRow();
                        rowCTTS["maphieuthue"] = MAPTS;
                        rowCTTS["masan"] = ms.ToString();
                        rowCTTS["maca"] = mc.ToString();
                        rowCTTS["ngaysdsan"] = ngaysdsan.ToString();
                        rowCTTS["ghichu"] = txtGhiChu.Text;
                        dts.Tables["ctthuesan"].Rows.Add(rowCTTS);
                        dtpCTTS.Update(dts, "ctthuesan");
                    }
                }
                if (dgvDatDV.RowCount > 0)
                {
                    for (int i = 0; i < dgvDatDV.Rows.Count; i++)
                    {
                        if (dgvDatDV.Rows[i].Cells[i].Value != null)
                        {
                            string mdv = dgvDatDV.Rows[i].Cells["MaDV"].Value.ToString();
                            string tdv = dgvDatDV.Rows[i].Cells["TenDV"].Value.ToString();
                            string dg = dgvDatDV.Rows[i].Cells["Dongia"].Value.ToString();
                            string sl = dgvDatDV.Rows[i].Cells["Soluong"].Value.ToString();
                            string tt = dgvDatDV.Rows[i].Cells["ThanhTien"].Value.ToString();

                            SqlDataAdapter dtpDatDV = new SqlDataAdapter("SELECT * FROM ctdichvu", conn);
                            SqlCommandBuilder cmbdDatDV = new SqlCommandBuilder(dtpDatDV);
                            dtpDatDV.Fill(dts, "ctdichvu");
                            DataRow rowDatDV = dts.Tables["ctdichvu"].NewRow();
                            rowDatDV["maphieuthue"] = MAPTS;
                            rowDatDV["madv"] = mdv.ToString();
                            rowDatDV["soluong"] = int.Parse(sl.ToString());
                            dts.Tables["ctdichvu"].Rows.Add(rowDatDV);
                            dtpDatDV.Update(dts, "ctdichvu");
                        }
                    }
                }

                if (count > 0)
                {
                    MessageBox.Show("Đặt sân thành công!!");
                    
                    btnDatSan.Enabled = false;
                    dgvSanCL.Enabled = true;
                    dgvKH.Enabled = false;
                    dgvTrangThai.Enabled = false;
                    dgvCTSAN.Enabled = false;
                    dgvKH.Refresh();
                    dgvCTSAN.Rows.Clear();
                    dgvDatDV.Rows.Clear();
                    dgvSanCL_Click(sender, e);
                    txtTenKH.Clear();
                    txtSDT.Clear();
                    txtGhiChu.Clear();
                    txtDiaChi.Clear();

                }

                else 
                    MessageBox.Show("Không thể đặt sân");
                this.dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
                dgvTrangThai.Update();
                dgvSanCL.Update();
                dgvSanCL.Refresh();
                dgvTrangThai.Refresh();
                dgvTrangThai_Click(sender, e);
                txtGhiChu.Clear();
                btnDatSan.Enabled = false;
                btnInPTS.Enabled = true;
                dgvCTSAN.Enabled = false;
                dgvDatDV.Enabled = false;

                conn.Close();
            }
        }

        private void dgvTrangThai_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            BindingSource bdsTTKH = new BindingSource();
            SqlDataAdapter dtpTTKH;

            btnInPTS.Enabled = false;
            txtTenKH.Focus();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();
            btnDatSan.Enabled = true;
            dgvKH.Enabled = true;
            if (dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor == Color.Red)
            {
                btnInPTS.Enabled = true;
                btnDatSan.Enabled = false;
                txtTenKH.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                txtGhiChu.Enabled = false;
                dgvKH.Enabled = false;
                dtpTTKH = new SqlDataAdapter("select tenkh,diachi,sdt,ngaythue,ghichu from khachhang, PhieuThueSan,CTThueSan where KhachHang.MaKH=PhieuThueSan.MaKH and PhieuThueSan.MaPhieuThue=CTThueSan.MaPhieuThue and CTThueSan.MaSan='" + dgvSanCL.SelectedRows[0].Cells[0].Value.ToString() + "'and CTThueSan.MaCa='" + dgvTrangThai.SelectedRows[0].Cells[0].Value.ToString() + "' and CTThueSan.NgaySDSan='" + dateNgaySDSan.Value.ToShortDateString() + "'", strcon);
                dtpTTKH.FillSchema(ds, SchemaType.Source, "KhachHang");
                dtpTTKH.Fill(ds, "KhachHang");
                bdsTTKH.DataSource = ds;
                bdsTTKH.DataMember = "KhachHang";

                txtTenKH.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtSDT.DataBindings.Clear();
                txtGhiChu.DataBindings.Clear();

                this.txtTenKH.DataBindings.Add("text", bdsTTKH, "tenkh");
                this.txtDiaChi.DataBindings.Add("text", bdsTTKH, "diachi");
                this.txtSDT.DataBindings.Add("text", bdsTTKH, "sdt");
                this.txtGhiChu.DataBindings.Add("text", bdsTTKH, "ghichu");
            } 
        }

        private void dgvSanCL_Click(object sender, EventArgs e)
        {
            dgvTrangThai.Enabled = true;
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            for (int i = 0; i < dgvTrangThai.Rows.Count; i++)
            {
                dgvTrangThai.Rows[i].DefaultCellStyle.BackColor = Color.White;

                if (dateNgaySDSan.Value < DateTime.Now.Date)
                {
                    dgvTrangThai.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
                if (dateNgaySDSan.Value.Date == DateTime.Now.Date)
                {
                    string giobd = "" + dgvTrangThai.Rows[i].Cells[1].Value;
                    string[] laygiobd;
                    laygiobd = giobd.Split('h');
                    if (int.Parse(laygiobd[0]) <= DateTime.Now.Hour)
                    {
                        dgvTrangThai.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }

                string cathue = "";
                int ca = i + 1;
                if (ca <= 9)
                {
                    cathue = "CA0" + ca.ToString();
                }
                else
                {
                    cathue = "CA" + ca.ToString();
                }
                SqlDataAdapter da = new SqlDataAdapter("select Cathue.MaCa from CaThue,CTThueSan,PhieuThueSan where CaThue.MaCa=CTThueSan.MaCa and PhieuThueSan.MaPhieuThue=CTThueSan.MaPhieuThue and CTThuesan.MaSan='" + dgvSanCL.SelectedRows[0].Cells[0].Value.ToString() + "' and ctthuesan.NgaySDSan='" + dateNgaySDSan.Value.ToShortDateString() + "'and cathue.MaCa='" + cathue + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvTrangThai.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                }

                if (dgvCTSAN.Rows.Count > 0)
                {
                    int rowmasan = dgvSanCL.SelectedCells[0].RowIndex;
                    DataGridViewRow rowms = dgvSanCL.Rows[rowmasan];
                    string sa = rowms.Cells[0].Value.ToString();

                    for (int n = 0; n < dgvCTSAN.Rows.Count; n++)
                    {
                        string masann = "" + dgvCTSAN.Rows[n].Cells[0].Value;
                        string ngayy = "" + dgvCTSAN.Rows[n].Cells[3].Value;

                        if (sa == masann && dgvCTSAN.Rows[n].Cells[2].Value == dgvTrangThai.Rows[i].Cells[0].Value && ngayy == dateNgaySDSan.Value.ToShortDateString())
                        {
                            dgvTrangThai.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                    }
                }
            }
        }
        //kiểm tra sđt
        public bool ktso(string pvalue)
        {
            foreach (Char c in pvalue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {
                txtTenKH.Text = r.Cells[1].Value.ToString();
                txtDiaChi.Text = r.Cells[2].Value.ToString();
                txtSDT.Text = r.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        //gán dịch vụ 
        public void GanDV(DataGridViewRow r)
        {
            try
            {
                cboTenDV.Text = r.Cells[1].Value.ToString();
                txtDongia.Text = r.Cells[2].Value.ToString();
                txtSoluong.Text = r.Cells[3].Value.ToString();
                txtThanhTien.Text = r.Cells[4].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtGhiChu.Clear();
            txtTimKiem.Clear();
            btnGhiKH.Enabled = true;
            while (dgvKH.Rows.Count > 0)
            {
                dgvKH.Rows.RemoveAt(0);
            }
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtGhiChu.Enabled = true;
            txtTenKH.Focus();
            txtTimKiem.Enabled = false; 
        }

        private void btnGhiKH_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            co = 1;
            if (string.IsNullOrEmpty(this.txtTenKH.Text) || string.IsNullOrEmpty(this.txtSDT.Text) || string.IsNullOrEmpty(this.txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                //txtTenKH.Enabled = false;
                //txtDiaChi.Enabled = false;
                //txtGhiChu.Enabled = false;
                //txtSDT.Enabled = false;
                txtTenKH.Focus();
            }
            else
            {
                while (dgvKH.Rows.Count > 0)
                {
                    dgvKH.Rows.RemoveAt(0);
                }
                dgvKH.Rows.Add("", this.txtTenKH.Text, this.txtDiaChi.Text, this.txtSDT.Text, this.txtGhiChu.Text);
                MessageBox.Show("Ghi thành công");
                txtTimKiem.Enabled = true;
                txtTenKH.Enabled = false;
                txtDiaChi.Enabled = false;
                txtGhiChu.Enabled = false;
                txtSDT.Enabled = false;
                btnGhiKH.Enabled = false;
            }
            
            
        }
        private void tongtienthanhtoan()
        {
            int tongtien = 0;
            if (dgvDatDV.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDatDV.Rows.Count; i++)
                {
                    tongtien = tongtien + int.Parse(dgvDatDV.Rows[i].Cells[4].Value.ToString());
                }
            }

            if (dgvCTSAN.Rows.Count > 0)
            {
                for (int i = 0; i < dgvCTSAN.Rows.Count; i++)
                {
                    tongtien = tongtien + int.Parse(dgvCTSAN.Rows[i].Cells[4].Value.ToString());
                }
            }
            this.txtTongTienThanhToan.Text = tongtien.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor == Color.White)
            {
                //DateTime today =  DateTime.Now.Date; 
                //DateTime newday = dateNgaySDSan.Value;
                //int result = today.CompareTo(newday);
                int result = DateTime.Compare(dateNgaySDSan.Value, DateTime.Now.Date);
                if (result >= 0)
                {
                    string ngay = dateNgaySDSan.Value.ToShortDateString();
                    int rowind1 = dgvSanCL.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dgvSanCL.Rows[rowind1];
                    string a = row.Cells[0].Value.ToString();
                    //
                    int rowind2 = dgvSanCL.SelectedCells[0].RowIndex;
                    DataGridViewRow row2 = dgvSanCL.Rows[rowind1];
                    string b = row.Cells[1].Value.ToString();

                    int rowind3 = dgvTrangThai.SelectedCells[0].RowIndex;
                    DataGridViewRow row3 = dgvTrangThai.Rows[rowind3];
                    string c = row3.Cells[0].Value.ToString();

                    int rowind4 = dgvTrangThai.SelectedCells[0].RowIndex;
                    DataGridViewRow row4 = dgvTrangThai.Rows[rowind4];
                    string d = row3.Cells[3].Value.ToString();

                    int rowa = dgvCTSAN.Rows.Add();
                    DataGridViewRow rw3 = dgvCTSAN.Rows[rowa];
                    rw3.Cells[0].Value = a;
                    ///
                    DataGridViewRow rw4 = dgvCTSAN.Rows[rowa];
                    rw4.Cells[1].Value = b;
                    //
                    DataGridViewRow rw5 = dgvCTSAN.Rows[rowa];
                    rw5.Cells[2].Value = c;

                    DataGridViewRow rw6 = dgvCTSAN.Rows[rowa];
                    rw6.Cells[4].Value = d;

                    DataGridViewRow rw7 = dgvCTSAN.Rows[rowa];
                    rw7.Cells[3].Value = ngay;

                }
                dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor = Color.Aqua;
            }
            else
                if (dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor == Color.Gray)
                {
                    MessageBox.Show("Ngày giờ sử dụng phải lớn hơn hoặc bằng ngày giờ hệ thống");
                }
            if (dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor == Color.Red)
            {
                MessageBox.Show("Ca này đã có người đặt", "Thông báo");
            }
            if (dgvTrangThai.SelectedRows[0].DefaultCellStyle.BackColor == Color.Aqua)
            {
                MessageBox.Show("Ca này đang được chọn", "Thông báo");
            }

            tongtienthanhtoan();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dgvKH.Rows[e.RowIndex];
                GanDK(r);
            }
            catch {
                
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dtpTimKH;
            BindingSource bdsTimKH = new BindingSource();
            while (dgvKH.Rows.Count > 0)
            {
                dgvKH.Rows.RemoveAt(0);
            }
            co = 0;

            if (rdiTenKH.Checked)
            {
                dtpTimKH = new SqlDataAdapter("select * from khachhang where tenkh like N'%" + txtTimKiem.Text + "%'", strcon);
                dtpTimKH.FillSchema(dts, SchemaType.Source, "khachhangtim");
                dtpTimKH.Fill(dts, "khachhangtim");
                bdsTimKH.DataSource = dts;
                bdsTimKH.DataMember = "khachhangtim";
                dgvKH.DataSource = bdsTimKH;
            }

            if (rdiSDT.Checked)
            {
                dtpTimKH = new SqlDataAdapter("select * from khachhang where sdt like '%" + int.Parse(txtTimKiem.Text) + "%'", strcon);
                dtpTimKH.FillSchema(dts, SchemaType.Source, "khachhangtim");
                dtpTimKH.Fill(dts, "khachhangtim");
                bdsTimKH.DataSource = dts;
                bdsTimKH.DataMember = "khachhangtim";
                dgvKH.DataSource = bdsTimKH;
            }
        }

        private void cboTenDV_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string s = "select dongia, donvitinh from dichvu where madv='" + cboTenDV.SelectedValue.ToString() + "' ";
            SqlCommand cmm = new SqlCommand(s, conn);
            SqlDataReader dr = cmm.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtDongia.Text = dr["dongia"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "" || txtDongia.Text == "")
            {
                txtThanhTien.Text = "";
                return;
            }
            else
            {
                try
                {
                    txtThanhTien.Text = (Double.Parse(txtSoluong.Text) * Double.Parse(txtDongia.Text)).ToString();
                }
                catch
                {
                    MessageBox.Show("Giá trị nhập phải là số");
                }
            }
        }

        private void btnChonDV_Click(object sender, EventArgs e)
        {
            int LayMADV;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (string.IsNullOrEmpty(this.txtSoluong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo");
                txtSoluong.Focus();
            }
            else
            {
                string QueryMaDV = "select madv from dichvu where madv='" + cboTenDV.SelectedValue.ToString() + "'";
                SqlCommand cmdMaDV = new SqlCommand(QueryMaDV, conn);
                LayMADV = (int)cmdMaDV.ExecuteScalar();
                double sl;
                if (dgvDatDV.Rows.Count == 0)
                {
                    dgvDatDV.Rows.Add(LayMADV.ToString(), this.cboTenDV.Text, this.txtDongia.Text, this.txtSoluong.Text, this.txtThanhTien.Text);
                }

                else
                {
                    for (int i = 0; i < dgvDatDV.Rows.Count; i++)
                    {
                        if (Double.Parse(dgvDatDV.Rows[i].Cells[0].Value.ToString()) == LayMADV)
                        {
                            sl = Double.Parse(dgvDatDV.Rows[i].Cells[3].Value.ToString()) + (Double.Parse(txtSoluong.Text));
                            dgvDatDV.Rows[i].Cells[3].Value = sl;
                            dgvDatDV.Rows[i].Cells[4].Value = sl * (Double.Parse((txtDongia.Text)));
                            break;
                        }
                        dgvDatDV.Rows.Add(LayMADV.ToString(), this.cboTenDV.Text, this.txtDongia.Text, this.txtSoluong.Text, this.txtThanhTien.Text);
                    }
                }

//if (dgvCTSAN.Rows.Count > 0)
//                {
//                    int rowmasan = dgvSanCL.SelectedCells[0].RowIndex;
//                    DataGridViewRow rowms = dgvSanCL.Rows[rowmasan];
//                    string sa = rowms.Cells[0].Value.ToString();

//                    for (int n = 0; n < dgvCTSAN.Rows.Count; n++)
//                    {
//                        string masann = "" + dgvCTSAN.Rows[n].Cells[0].Value;
//                        string ngayy = "" + dgvCTSAN.Rows[n].Cells[3].Value;

//                        if (sa == masann && dgvCTSAN.Rows[n].Cells[2].Value == dgvTrangThai.Rows[i].Cells[0].Value && ngayy == dateNgaySDSan.Value.ToShortDateString())
//                        {
//                            dgvTrangThai.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
//                        }
//                    }
//                }

                

                tongtienthanhtoan();
                txtSoluong.Clear();
            }
            conn.Close();
        }

        private void dgvCTSAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || dgvCTSAN.SelectedRows.Count <= 0)
                return;
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                return;
            dgvCTSAN.ShowEditingIcon = true;
            DataGridViewSelectedRowCollection select = dgvCTSAN.SelectedRows;
            foreach (DataGridViewRow row in select)
            {
                dgvCTSAN.Rows.Remove(row);
            }
            dgvTrangThai.SelectedRows[0].Visible = true;
        }

        private void dgvDatDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || dgvDatDV.SelectedRows.Count <= 0)
                return;
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                return;
            dgvDatDV.ShowEditingIcon = true;
            DataGridViewSelectedRowCollection select = dgvDatDV.SelectedRows;
            foreach (DataGridViewRow row in select)
            {
                dgvDatDV.Rows.Remove(row);
            }
        }

        private void dgvDatDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rdv = dgvDatDV.Rows[e.RowIndex];
                GanDV(rdv);
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoluong.Enabled = true;
            int icountSelectedRow = dgvDatDV.SelectedRows.Count;
            if (icountSelectedRow == 0)
                 MessageBox.Show("Bạn hãy chọn dòng cần cập nhật lại dữ liệu!");
            else if (icountSelectedRow == 1) 
            {
                 dgvDatDV.CurrentRow.Cells[1].Value = cboTenDV.Text;
                 dgvDatDV.CurrentRow.Cells[2].Value = txtDongia.Text;
                 dgvDatDV.CurrentRow.Cells[3].Value = txtSoluong.Text;
                 dgvDatDV.CurrentRow.Cells[4].Value = txtThanhTien.Text;
                 tongtienthanhtoan();
            }

            else 
                 MessageBox.Show("Bạn chỉ có thể chọn 1 dòng để cập nhật lại dữ liệu!");
            }
        private void lnkCheckSan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < dgvCTSAN.Rows.Count; i++)
            {
                dgvCTSAN.Rows[i].Cells[5].Value = true;
            }
        }

        private void btnXoaSan_Click(object sender, EventArgs e)
        {
            for (int i = dgvCTSAN.Rows.Count - 1; i >= 0; i--)
            {
                bool check = (bool)dgvCTSAN.Rows[i].Cells[5].FormattedValue;
                if (check == true)
                {
                    dgvCTSAN.Rows.RemoveAt(i);
                }
                dgvSanCL_Click(sender, e);
                dgvTrangThai.Refresh();

                tongtienthanhtoan();
            }
        }

        private void dateNgaySDSan_ValueChanged(object sender, EventArgs e)
        {
            dgvTrangThai.Refresh();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            for (int i = dgvDatDV.Rows.Count - 1; i >= 0; i--)
            {
                bool check = (bool)dgvDatDV.Rows[i].Cells[5].FormattedValue;
                if (check == true)
                {
                    dgvDatDV.Rows.RemoveAt(i);
                }
                dgvSanCL_Click(sender, e);
                dgvTrangThai.Refresh();
                tongtienthanhtoan();
            }
        }

        private void lnkCheckDV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < dgvDatDV.Rows.Count; i++)
            {
                dgvDatDV.Rows[i].Cells[5].Value = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnInPTS_Click(object sender, EventArgs e)
        {

        }
    }
}

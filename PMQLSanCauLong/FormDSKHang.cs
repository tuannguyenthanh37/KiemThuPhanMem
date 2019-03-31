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
    public partial class FormDSKHang : Form
    {
        string strcon = @"server=DESKTOP-JCSIIUM;database=DBSanCauLong;integrated security=true";
        SqlDataAdapter dtpPTS;
        SqlDataAdapter dtpDV;
        SqlDataAdapter dtpCTDV;
        SqlDataAdapter dtpCTTS;
        SqlConnection conn;
        DataSet dts = new DataSet();
        BindingSource bdsPTS = new BindingSource();
        BindingSource bdsCTTS = new BindingSource();
        BindingSource bdsDV = new BindingSource();
        BindingSource bdsCTDV = new BindingSource();
        int co;

        public FormDSKHang()
        {
            InitializeComponent();
        }

        private void FormDSKHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            dtpPTS = new SqlDataAdapter("select phieuthuesan.maphieuthue,tenkh,diachi,sdt,ngaythue,tongtien from khachhang,phieuthuesan where khachhang.makh=phieuthuesan.makh", conn);
            dtpPTS.FillSchema(dts, SchemaType.Source, "phieuthuesan");
            dtpPTS.Fill(dts, "phieuthuesan");
            bdsPTS.DataSource = dts;
            bdsPTS.DataMember = "phieuthuesan";
            dgvKH.DataSource = bdsPTS;


            dtpCTTS = new SqlDataAdapter("select phieuthuesan.maphieuthue,ctthuesan.masan,ctthuesan.maca,ngaysdsan,ghichu from phieuthuesan,ctthuesan where phieuthuesan.maphieuthue=ctthuesan.maphieuthue", conn);
            dtpCTTS.FillSchema(dts, SchemaType.Source, "ctthuesan");
            dtpCTTS.Fill(dts, "ctthuesan");
            bdsCTTS.DataSource = dts;
            bdsCTTS.DataMember = "ctthuesan";
            dgvCTTS.DataSource = bdsCTTS;

            dtpDV = new SqlDataAdapter("select * from dichvu ", strcon);
            dtpDV.FillSchema(dts, SchemaType.Source, "dichvu");
            dtpDV.Fill(dts, "dichvu");
            bdsDV.DataSource = dts;

            dtpCTDV = new SqlDataAdapter("select ctdichvu.maphieuthue,ctdichvu.MaDV,TenDV,soluong,dongia from DichVu,CTDichVu where DichVu.MaDV=CTDichVu.MaDV ", strcon);
            dtpCTDV.FillSchema(dts, SchemaType.Source, "ctdichvu");
            dtpCTDV.Fill(dts, "ctdichvu");
            bdsCTDV.DataSource = dts;
            bdsCTDV.DataMember = "ctdichvu";
            dgvCTDV.DataSource = bdsCTDV;

            dtpPTS.TableMappings.Add("a", "phieuthuesan");
            dtpPTS.TableMappings.Add("b", "ctthuesan");
            dtpPTS.TableMappings.Add("c", "ctdichvu");
            dtpPTS.Fill(dts);
            dts.Tables["phieuthuesan"].Columns["maphieuthue"].ReadOnly = false;
            dts.Relations.Add("R_PTS_CT", dts.Tables["phieuthuesan"].Columns["maphieuthue"], dts.Tables["ctthuesan"].Columns["maphieuthue"]);
            dts.Relations.Add("R_PTS_CTDV", dts.Tables["phieuthuesan"].Columns["maphieuthue"], dts.Tables["ctdichvu"].Columns["maphieuthue"]);

            dgvKH.DataSource = dts.Tables["phieuthuesan"];
            dgvCTTS.DataSource = dts.Tables["phieuthuesan"];
            dgvCTDV.DataSource = dts.Tables["phieuthuesan"];
            dgvCTTS.DataMember = "R_PTS_CT";
            dgvCTDV.DataMember = "R_PTS_CTDV";

            //định dạng
            dgvKH.RowHeadersVisible = false;
            dgvCTTS.RowHeadersVisible = false;
            dgvCTDV.RowHeadersVisible = false;
            //thiết lập chế độ đánh dấu chọn cả dòng
            dgvCTTS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //thiết lập k cho phép ng` dùng thay đổi kích thước
            dgvCTTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //dgvCTDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //thiết lập chế độ chỉ chọn 1 dòng lưới tại 1 thời điểm
            dgvCTTS.MultiSelect = false;
            dgvKH.MultiSelect = false;
            //tô màu
            dgvKH.EnableHeadersVisualStyles = false;
            dgvCTTS.EnableHeadersVisualStyles = false;
            dgvCTDV.EnableHeadersVisualStyles = false;
            //xóa fongf trăng
            dgvCTDV.AllowUserToAddRows = false;
            dgvCTTS.AllowUserToAddRows = false;
            dgvKH.AllowUserToAddRows = false;
            dateNgaySDSan_ValueChanged(sender, e);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string laymaphPH = dgvKH.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmdb = new SqlCommand("delete PhieuThueSan where MaPhieuThue=" + laymaphPH, conn);
            int count1 = cmdb.ExecuteNonQuery();
            if (count1 > 0)
            {
                //int icountSelectedRow = dgvKH.SelectedRows.Count;
                //if (icountSelectedRow == 0)
                //    MessageBox.Show("Bạn hãy chọn dòng cần xoá!");
                //else
                //    foreach (DataGridViewRow row in dgvKH.SelectedRows)
                //        if (!row.IsNewRow) dgvKH.Rows.Remove(row);
                
                MessageBox.Show("Xóa thành công");
                dgvKH.Refresh();
            }
            else
            {
                MessageBox.Show("Không thể xóa");
            }
            conn.Close();
        }

        private void dateNgaySDSan_ValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string ngay_thue = dateNgaySDSan.Value.ToString("yyyy/MM/dd");

            string sql = "select phieuthuesan.maphieuthue as [Mã phiếu thuê],tenkh as [Tên KH],diachi as [Địa chỉ],sdt as [Số điện thoại],ngaythue as [Ngày thuê],tongtien as [Tổng tiền] from khachhang,phieuthuesan where khachhang.makh=phieuthuesan.makh and ngaythue='" + ngay_thue + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            List<object> lst = rd.Cast<object>().ToList();
            dgvKH.DataSource = lst;
            conn.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dtpTimKH;
            BindingSource bdsTimKH = new BindingSource();
            co = 0;
            string ngay_thue = dateNgaySDSan.Value.ToString("yyyy/MM/dd");
            if (rdiTenKH.Checked)
            {
                dtpTimKH = new SqlDataAdapter("select phieuthuesan.maphieuthue as [Mã phiếu thuê],tenkh as [Tên KH],diachi as [Địa chỉ],sdt as [Số điện thoại],ngaythue as [Ngày thuê],tongtien as [Tổng tiền] from khachhang,phieuthuesan where khachhang.makh=phieuthuesan.makh and tenkh like N'%" + txtTimKiem.Text + "%' and ngaythue='" + ngay_thue + "'", strcon);
                DataTable dt = new DataTable();
                dtpTimKH.Fill(dt);
                dgvKH.DataSource = dt;
            }

            if (rdiSDT.Checked)
            {
                dtpTimKH = new SqlDataAdapter("select phieuthuesan.maphieuthue as [Mã phiếu thuê],tenkh as [Tên KH],diachi as [Địa chỉ],sdt as [Số điện thoại],ngaythue as [Ngày thuê],tongtien as [Tổng tiền] from khachhang,phieuthuesan where khachhang.makh=phieuthuesan.makh and sdt like '%" + txtTimKiem.Text + "%' and ngaythue='" + ngay_thue + "'", strcon);
                DataTable dt = new DataTable();
                dtpTimKH.Fill(dt);
                dgvKH.DataSource = dt;
            }
        }

        private void btnXoaSan_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string laymaphPH = dgvCTTS.CurrentRow.Cells[0].Value.ToString();
            string laymasan = dgvCTTS.CurrentRow.Cells[1].Value.ToString();
            string laymaca = dgvCTTS.CurrentRow.Cells[2].Value.ToString();

            

            SqlCommand cmdb = new SqlCommand("delete CTThueSan where MaPhieuThue='" + laymaphPH + "' and MaSan='" + laymasan + "' and MaCa='" + laymaca + "'", conn);
            int count1 = cmdb.ExecuteNonQuery();
            if (count1 > 0)
            {
                int icountSelectedRow = dgvCTTS.SelectedRows.Count;
                if (icountSelectedRow == 0)
                    MessageBox.Show("Bạn hãy chọn dòng cần xoá!");
                else
                    foreach (DataGridViewRow row in dgvCTTS.SelectedRows)
                        if (!row.IsNewRow) dgvCTTS.Rows.Remove(row);
                dgvCTTS.Refresh();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không thể xóa");
            }
            conn.Close();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string laymaphPH3 = dgvCTDV.CurrentRow.Cells[0].Value.ToString();
            string laymadv = dgvCTDV.CurrentRow.Cells[1].Value.ToString();

            SqlCommand cmdb = new SqlCommand("delete CTDichVu where MaPhieuThue='" + laymaphPH3 + "' and MaDV='" + laymadv + "'", conn);
            int count1 = cmdb.ExecuteNonQuery();
            if (count1 > 0)
            {
                int icountSelectedRow = dgvCTTS.SelectedRows.Count;
                if (icountSelectedRow == 0)
                    MessageBox.Show("Bạn hãy chọn dòng cần xoá!");
                else
                    foreach (DataGridViewRow row in dgvCTDV.SelectedRows)
                        if (!row.IsNewRow) dgvCTDV.Rows.Remove(row);
                dgvCTDV.Refresh();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không thể xóa");
            }
            conn.Close();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string laymp = dgvKH.SelectedRows[0].Cells[0].Value.ToString();
            SqlDataAdapter da1 = new SqlDataAdapter("select PhieuThueSan.MaPhieuThue as [Mã Phiếu Thuê], CTThueSan.MaSan as [Mã sân],CTThueSan.MaCa as [Mã ca],cathue.giasan as [Giá Sân],CTThueSan.NgaySDSan as [Ngày SD],CTThueSan.GhiChu as [Ghi chú] from Cathue,PhieuThueSan,CTThueSan where CTThueSan.MaPhieuThue=PhieuThueSan.MaPhieuThue and cathue.maca=ctthuesan.maca and CTThueSan.MaPhieuThue='" + laymp + "'", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvCTTS.DataSource = dt1;
            SqlDataAdapter da = new SqlDataAdapter("select PhieuThueSan.MaPhieuThue as [Mã Phiếu Thuê],ctdichvu.madv as [Mã DV],tendv as [Tên DV],dongia as [Đơn giá],soluong as [Số lượng] from PhieuThueSan,CTDichVu,DichVu where DichVu.MaDV=CTDichVu.MaDV and PhieuThueSan.MaPhieuThue=CTDichVu.MaPhieuThue and PhieuThueSan.MaPhieuThue='" + laymp + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCTDV.DataSource = dt;
            conn.Close();
        }

        private void btnInPTS_Click(object sender, EventArgs e)
        {
            //RP rp = new RP();
            //rp.ShowDialog();
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();
            //string laymaphieuthue = "SELECT MAX(maphieuthue) FROM phieuthuesan";
            //SqlCommand cmdPhieuThue = new SqlCommand(laymaphieuthue, conn);
            //int MaPTS = (int)cmdPhieuThue.ExecuteScalar();
            //if (MessageBox.Show("Thông báo", "Bạn có muốn in Phiếu Thuê Sân không?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    RP myreport = new RP();
            //    //myreport.SetParameterValue();
            //    //Gán nguồn dữ liệu cho đối tượng myreports
            //    myreport.SetDataSource(dts);
            //    //dk loc du lieu
            //    myreport.RecordSelectionFormula = "{phieuthuesan.maphieuthue}=" + MaPTS.ToString() + "";
            //    //khai bao 1 dt kieu crystallreportviewer de hien thi report tren form
            //    CrystalReportViewer cv = new CrystalReportViewer();
            //    cv.Dock = DockStyle.Fill; //khi report hien thi thi tran ra ngoai form
            //    //chi ra report se duoc hien thi
            //    cv.ReportSource = myreport;
            //    //xoa hien thi grouptree
            //    cv.ToolPanelView = ToolPanelViewType.None;
            //    cv.ShowGroupTreeButton = false;
            //    //khong hien thu toolbox
            //    cv.DisplayToolbar = false;
            //    //tao 1 form chua crystallreportviewer
            //    Form f = new Form();
            //    f.WindowState = FormWindowState.Maximized;
            //    //them dieu kien cv vao form
            //    f.Controls.Add(cv);
            //    //hien thi form
            //    f.ShowDialog();
            //}
            //while (dgvKH.Rows.Count > 0)
            //{
            //    dgvKH.Rows.RemoveAt(0);
            //}
            

            //conn.Close();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

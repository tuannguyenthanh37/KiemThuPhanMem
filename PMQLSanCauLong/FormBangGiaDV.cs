using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PMQLSanCauLong
{
    public partial class FormBangGiaDV : Form
    {
        string strcon = @"server=DESKTOP-JCSIIUM;database=DBSanCauLong;integrated security=true";
        SqlConnection conn;

        SqlDataAdapter dtpDV;
        DataSet dts = new DataSet();
        BindingSource bdsDV = new BindingSource();
        SqlCommand cmd = new SqlCommand();

        public FormBangGiaDV()
        {
            InitializeComponent();
        }

        private void FormBangGiaDV_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);

            dtpDV = new SqlDataAdapter("select * from dichvu", strcon);
            dtpDV.FillSchema(dts, SchemaType.Source, "dichvu");
            dtpDV.Fill(dts, "dichvu");
            bdsDV.DataSource = dts;
            bdsDV.DataMember = "dichvu";
            dgvDSDichVu.DataSource = bdsDV;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dichvu", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            bdsDV.DataSource = dt;

            // Gán nguồn dữ liệu cho DataGridView
            dgvDSDichVu.DataSource = bdsDV;

            dgvDSDichVu.Rows[0].Selected = true;

            //canh lề zữa cho tiêu đề các cột
            dgvDSDichVu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //thiết lập k cho phép ng` dùng thay đổi kích thước
            dgvDSDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDSDichVu.ColumnHeadersHeight = 30;
            //thiết lập chế độ đánh dấu chọn cả dòng
            dgvDSDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //thiết lập chế độ chỉ chọn 1 dòng lưới tại 1 thời điểm
            dgvDSDichVu.MultiSelect = false;

            //Chế độ ẩn hiện
            btnGhiDV.Visible = false;
            btnKhongDV.Visible = false;
            btnCapNhat.Visible = false;

            //Chế độ mờ txt
            txtTenHH.Enabled = false;
            txtDVT.Enabled = false;
            txtDongia.Enabled = false;
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {
                txtTenHH.Text = r.Cells[1].Value.ToString();
                txtDVT.Text = r.Cells[2].Value.ToString();
                txtDongia.Text = r.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvDSDichVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDSDichVu.Rows[e.RowIndex];
            GanDK(r);
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            btnGhiDV.Visible = true;
            btnKhongDV.Visible = true;
            btnSua.Visible = false;
            btnThemDV.Visible = false;
            btnXoaDV.Visible = false;

            txtTenHH.Enabled = true;
            txtDongia.Enabled = true;
            txtDVT.Enabled = true;

            txtTenHH.Clear();
            txtDVT.Clear();
            txtDongia.Clear();
            txtTenHH.Focus();
        }

        private void btnKhongDV_Click(object sender, EventArgs e)
        {
            btnKhongDV.Visible = false;
            btnGhiDV.Visible = false;
            btnCapNhat.Visible = false;
            btnSua.Visible = true;
            btnThemDV.Visible = true;
            btnXoaDV.Visible = true;

            txtTenHH.Enabled = false;
            txtDongia.Enabled = false;
            txtDVT.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnKhongDV.Visible = true;
            btnCapNhat.Visible = true;

            btnSua.Visible = false;
            btnThemDV.Visible = false;
            btnXoaDV.Visible = false;

            txtTenHH.Enabled = true;
            txtDongia.Enabled = true;
            txtDVT.Enabled = true;
            txtTenHH.Focus();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string id = dgvDSDichVu.CurrentRow.Cells["MaDV"].Value.ToString();
            SqlCommand cmd = new SqlCommand("UPDATE dichvu Set tendv = N'" + txtTenHH.Text + "', donvitinh = N'" + txtDVT.Text + "', dongia=N'" + txtDongia.Text + "' WHERE madv = '" + id + "'", conn);

            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                DataRowView row = (DataRowView)bdsDV.Current; // Hàng ch?n hi?n th?i
                row["tendv"] = txtTenHH.Text;
                row["donvitinh"] = txtDVT.Text;
                row["dongia"] = txtDongia.Text;
                bdsDV.ResetCurrentItem();

                MessageBox.Show("Sửa thành công!");
                txtDongia.Enabled = false;
                txtDVT.Enabled = false;
                txtTenHH.Enabled = false;

            }
            else MessageBox.Show("Không sửa được!");
            btnCapNhat.Visible = false;
            btnGhiDV.Visible = false;
            btnKhongDV.Visible = false;
            btnSua.Visible = true;
            btnThemDV.Visible = true;
            btnXoaDV.Visible = true;
        }

        private void btnGhiDV_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dichvu VALUES(N'" + txtTenHH.Text + "',N'" + txtDVT.Text + "', N'" + txtDongia.Text + "')", conn);
            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                DataTable dt = (DataTable)bdsDV.DataSource;
                DataRow row = dt.NewRow();
                row["tendv"] = txtTenHH.Text;
                row["donvitinh"] = txtDVT.Text;
                row["dongia"] = txtDongia.Text;
                dt.Rows.Add(row);

                MessageBox.Show("Thêm mới thành công");
                dgvDSDichVu.Update();
                dgvDSDichVu.Refresh();

            }
            else MessageBox.Show("Không thể thêm mới");
            btnKhongDV.Visible = false;
            btnGhiDV.Visible = false;
            btnCapNhat.Visible = false;
            btnSua.Visible = true;
            btnThemDV.Visible = true;
            btnXoaDV.Visible = true;
            txtTenHH.Enabled = false;
            txtDVT.Enabled = false;
            txtDongia.Enabled = false;
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string laymahh = dgvDSDichVu.CurrentRow.Cells["MaDV"].Value.ToString();
            SqlCommand cmd = new SqlCommand("delete from dichvu where madv='" + laymahh + "'", conn);
            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {

                DataRowView row = (DataRowView)bdsDV.Current;
                row.Delete();

                MessageBox.Show("Xóa thành công");

            }
            else MessageBox.Show("Không thể xóa");
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}

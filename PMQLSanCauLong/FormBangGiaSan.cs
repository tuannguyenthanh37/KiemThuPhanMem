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
    public partial class FormBangGiaSan : Form
    {
        string strcon = @"server=DESKTOP-JCSIIUM;database=DBSanCauLong;integrated security=true";
        SqlConnection conn;
        SqlDataAdapter dtpSCL;

        DataSet dts = new DataSet();
        BindingSource bdsCT = new BindingSource();

        public FormBangGiaSan()
        {
            InitializeComponent();
        }

        private void FormBangGiaSan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            dtpSCL = new SqlDataAdapter("select * from cathue", strcon);
            dtpSCL.FillSchema(dts, SchemaType.Source, "cathue");
            dtpSCL.Fill(dts, "cathue");
            bdsCT.DataSource = dts;
            bdsCT.DataMember = "cathue";
            dgvThogTinSan.DataSource = bdsCT;
            dgvThogTinSan.DataSource = bdsCT;
            dgvThogTinSan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThogTinSan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //thiết lập k cho phép ng` dùng thay đổi kích thước
            dgvThogTinSan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvThogTinSan.RowHeadersVisible = false;
            dgvThogTinSan.Rows[0].Selected = true;

            btnGhi.Visible = false;
            btnKhong.Visible = false;
            txtGiaSan.Enabled = false;
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string Gia = txtGiaSan.Text;
            btnGhi.Visible = false;
            btnKhong.Visible = false;
            btnSua.Visible = true;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string id = dgvThogTinSan.CurrentRow.Cells["MaCa"].Value.ToString();
            string strQuery = "UPDATE cathue Set giasan=" + Gia + " WHERE maca = '" + id + "'";
            SqlCommand cmd = new SqlCommand(strQuery, conn);

            int count = cmd.ExecuteNonQuery();

            if (count > 0)
            {
                DataRowView row = (DataRowView)bdsCT.Current;
                row["giasan"] = Gia;
                bdsCT.ResetCurrentItem();
                MessageBox.Show("Sửa thành công!");
                txtGiaSan.Text = Gia;
                txtGiaSan.Enabled = false;
            }
            else MessageBox.Show("Không sửa được!");
            conn.Close(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnGhi.Visible = true;
            btnKhong.Visible = true;
            btnSua.Visible = false;
            txtGiaSan.Enabled = true;
            txtGiaSan.Focus();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            txtGiaSan.Enabled = false;
            btnGhi.Visible = false;
            btnKhong.Visible = false;
            btnSua.Visible = true;
        }
        public void GanDK(DataGridViewRow r)
        {
            try
            {
                txtMaCa.Text = r.Cells[0].Value.ToString();
                txtGioBD.Text = r.Cells[1].Value.ToString();
                txtGioKT.Text = r.Cells[2].Value.ToString();
                txtGiaSan.Text = r.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvThogTinSan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvThogTinSan.Rows[e.RowIndex];
            GanDK(r);
        }

        private void txtGiaSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

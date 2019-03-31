using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMQLSanCauLong
{
    public partial class FormGD : Form
    {
        public FormGD()
        {
            InitializeComponent();
        }

        private void tsbDatSan_Click(object sender, EventArgs e)
        {
            if (!kiemtratrung("FormDatSan"))
            {
                FormDatSan f = new FormDatSan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                moform("FormDatSan");
            }
        }
        private bool kiemtratrung(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void moform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void tsbBangGiaSan_Click(object sender, EventArgs e)
        {
            if (!kiemtratrung("FormBangGiaSan"))
            {
                FormBangGiaSan f = new FormBangGiaSan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                moform("FormBangGiaSan");
            }
        }

        private void tsbBangGiaDV_Click(object sender, EventArgs e)
        {
            if (!kiemtratrung("FormBangGiaDV"))
            {
                FormBangGiaDV fr = new FormBangGiaDV();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                moform("FormBangGiaDV");
            }
        }

        private void tsbDSKHang_Click(object sender, EventArgs e)
        {
            if (!kiemtratrung("FormDSKHang"))
            {
                FormDSKHang fr = new FormDSKHang();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                moform("FormDSKHang");
            }
        }

        private void tsbThongKe_Click(object sender, EventArgs e)
        {
            if (!kiemtratrung("FormThongKe"))
            {
                FormThongKe fr = new FormThongKe();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                moform("FormThongKe");
            }
        }

        private void tsbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
        private int childFormNumber = 0;
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
    }
}

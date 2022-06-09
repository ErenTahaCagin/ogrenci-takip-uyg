using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevTakipApp
{
    public partial class frmDetay : Form
    {
        TbOgrenciler ogr;

        public frmDetay(TbOgrenciler ogr2)
        {
            InitializeComponent();

            ogr = ogr2;

            txtNo.Text = ogr.No.ToString();
            txtAd.Text = ogr.Ad;
            txtSoyad.Text = ogr.Soyad;

            txtKonu.Text = ogr.OdevKonusu;
            chkTeslim.Checked = ogr.TeslimEdildiMi.GetValueOrDefault();

            dtpTeslim.Value = ogr.TeslimTarihi.GetValueOrDefault(DateTime.Parse("01.01.2000"));

            if (!chkTeslim.Checked)
                dtpTeslim.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkTeslim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeslim.Checked)
                dtpTeslim.Visible = true;
            else dtpTeslim.Visible = false;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            ogr.No = Convert.ToInt32(txtNo.Text);
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.OdevKonusu = txtKonu.Text;
            ogr.TeslimEdildiMi = chkTeslim.Checked;
            ogr.TeslimTarihi = dtpTeslim.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

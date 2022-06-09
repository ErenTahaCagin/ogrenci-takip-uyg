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
    public partial class Form1 : Form
    {
        OdevDataContext db = new OdevDataContext();
        BindingList<TbOgrenciler> bindList;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;


            List<CinsiyetItem> cinsiyetListesi = new List<CinsiyetItem>();
            cinsiyetListesi.Add(new CinsiyetItem() { Value = null, Display = "-" });
            cinsiyetListesi.Add(new CinsiyetItem() { Value = true, Display = "Erkek" });
            cinsiyetListesi.Add(new CinsiyetItem() { Value = false, Display = "Kadın" });

            colCinsiyet.DataSource = cinsiyetListesi;
            colCinsiyet.DisplayMember = "Display";
            colCinsiyet.ValueMember = "Value";


            var liste = db.TbOgrencilers.ToList();
            bindList = new BindingList<TbOgrenciler>(liste);
            dataGridView1.DataSource = bindList;




        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            foreach(TbOgrenciler item in bindList)
            {
                if (item.Id == 0)
                    db.TbOgrencilers.InsertOnSubmit(item);
            }

            db.SubmitChanges();

            MessageBox.Show("Kayıt Edildi!");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                if (e.ColumnIndex == colDetay.Index)
                {
                    TbOgrenciler ogr = bindList[e.RowIndex] as TbOgrenciler;

                    if (ogr != null)
                    {
                        frmDetay form = new frmDetay(ogr);
                        form.ShowDialog();
                    }
                }
                if (e.ColumnIndex == colSil.Index)
                {
                    TbOgrenciler ogr = bindList[e.RowIndex] as TbOgrenciler;

                    if (ogr != null)
                    {
                        DialogResult cevap = MessageBox.Show(ogr.No + "-" + ogr.Ad + " " + ogr.Soyad + " silmek istediğinize emin misiniz?",
                            "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                        if(cevap==DialogResult.Yes)
                        {
                            if(ogr.Id>0)
                                db.TbOgrencilers.DeleteOnSubmit(ogr);
                            
                            bindList.Remove(ogr);
                        }

                    }
                }
            }


           
        }
    }
}

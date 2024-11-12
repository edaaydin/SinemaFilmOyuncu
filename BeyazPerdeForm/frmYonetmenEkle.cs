using BeyazPerde.Models.Concrete;
using BeyazPerde.Repositories;

namespace BeyazPerdeForm
{
    public partial class frmYonetmenEkle : Form
    {
        public frmYonetmenEkle()
        {
            InitializeComponent();
        }

        private void frmYonetmenEkle_Load(object sender, EventArgs e)
        {
            yonRepo = new YonetmenRepo();
            TumYonetmenleriGetir();
        }

        YonetmenRepo yonRepo;

        public void TumYonetmenleriGetir()
        {
            lsvYonetmenler.Items.Clear();
            ListViewItem item;
            foreach (var lsvItem in yonRepo.ButunAktifleriGetir())
            {
                item = new ListViewItem();
                item.Text = lsvItem.ID.ToString();
                item.SubItems.Add(lsvItem.Ad);
                item.SubItems.Add(lsvItem.Soyad);
                item.SubItems.Add(lsvItem.DogumTarihi.ToString());
                item.Tag = lsvItem;

                lsvYonetmenler.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // textbox vs. dolu data geliyorsa yonetmeni olusturalım.

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            DateTime dt = dtpDogumTarihi.Value;

            try
            {
                if (!string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad) && !string.IsNullOrWhiteSpace(dt.ToString()))
                {
                    Yonetmen yonetmen = new Yonetmen()
                    {
                        Ad = ad,
                        Soyad = soyad,
                        DogumTarihi = dt
                    };
                    yonRepo.Ekle(yonetmen);
                    TumYonetmenleriGetir();
                }
                else
                    MessageBox.Show("Bu alanlari bos gecemezsin!!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Bu alanlari bos gecemezsin!!!");
            }
        }
        Yonetmen yonetmen;

        private void lsvYonetmenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvYonetmenler.SelectedItems.Count > 0) // Gercekten birini sectiysem
            {
                Yonetmen yonetmen = lsvYonetmenler.SelectedItems[0].Tag as Yonetmen;
                txtAd.Text = yonetmen.Ad;
                txtSoyad.Text = yonetmen.Soyad;
                dtpDogumTarihi.Value = yonetmen.DogumTarihi;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            DateTime dt = dtpDogumTarihi.Value;

            try
            {
                if (!string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad) && !string.IsNullOrWhiteSpace(dt.ToString()))
                {
                    yonetmen.Ad = ad;
                    yonetmen.Soyad = soyad;
                    yonetmen.DogumTarihi = dt;
                    yonRepo.YonetmenGuncelle(yonetmen);
                    TumYonetmenleriGetir();
                    Yardimci.Temizle(this.Controls);


                }

                else MessageBox.Show("Bu alanlar bos geçilemez");

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme basarısız!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            yonetmen.IsActive = false;
            yonRepo.Sil(yonetmen.ID);
            MessageBox.Show("Yonetmen silinmistir");
            TumYonetmenleriGetir();
            Yardimci.Temizle(this.Controls);
        }
        //secilen yönetmeni TextBoxlara dolduralım.
    }
}


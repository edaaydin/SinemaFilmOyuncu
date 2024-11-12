using BeyazPerde.Models.Concrete;
using BeyazPerde.Repositories;

namespace BeyazPerdeForm
{
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
            fRepo = new FilmRepo();
            yRepo = new YonetmenRepo();
            oRepo = new OyuncuRepo();
        }
        FilmRepo fRepo;
        YonetmenRepo yRepo;
        OyuncuRepo oRepo;
        private void frmFilmEkle_Load(object sender, EventArgs e)
        {


            TumFilmleriGetir();
            TumYonetmenleriDoldur();
            TumOyunculariDoldur();
        }

        private void TumOyunculariDoldur()
        {
            // listbox'a oyuncuları dolduralım
            lbOyuncular.DataSource = oRepo.ButunAktifleriGetir();
            lbOyuncular.SelectedIndex = -1;
        }

        private void TumYonetmenleriDoldur()
        {
            // Tum yonetmenleri combobox'a dolduralım ki secim sansı olsun.
            cmbYonetmen.DataSource = yRepo.ButunAktifleriGetir();
            cmbYonetmen.SelectedIndex = -1;
            cmbYonetmen.ValueMember = "ID";
            cmbYonetmen.DisplayMember = "Ad"; // Todo : tostring --> metotlastır.
        }

        private void TumFilmleriGetir()
        {
            lsvFilmler.Items.Clear();
            ListViewItem lsv;
            foreach (var item in fRepo.ButunAktifleriGetir())
            {
                Yonetmen yonetmen = yRepo.IdBilgisiIleGetir(item.YonetmenID);

                lsv = new ListViewItem();
                lsv.Text = item.Ad;
                lsv.SubItems.Add(item.YayinlanmaTarihi.ToString());
                lsv.SubItems.Add(yonetmen.ToString());
                lsv.Tag = item;
                lsvFilmler.Items.Add(lsv);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.Ad = txtFilmAd.Text;
            film.YayinlanmaTarihi = dtpYayin.Value;
            film.YonetmenID = (int)(cmbYonetmen.SelectedValue);
            film.Yonetmen = yRepo.IdBilgisiIleGetir((int)(cmbYonetmen.SelectedValue));

            // Oyuncularını ekleyelim.
            foreach (Oyuncu item in lbOyuncular.SelectedItems)
            {
                film.Oyunculari.Add(new OyuncuFilm()
                { OyuncuID = item.ID, FilmID = film.ID });
            }
            fRepo.Ekle(film);
            TumFilmleriGetir();
            Yardimci.Temizle(this.Controls);
        }
    }
}

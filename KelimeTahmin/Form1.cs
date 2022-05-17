using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeTahmin
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        string[] sehirler = {

          "Adana","Adıyaman","Afyonkarahisar","Ağrı","Aksaray","Amasya","Ankara","Antalya","Ardahan","Artvin","Aydın",
          "Balıkesir","Bartın","Batman","Bayburt","Bilecik","Bingöl","Bitlis","Bolu","Burdur","Bursa",
          "Çanakkale","Çankırı","Çorum",
          "Denizli","Diyarbakır","Düzce",
          "Edirne","Elazığ","Erzincan","Erzurum","Esişehir",
          "Gaziantep","Giresun","Gümüşhane",
          "Hakkari","Hatay",
          "Iğdır","Isparta",
          "İstanbul","İzmir",
          "Kahramanmaraş","Karabük","Karaman","Kars","Kastamonu","Kayseri","Kilis","Kırıkkale","Kırklareli","Kırşehir","Kocaeli","Konya","Kütahya",
          "Malatya","Manisa","Mardin","Mersin","Muğla","Muş",
          "Nevşehir","Niğde",
          "Ordu","Osmaniye",
          "Rize",
          "Sakarya","Samsun","Siirt","Sinop","Sivas",
          "Şanlıurfa","Şırnak",
          "Tekirdağ","Tokat","Trabzon","Tunceli",
          "Uşak",
          "Van",
          "Yalova","Yozgat",
          "Zonguldak"
        };

        string buluncakSehirİsmi = "";
        int bulnanHarfSayisi = 0;
        int kalanhak = 5;
        Random rastgele;



        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Çıkış işlemi

            DialogResult dialog = MessageBox.Show("Oyundan çıkmak istediğinize emin misiniz ?", "Çıkış İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            // Formu aşağı alır.

            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTahminEt.Enabled = false;
            btnHarfGir.Enabled = false;
            rastgele = new Random();
            this.AcceptButton = btnHarfGir;
        }


        private void NewCity()
        {
            int rastgeleSayi = rastgele.Next(0, sehirler.Length);
            buluncakSehirİsmi = sehirler[rastgeleSayi];
        }


        public void NewGame()
        {
            questionsArea.Controls.Clear();
            bulnanHarfSayisi = 0;
            btnHarfGir.Enabled = true;
            btnTahminEt.Enabled = true;
            lblGharf.Text ="";
            kalanhak = 5;
            NewCity();

            

            lblAçıklama.Text = "Lütfen yukarıda belirtilen" + " " + buluncakSehirİsmi.Length + " " + "harfli şehiri tahmin ediniz.";
            questionsArea.Controls.Add(lblAçıklama);

            for (int i = 0; i < buluncakSehirİsmi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = buluncakSehirİsmi[i].ToString().ToUpper();
                label.Font = new System.Drawing.Font("Century Gothic", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label.Size = new System.Drawing.Size(15, 30);
                label.BackColor = Color.White;
                label.ForeColor = Color.White;
                questionsArea.Controls.Add(label);
            }
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();

        }

        private void btnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfVarMi = false;
            if (txtLetters.Text.Length != 1)
            {
                MessageBox.Show("Lütfen tek harf giriniz !");
            }
            else
            {
                if (txtLetters.Text.Contains(lblGirilenHarfler.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz !");
                    txtLetters.Text = "";
                    txtLetters.Focus();

                    return;
                }

                foreach (Control item in questionsArea.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper() == txtLetters.Text.ToUpper())
                        {
                            label.ForeColor = Color.White;
                            label.BackColor = Color.Green;
                            harfVarMi = true;
                            bulnanHarfSayisi++;
                        }
                    }
                }


            }

            if (!harfVarMi)
            {
                kalanhak--;
                lblKalanHak.Text = kalanhak.ToString();
                if (kalanhak == 0)
                {
                    btnHarfGir.Enabled = false;
                    btnTahminEt.Enabled = false;
                    DialogResult dialog = MessageBox.Show("Oyun bitti kaybettiniz. Yeni oyuna geçmek ister misiniz ?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        
                        NewGame();
                        txtLetters.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Bulmaya çalıştığınız şehir adı :" + " " + buluncakSehirİsmi);
                        Application.Exit();

                    }
                }
                lblGirilenHarfler.Text += txtLetters.Text + ",";
                if (bulnanHarfSayisi == buluncakSehirİsmi.Length)
                {
                    btnHarfGir.Enabled = false;
                    btnTahminEt.Enabled = false;
                    MessageBox.Show("Tebrikler kazandınız...");
                }          
                txtLetters.Text = "";
                txtLetters.Focus();
            }
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (buluncakSehirİsmi.ToUpper() == txtTahmin.Text.ToUpper())
            {
                foreach (Control item in questionsArea.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.White;
                        label.BackColor = Color.Green;
                    }

                }
                lblAçıklama.Text = "Oyun bitti tebrikeler kazandınız. :)";

            }
            else
            {
                lblAçıklama.Text = "Oyun bitti. Malesef kaybettiniz. Şehir :" + " " + buluncakSehirİsmi;

            }
            btnHarfGir.Enabled = false;
            btnTahminEt.Enabled = false;
        }
    }
}

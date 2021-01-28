using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmKodYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Erişim belirleyicisi  geriye dönüş tipi  fonksiyonun adı (parametre1, parametre 2,)
        //{
        //      Return değer 
        //}
        // Not :  Void fonksiyonun geriye değer döndürmediği anlamına gelir


        //Erişim belirleyicileri aşağıdaki gibidir
        // 1. public: Erişim kısıtlı değildir.
        // 2. private: Erişim, kapsayan tür ile sınırlıdır.
        // 3. protected: Erişim, kapsayan sınıftan türetilmiş kapsayan sınıf veya türlerle sınırlıdır.
        // 4. internal: Erişim, geçerli derleme ile sınırlıdır



        //Dikdörtgenin alanı fanksiyonu aynı kapsayıcının içinde çağılacağından erişim belirleyicisin public yada private olması farketmez

        public double dikdorgenin_alani(double kısa_kenar, double uzun_kenar)
        {
            double alan = kısa_kenar * uzun_kenar;
            return alan;
        }



        //Dikdörtegenin çevresi

        private double dikdortgenin_cevresi(double kısa_kenar, double uzun_kenar)
        {
            double cevresi = 2 * (kısa_kenar + uzun_kenar);
            return cevresi;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double kısa = Convert.ToDouble(txtKisaKenar.Text);
            double uzun = Convert.ToDouble(txtUzunKenar.Text);

            //fonksiyonu çağırma işlemi
            double sonuc = dikdorgenin_alani(kısa, uzun);

            lblSonuc.Text = "Dikdörtgenin alanı=" + sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kısa = Convert.ToDouble(txtKisaKenar.Text);
            double uzun = Convert.ToDouble(txtUzunKenar.Text);

            double sonuc = dikdortgenin_cevresi(kısa, uzun);

            lblSonuc.Text = "Dikdörtgenin çevresi=" + sonuc.ToString();

        }


        //Switch (kontrol edilecek deger)
        //{
        //  Case koşul 1:  Yapılacak işler;  break;
        //  Case koşul 2:  Yapılacak işler;  break;
        //  Case koşul 3:  Yapılacak işler;  break;
        //   Default:  Yapılacak işler;  break;
        // }

        private void button3_Click(object sender, EventArgs e)
        {
 

            string secim = cmbOran.Text;

            switch (secim)
            {
                case "1":
                    txtKdvTutari.Text = (Convert.ToDouble(txtFiyat.Text) * 0.01).ToString(); 
                    break;

                case "8":
                    txtKdvTutari.Text = (Convert.ToDouble(txtFiyat.Text) * 0.08).ToString();
                    break;

                case "18":
                    txtKdvTutari.Text = (Convert.ToDouble(txtFiyat.Text) * 0.18).ToString();
                    break;

                default:
                    txtKdvTutari.Text = "Herhangi bir oran seçmediniz";
                    break;
            }


            double genel_toplam = Convert.ToDouble(txtKdvTutari.Text) + Convert.ToDouble(txtFiyat.Text);


            //Eğer genel toplam 100-200 arasında ise %10 indirim, 
            //200 - 500 arasında ise %20 indirim,
            //500 ve üstü ise %30 indirim uygulanacaktır
            switch (genel_toplam)
            {
                case double toplam when toplam < 100  :
                    txtIndirim.Text = "0";
                    break;
                case double toplam when toplam <200:
                    txtIndirim.Text=(genel_toplam*0.10).ToString();
                    break;
                case double toplam when  toplam < 500:
                    txtIndirim.Text = (genel_toplam * 0.20).ToString();
                    break;
              //default'a 500 den büyük olanlar kalır 
                default:
                    txtIndirim.Text = (genel_toplam * 0.30).ToString();
                    break;
            }
        }

        private void brbUret_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32( txti.Text);//3
            int j = Convert.ToInt32(txtj.Text);//3
            int k = Convert.ToInt32(txtk.Text);//3

            int tekrar_sayisi = 0;
            

            int sayac = 0;

            for (int x = 1; x <= i; x++)
            {
                for (int y = 1; y <= j; y++)
                {
                    int z = 1;
                    //koşul değişkenine değer atamalı
                    //while(koşul değişkeni ile karşılaştırma)
                    //{ 
                    // koşul değişkenini değiştirmelisiniz
                    //Yapılacak işler;
                     //}
                    while (z<=k)
                    {
                        z++;
                        sayac++;
                        lbxListe.Items.Add(sayac.ToString()+"-Merhaba");
                       
                    }

                }

            }

          
        }

        private void brnFor_Click(object sender, EventArgs e)
        {

            lbxListe.Items.Clear();
            int d = 1;
            int sayac = 0;
            for (d = 1; d < 10; d++)
            {
                sayac++;
                lbxListe.Items.Add(sayac.ToString() + "-for-Merhaba");
            }

           
        }

        private void brnWhile_Click(object sender, EventArgs e)
        {
            lbxListe.Items.Clear();

            int sayac = 0;

            int  d = 1;
            while (d < 10)
            {
                d++;

                sayac++;
                lbxListe.Items.Add(sayac.ToString() + "-while-Merhaba");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            lbxListe.Items.Clear();

            int sayac = 0;

            //koşul değişkenine değer atamalı
            //Do
            //{ 
            // koşul değişkenini değiştirmelisiniz
            //Yapılacak işler;
            //}while(koşul değişkeni ile karşılaştırma)

            int d = 1;
            do
            {
                d++;
                sayac++;
                lbxListe.Items.Add(sayac.ToString() + "-do-while-Merhaba");
            } while (d<10);
             
        }

       

        private void btnBreak_Click(object sender, EventArgs e)
        {
            lbxListe.Items.Clear();
            int d = 1;
            int sayac = 0;
            for (d = 1; d < 10; d++)
            {
                sayac++;

                if (sayac % 5 == 0)
                {
                    //break: bu komut döngüden çıkmayı sağlar
                    lbxListe.Items.Add(sayac.ToString() + "-break");
                    break;
                }

                lbxListe.Items.Add(sayac.ToString() + "-for-Merhaba");
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            lbxListe.Items.Clear();
            int d = 1;
            int sayac = 0;
            for (d = 1; d < 10; d++)
            {
                sayac++;

                if (sayac%2==0)
                {
                    //continue: bu komuttan sonraki komutlar çalıştırımadan döngü başına döner. Yani döngü sayacını for için 1 arttır.
                    lbxListe.Items.Add(sayac.ToString() + "-continue");
                    continue;
                }

                lbxListe.Items.Add(sayac.ToString() + "-for-Merhaba");
            }
        }

        private void btnTernary_Click(object sender, EventArgs e)
        {
            // -------------SINAVDA ÇIKABİLİR----------------
            //Tek satırda if yazımı
            // Şart ? koşul sağladığında : aksi halde.
            // koşul  ?   yapılacak tek iş: aksi halde yapılacak 
            //Ör: var degisken = (KOŞUL) ? "DOĞRU İSE BURASI" : "YANLIŞ İSE BURASI";


            lbxListe.Items.Clear();
            int d = 1;
            int sayac = 0;
            for (d = 1; d < 10; d++)
            {
                sayac++;


                string metin = sayac % 2 == 0 ? sayac.ToString() + "-ternary if" : sayac.ToString() + "-Merhaba";

                lbxListe.Items.Add(metin);

             
    
            }

        }
    }
}

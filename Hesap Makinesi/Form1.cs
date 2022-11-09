using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char islem_201104078;
        bool temizle_201104078;
        double sayi1_201104078;
        double sayi2_201104078;
        double sonuc_201104078 = 0;
        double ebob_201104078 = 0;
        double ekok_201104078 = 0;
        




        private void rakam_1_button_Click(object sender, EventArgs e)// Hocam 4 label ilede yaptım fakat tek label biraz daha zorladı.Tüm tuşlar çalışıyor hepsi  düzgün bir grup halinde çalışıyorlar
        {

            if(temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
                
            }
            sayi1_label.Text += "1";

   
            
        }

        private void rakam_2_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)// boolean yapısını kullanarak ekranı temizle işlemini tru ladım arıdan karar yapısını kullanarak label rakamı yazdırdım 
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;//// boolea yapısı false ladım çünkü diğer aşamadaki rakamı yazdırmam gerekiyordu her butona basıldığında trulayıp ardıdan false lıcak 
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
               
            }
            sayi1_label.Text += "2";

        }

        private void rakam_3_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "3";
        }

        private void rakam_4_button_Click(object sender, EventArgs e)
        {
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "4";
        }

        private void rakam_5_button_Click(object sender, EventArgs e)
        {
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "5";
        }

        private void rakam_6_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "6";
        }

        private void rakam_7_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "7";
        }

        private void rakam_8_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "8";
        }

        private void rakam_9_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "9";
        }

        private void rakam_0_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += "0";
        }

        private void virgul_button_Click(object sender, EventArgs e)
        {

            if (temizle_201104078 == true)
            {
                sayi1_label.Text = "";
                temizle_201104078 = false;
            }
            if (sayi1_label.Text == "0")
            {
                sayi1_label.Text = "";
            }
            sayi1_label.Text += ",";
        }

        private void sonuc_button_Click(object sender, EventArgs e)
        {
            sayi2_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("2.Sayı Giriniz");

            }

            switch (islem_201104078)// switch case yapısı ile işlemleri çektim ve bu işlemerde neler yapılcağını toplama şse toplanmasıı çıkarma ise çıkarma işlemini yapılcağını mod alıncaksa modunun alınmasını gerektiğini yazdım
            {
                case '+':
                    sonuc_201104078 = sayi1_201104078 + sayi2_201104078;
                break;
                case '-':
                    sonuc_201104078 = sayi1_201104078 - sayi2_201104078;
                    break;
                case '*':
                    sonuc_201104078 = sayi1_201104078 * sayi2_201104078;
                    break;
                case '/':
                    if (sayi1_201104078 == 0)
                    {
                        MessageBox.Show("Bölme İşleminde İlk Rakamı Sıfır Gİremessin !", "Uyarı Penceresi");

                    }
                    sonuc_201104078 = sayi1_201104078 / sayi2_201104078;
                    break;
                case 'p':
                    sonuc_201104078 = (Math.Pow(sayi1_201104078, sayi2_201104078));     // üst alma fonksiyonunu kullandım          
                        break;
                case 'k':
                    sonuc_201104078 = (Math.Sqrt(sayi1_201104078));// kare kök alma fonskiyonunu kullandım
                    break;
                case 'm':
                    sonuc_201104078 = sayi1_201104078 % sayi2_201104078;
                    break;
                case 'E':
                    for (int i = 1; i < sayi1_201104078; i++)
                    {
                        if (sayi1_201104078 % i == 0 && sayi2_201104078 % i == 0)
                        {
                            ebob_201104078 = i;
                        }
                    }
                    sonuc_201104078 = Convert.ToDouble(ebob_201104078);
                    break;
                case 'K':// sayi1 ve sayi2 değerini çarptıktan sonra ebob değerine böldükten sonra ekok değerini buldum 
                    for (int i = 1; i < sayi1_201104078; i++)
                    {
                        if (sayi1_201104078 % i == 0 && sayi2_201104078 % i == 0)
                        {
                            ebob_201104078 = i;
                        }
                    }
                    ekok_201104078 = (sayi1_201104078 * sayi2_201104078) / ebob_201104078;
                    sonuc_201104078 = ekok_201104078;
                    break;
            }
            sayi1_label.Text = sonuc_201104078.ToString();
            
        }

        private void toplam_button_Click(object sender, EventArgs e)//Toplam Butonuna char değişkenini tanımladıktan sonra labeldan sayi1 çektim 
        {
            islem_201104078 = '+';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text=="")
            {
                MessageBox.Show("Sayı Giriniz","Uyarı Penceresi !");

            }
        }

        private void carpma_button_Click(object sender, EventArgs e)// islem charına çarpma butonunda tanımladım ardından bool yapısı ile temizledikten sonra labeldan sayi çektim
        {
            islem_201104078 = '*';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }
        }

        private void cıkarma_button_Click(object sender, EventArgs e)//islem charına çıkarma butonunu tanımladım arkasından Boolean yapısını kullanarak temizledim ve labeldan sayi1 çektim
        {
            islem_201104078 = '-';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }
        }

        private void bolme_button_Click(object sender, EventArgs e)//islem charına bölme işlemini tanımladıktan sonra  boolean yapısı ile temizle işlemini true ladım sonra labeldan sayi1 çektim
        {
            islem_201104078 = '/';
            temizle_201104078 = true;            
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }
            
        }

        private void ust_alma_button_Click(object sender, EventArgs e)//islem charına üst alam işlemini tanımladıktan sonra Boolean yapısı ile label temzile işlemini true ladım ardından labeldan sayi1 çektim
        {
            islem_201104078 = 'p';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }

        }

        private void kareok_alma_Click(object sender, EventArgs e)// islem charına karekök işlemini tanımladım ardından boolean yapısı ile label temizle işlemini true ladım ve labeldan sayi1 çektim 
        {
            islem_201104078 = 'k';
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }
        }

        private void mod_alma_button_Click(object sender, EventArgs e)//islem charına mod alma işlemini tanımladım sonra boolean yapısını kullanarak label temzile işlemini true ladım ve labeldan sayi1 çektim 
        {
            islem_201104078 = 'm';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }

        }

        private void ebob_button_Click(object sender, EventArgs e)//islem charına ebob işlemini tanımlafım ve boolean yapısını kullanarak label temizle işlemini true ladım
        {
            islem_201104078 = 'E';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text); 
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }
        }

        private void ekok_button_Click(object sender, EventArgs e)// islem charına ekok işlemini tanımlafım ve boolean yapısını kullanarak label temizle işlemini true ladım
        {
            islem_201104078 = 'K';
            temizle_201104078 = true;
            sayi1_201104078 = Convert.ToDouble(sayi1_label.Text);
            if (sayi1_label.Text == "0" || sayi1_label.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");

            }
        }

        private void button1_Click(object sender, EventArgs e)// tıklandığı halde sayi labeli temizliyor
        {
            sayi1_label.Text = "0";
            
        }

        private void button2_Click(object sender, EventArgs e)// sayı1 ve sayi2 değişkenini tanımladığım bir string değerine atadım ardından tuşa tıklandığı halde içini boşaltıcak
        {
            sayi1_label.Text = "0";
            string f_201104078, s_201104078;
            s_201104078 = sayi2_201104078.ToString();
            f_201104078 = sayi1_201104078.ToString();
            s_201104078 = "";
            f_201104078 = "";
        }

        private void gecmis_button_Click(object sender, EventArgs e)// geçmiş butonuna tıklandığında listbox yapısını kullanarak sayi bir ve sayi ikinin girdiği işlemi yaptım 
        {
            if(islem_201104078=='m')
                listBox1.Items.Add(sayi1_201104078 + " " + "%" + " " + sayi2_201104078 + "=" + sonuc_201104078);
            else if(islem_201104078=='p')
                listBox1.Items.Add(sayi1_201104078 + " " + "Pow" + " "  +sayi2_201104078+ "=" + sonuc_201104078);
            else if(islem_201104078=='k')
                listBox1.Items.Add(sayi1_201104078 + " " + "Sqrt" + " " + "=" + sonuc_201104078);
            else if(islem_201104078=='E')
                listBox1.Items.Add(sayi1_201104078 + " " + "Ebob" + " " +sayi2_201104078+ "=" + sonuc_201104078);
            else if(islem_201104078=='K')
                listBox1.Items.Add(sayi1_201104078 + " " + "Ekok" + " " + sayi2_201104078 + "=" + sonuc_201104078);
            else if(islem_201104078=='+')
                listBox1.Items.Add(sayi1_201104078 + " "+  "+" +" "+ sayi2_201104078 + "="+ sonuc_201104078);
            else if(islem_201104078=='-')
                listBox1.Items.Add(sayi1_201104078 + " " + "-" + " " + sayi2_201104078 + "=" + sonuc_201104078);
            else if(islem_201104078=='/')
                listBox1.Items.Add(sayi1_201104078 + " " + "/" + " " + sayi2_201104078 + "=" + sonuc_201104078);
            else if(islem_201104078=='*')
                listBox1.Items.Add(sayi1_201104078 + " " + "*" + " " + sayi2_201104078 + "=" + sonuc_201104078);
        }

        private void button3_Click(object sender, EventArgs e)// tıklandığında kaçıncı rakamdan silme işleminin başlayacağını ardından kaç karakter sileceği belirle (fonksiyon)
        {
            if (sayi1_label.Text.Length>0)
            {
                sayi1_label.Text = sayi1_label.Text.Remove(sayi1_label.Text.Length - 1, 1);
            }
            if (sayi1_label.Text=="")
            {
                sayi1_label.Text = "0";
            }

        }

        private void ters_isaret_button_Click(object sender, EventArgs e)
        {
            if (sayi1_label.Text.Contains("-"))
            {
                sayi1_label.Text = sayi1_label.Text.Remove(0, 1);
            }
            else
            {
                sayi1_label.Text = "-" + sayi1_label.Text;
            }
        }
    }
}

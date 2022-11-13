using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomata
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        string[] harfler = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "c", "j", "k", "l", "m", "n", "o", "p", "s", "t", "u", "v", "y", "z" };
        int[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string virgul;
        static string alfabe;
        static string duzenlimetin;
        static int konum2;
        int kelimeSayisi = 0;
        string[] bolunmusMetin;
        string[] bolunmusMetin2;
        string dizi2 = " ";
        int sayac = 0;



        private void button1_Click(object sender, EventArgs e)
        {
            virgul = ",";
            alfabe = textBox1.Text;
            int konum = alfabe.IndexOf(virgul);

            if (konum == -1)
            {
                MessageBox.Show("Oluşturulan Alfabede , bulunmamaktadır.Lütfen her harften sonra kulanın.");

            }
            duzenlimetin = textBox2.Text;
            int acikParantezIndex = duzenlimetin.IndexOf("(");
            int kapaliParantezKonum = duzenlimetin.IndexOf(")");
            int yildizindex = duzenlimetin.IndexOf("*");
            int artiindex = duzenlimetin.IndexOf("+");
           
            char[] karakterAyirma = duzenlimetin.ToCharArray();
            char yildiz = '*';
            int sayac = 1;
            string dizi = "";
            string pdizi = "";
            string letter = "";
            string altsab = "";
            string Artisab = "";
            string yenisab = "";
            int a = 1;
            kelimeSayisi = Convert.ToInt32(textBox3.Text);
            
            
            //MessageBox.Show(Convert.ToString(acikParantezIndex));
            // MessageBox.Show(Convert.ToString(kapaliParantezKonum));

            for (int m = 0; m < kelimeSayisi; m++)
            {

                var random = new Random();
                int abcd = random.Next(0, kelimeSayisi);

                for (int i = 0; i < karakterAyirma.Length; i++)
                   
                {
                    
                    if (karakterAyirma[i] == yildiz)
                    {
                        
                        for (int j = 1; j < a; j++)
                        {
                            
                            if (karakterAyirma[i - 1] == ')')
                            {
                                continue;
                            }
                            
                            else
                            {
                                dizi = dizi + karakterAyirma[i - 1];
                            }

                        }


                    }

                    else if (karakterAyirma[i] == '(')

                    {

                        if (kapaliParantezKonum + 1 == yildizindex)
                        {
                            for (int j = 0; j <a; j++)
                            {
                                //dizi = dizi + karakterAyirma[i - 1];

                                pdizi = duzenlimetin.Substring((acikParantezIndex + 1), (kapaliParantezKonum - 2));
                                string[] pdizi2 = pdizi.Split('+');
                                Random rd = new Random();
                                int abc=rd.Next(0, 2);
                                dizi = dizi + pdizi2[abc];
                                i = kapaliParantezKonum + 1;
                                
                            }
                        }
                        else
                        {
                            // dizi = dizi + duzenlimetin.Substring((acikParantezIndex + 1), (kapaliParantezKonum - 2));
                            continue;

                        }



                        /*if (karakterAyirma[kapaliParantezKonum + 1] == yildiz)
                        {
                            int alinacakKarakterSayisi = (kapaliParantezKonum - (acikParantezIndex + 1));
                            MessageBox.Show("deger" + alinacakKarakterSayisi);
                            string kesilenDeger = duzenlimetin.Substring((acikParantezIndex + 1), alinacakKarakterSayisi);
                            dizi = dizi + kesilenDeger;
                            //   dizi = dizi + duzenlimetin.Substring((acikParantezIndex + 1), (kapaliParantezKonum - 2));
                            // dizi =dizi+karakterAyirma[acikParantezIndex + sayac];

                            if (karakterAyirma[acikParantezIndex + sayac] == ')')
                            {
                                break;
                            }
                            sayac++;
                            MessageBox.Show("giriyor işlem");
                        }
                        */

                    }
                    else if (karakterAyirma[i] == ')')
                    {
                        continue;
                    }
                    else if (karakterAyirma[i] == '+')
                    {
                        //dizi = dizi + karakterAyirma[i-1];

                        i = artiindex + i;
                        



                    }
                    else
                    {


                        if (karakterAyirma[i] == ')')
                        {
                            continue;
                        }
                        else if (karakterAyirma[i]=='+')
                        {
                            continue;
                        }
                        

                        else
                        {
    
                            dizi = dizi + karakterAyirma[i] ;
  
                        }

                    }


                }
                dizi = dizi + " ";

                a++;


            }

            
            for (int t = 0; t < dizi.Length; t++)
            {
                if (dizi[t] == ')')
                {
                    dizi2 = dizi.Replace(')', ' ');
                }
                
                else
                {
                    dizi2 = dizi;
                }
                

            }
            string[] value1 = dizi2.Split(' ');
            foreach (string item in value1)
            {
                listBox1.Items.Add(item);
            }
            
            string[] value2 = alfabe.Split(',');
            foreach (string item in value2)
            {
                listBox2.Items.Add(item);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

        }




        private void button3_Click(object sender, EventArgs e)
        {/*
            string[] veriler1 = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                veriler1[i] = listBox1.Items[i].ToString();
            }

            List<string> veriler2 = new List<string>();
            foreach (var item in listBox1.Items)
            {
                veriler2.Add(item.ToString());
            }

            var veriler3 = listBox1.Items.Cast<String>().ToArray();
            MessageBox.Show(veriler3[1]);
            */
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                //MessageBox.Show(listBox1.Items[i].ToString());
                if (listBox1.Items[i].ToString().Contains(textBox4.Text))
                {
                    listBox1.SetSelected(i, true);
                    sayac = sayac + 1;
                    break;


                }
                else
                {
                    continue;
                }
            }
            if (sayac >= 1)
            {
                MessageBox.Show("aradıgınız kelime bunmaktadır");
                
            }
            else
            {
                MessageBox.Show("bulunmamaktadır");
            }
            sayac = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSAPAROLA_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     


        int soruno; int dogru; int yanlis;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = "ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "yeşilliği ile ünlü marmara ili?";
                button2.BackColor = Color.Yellow;
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "müslümanların kutsal günü";
                button3.BackColor = Color.Yellow;
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "paşişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "medinede yetişen meyvenin adı?";
                button8.BackColor = Color.Yellow;
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "türkiyenin en kalabalık şehri?";
                button10.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                richTextBox1.Text = "askeri bir topluluk?";
                button11.BackColor = Color.Yellow;
            }

            if (soruno == 12)
            {
                richTextBox1.Text = "4 ayaklı evcil hayvan?";
                button12.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                richTextBox1.Text = "çorumun ünlü kuruyemiş?";
                button13.BackColor = Color.Yellow;
            }

            if (soruno == 14)
            {
                richTextBox1.Text = "çocuklara anlatılan fantastik edebi tür?";
                button14.BackColor = Color.Yellow;
            }

            if (soruno == 15)
            {
                richTextBox1.Text = "üflemeli bir çalgı?";
                button15.BackColor = Color.Yellow;
            }

            if (soruno == 16)
            {
                richTextBox1.Text = "halk şairi?";
                button16.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "haftnın 4.günü?";
                button18.BackColor = Color.Yellow;
            }

            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sulatı?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "haftanın ikinci günü?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "yumurta veren hayvan?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "organ kelimesinin eş anlamlısı?";
                button23.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                richTextBox1.Text = "kedisiyle ünlü doğudaki ilimiz?";
                button26.BackColor = Color.Yellow;
            }

            if (soruno == 23)
            {
                richTextBox1.Text = "acun ılıcanın eskiden sunduğu bir program?";
                button25.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                richTextBox1.Text = "sürekli akıp giden,geri alınması mümkün olmayan?";
                button27.BackColor = Color.Yellow;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


            if(e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if(textBox1.Text =="akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            yanlis++;
                            label4.Text=yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hurma")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {

                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "istanbul")
                        {

                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {

                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kedi")
                        {

                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "leblebi")
                        {

                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "masal")
                        {

                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {

                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {

                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "perşembe")
                        {

                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {

                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "salı")
                        {

                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tavuk")
                        {

                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "uzuv")
                        {

                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {

                            button26.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button26.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yeteneksizsiniz")
                        {

                            button25.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button25.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zaman")
                        {

                            button27.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button27.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    
                  


                }
            }


        }

    }
}

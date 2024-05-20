using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {     
        //değişkenler
        int[,] tahta = new int[8,8];
        int[,] tehtit = new int[8, 8];
        int v=0,sayaç1=0,l=0,d=0,y=0;
        bool sayaç = false;


        public Form1()
        {
            InitializeComponent();
            for(int a=0;a<8;a++)
            {
                for(int b=0;b<8;b++)
                {
                    tahta[a, b] = 0;
                }
            }
        } 
        private void dene()
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                for (int a = 0; a < 8; a++)
                {
                    for (int b = 0; b < 8; b++)
                    {
                        l = 0;
                        //yatay
                        for (int c = b - 1; c > -1; c--)
                        {
                            if (tahta[a, c] == 1) { l++; }
                        }
                        for (int c = b + 1; c < 8; c++)
                        {
                            if (tahta[a, c] == 1) { l++; }
                        }
                        //dikey 
                        for (int c = a - 1; c > -1; c--)
                        {
                            if (tahta[c, b] == 1) { l++; }
                        }
                        for (int c = a + 1; c < 8; c++)
                        {
                            if (tahta[c, b] == 1) { l++; }
                        }
                        //çapraz // sol üst -sağ alt
                        for (int c = a + 1, s = b + 1; c < 8 && s < 8; c++, s++)
                        {
                            if (tahta[c, s] == 1) { l++; }
                        }
                        for (int c = a - 1, s = b - 1; c > -1 && s > -1; c--, s--)
                        {
                            if (tahta[c, s] == 1) { l++; }
                        }

                        //çapraz // sağ üst -sol alt
                        for (int c = a + 1, s = b - 1; c < 8 && s > -1; c++, s--)
                        {
                            if (tahta[c, s] == 1) { l++; }
                        }
                        for (int c = a - 1, s = b + 1; c > -1 && s < 8; c--, s++)
                        {
                            if (tahta[c, s] == 1) { l++; }
                        }

                        tehtit[a, b] = l;
                        if (0 < l && radioButton2.Checked == true) { l = 1; }
                        sayaç1 = tahta[a, b];
                        kare(sayaç1, a, b, l);
                    }
                }

            }
            else
            {
                MessageBox.Show("LÜTFEN KOLAY - ZOR BİR MOD SEÇİN");
            }
            
        }
        private void kare(int q,int d,int f,int k)
        {
           switch(d)
           {
               case 0:
                   {
                       switch (f)
                       {
                           case 0:
                               {
                                   if(q==1)
                                   {
                                        if (k >= 1) 
                                        { 
                                            button1.BackColor = Color.Red;
                                            button1.Text =  "  VEZİR"+" TEHTİT : " + k.ToString();
                                            k = 0;
                                        }
                                        else
                                        {
                                            button1.BackColor = Color.Green; 
                                            button1.Text = "  VEZİR" + " TEHTİT YOK";
                                        } 
                                   }
                                   else
                                   {
                                       button1.BackColor = Color.White;
                                       button1.Text="";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button2.BackColor = Color.Red;
                                           button2.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button2.BackColor = Color.Green; 
                                           button2.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   { 
                                       button2.BackColor = Color.Black; 
                                       button2.Text = ""; 
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button3.BackColor = Color.Red;
                                           button3.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button3.BackColor = Color.Green; 
                                           button3.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button3.BackColor = Color.White; 
                                       button3.Text = ""; 
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button4.BackColor = Color.Red;
                                           button4.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button4.BackColor = Color.Green; 
                                           button4.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   { 
                                       button4.BackColor = Color.Black;
                                       button4.Text = ""; 
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button5.BackColor = Color.Red;
                                           button5.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button5.BackColor = Color.Green; 
                                           button5.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   { 
                                       button5.BackColor = Color.White; 
                                       button5.Text = ""; 
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button6.BackColor = Color.Red;
                                           button6.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button6.BackColor = Color.Green; 
                                           button6.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   { 
                                       button6.BackColor = Color.Black; 
                                       button6.Text = ""; 
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button7.BackColor = Color.Red;
                                           button7.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button7.BackColor = Color.Green; 
                                           button7.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   { 
                                       button7.BackColor = Color.White; 
                                       button7.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button8.BackColor = Color.Red;
                                           button8.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button8.BackColor = Color.Green; 
                                           button8.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button8.BackColor = Color.Black; 
                                       button8.Text = "";
                                   }
                                   break;
                               }
                       }
                       break; 
                   }
               case 1:
                   {
                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button9.BackColor = Color.Red;
                                           button9.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button9.BackColor = Color.Green;
                                           button9.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button9.BackColor = Color.Black;
                                       button9.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button10.BackColor = Color.Red;
                                           button10.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button10.BackColor = Color.Green;
                                           button10.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button10.BackColor = Color.White;
                                       button10.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button11.BackColor = Color.Red;
                                           button11.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button11.BackColor = Color.Green;
                                           button11.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button11.BackColor = Color.Black;
                                       button11.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button12.BackColor = Color.Red;
                                           button12.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button12.BackColor = Color.Green;
                                           button12.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button12.BackColor = Color.White;
                                       button12.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button13.BackColor = Color.Red;
                                           button13.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button13.BackColor = Color.Green;
                                           button13.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button13.BackColor = Color.Black;
                                       button13.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button14.BackColor = Color.Red;
                                           button14.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button14.BackColor = Color.Green;
                                           button14.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button14.BackColor = Color.White;
                                       button14.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button15.BackColor = Color.Red;
                                           button15.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button15.BackColor = Color.Green;
                                           button15.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button15.BackColor = Color.Black;
                                       button15.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button16.BackColor = Color.Red;
                                           button16.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button16.BackColor = Color.Green;
                                           button16.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button16.BackColor = Color.White;
                                       button16.Text = "";
                                   }
                                   break;
                               }
                       }
                       break;
                   }
               case 2:
                   {
                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button17.BackColor = Color.Red;
                                           button17.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button17.BackColor = Color.Green;
                                           button17.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button17.BackColor = Color.White;
                                       button17.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button18.BackColor = Color.Red;
                                           button18.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button18.BackColor = Color.Green;
                                           button18.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button18.BackColor = Color.Black;
                                       button18.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button19.BackColor = Color.Red;
                                           button19.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button19.BackColor = Color.Green;
                                           button19.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button19.BackColor = Color.White;
                                       button19.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button20.BackColor = Color.Red;
                                           button20.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button20.BackColor = Color.Green;
                                           button20.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button20.BackColor = Color.Black;
                                       button20.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button21.BackColor = Color.Red;
                                           button21.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button21.BackColor = Color.Green;
                                           button21.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button21.BackColor = Color.White;
                                       button21.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button22.BackColor = Color.Red;
                                           button22.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button22.BackColor = Color.Green;
                                           button22.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button22.BackColor = Color.Black;
                                       button22.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button23.BackColor = Color.Red;
                                           button23.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button23.BackColor = Color.Green;
                                           button23.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button23.BackColor = Color.White;
                                       button23.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button24.BackColor = Color.Red;
                                           button24.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button24.BackColor = Color.Green;
                                           button24.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button24.BackColor = Color.Black;
                                       button24.Text = "";
                                   }
                                   break;
                               }
                       }
                       break; 

                   }
               case 3:
                   {
                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button25.BackColor = Color.Red;
                                           button25.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button25.BackColor = Color.Green;
                                           button25.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button25.BackColor = Color.Black;
                                       button25.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button26.BackColor = Color.Red;
                                           button26.Text = "  VEZİR" + "  TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button26.BackColor = Color.Green;
                                           button26.Text = "  VEZİR" + "  TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button26.BackColor = Color.White;
                                       button26.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button27.BackColor = Color.Red;
                                           button27.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button27.BackColor = Color.Green;
                                           button27.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button27.BackColor = Color.Black;
                                       button27.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button28.BackColor = Color.Red;
                                           button28.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button28.BackColor = Color.Green;
                                           button28.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button28.BackColor = Color.White;
                                       button28.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button29.BackColor = Color.Red;
                                           button29.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button29.BackColor = Color.Green;
                                           button29.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button29.BackColor = Color.Black;
                                       button29.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button30.BackColor = Color.Red;
                                           button30.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button30.BackColor = Color.Green;
                                           button30.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button30.BackColor = Color.White;
                                       button30.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button31.BackColor = Color.Red;
                                           button31.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button31.BackColor = Color.Green;
                                           button31.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button31.BackColor = Color.Black;
                                       button31.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button32.BackColor = Color.Red;
                                           button32.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button32.BackColor = Color.Green;
                                           button32.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button32.BackColor = Color.White;
                                       button32.Text = "";
                                   }
                                   break;
                               }
                       }
                       break;
                   }
               case 4:
                   {

                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button33.BackColor = Color.Red;
                                           button33.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button33.BackColor = Color.Green;
                                           button33.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button33.BackColor = Color.White;
                                       button33.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button34.BackColor = Color.Red;
                                           button34.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button34.BackColor = Color.Green;
                                           button34.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button34.BackColor = Color.Black;
                                       button34.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button35.BackColor = Color.Red;
                                           button35.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button35.BackColor = Color.Green;
                                           button35.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button35.BackColor = Color.White;
                                       button35.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button36.BackColor = Color.Red;
                                           button36.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button36.BackColor = Color.Green;
                                           button36.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button36.BackColor = Color.Black;
                                       button36.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button37.BackColor = Color.Red;
                                           button37.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button37.BackColor = Color.Green;
                                           button37.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button37.BackColor = Color.White;
                                       button37.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button38.BackColor = Color.Red;
                                           button38.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button38.BackColor = Color.Green;
                                           button38.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button38.BackColor = Color.Black;
                                       button38.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button39.BackColor = Color.Red;
                                           button39.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button39.BackColor = Color.Green;
                                           button39.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button39.BackColor = Color.White;
                                       button39.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button40.BackColor = Color.Red;
                                           button40.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button40.BackColor = Color.Green;
                                           button40.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button40.BackColor = Color.Black;
                                       button40.Text = "";
                                   }
                                   break;
                               }
                       }
                       break; 
                   }
               case 5:
                   {
                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button41.BackColor = Color.Red;
                                           button41.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button41.BackColor = Color.Green;
                                           button41.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button41.BackColor = Color.Black;
                                       button41.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button42.BackColor = Color.Red;
                                           button42.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button42.BackColor = Color.Green;
                                           button42.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button42.BackColor = Color.White;
                                       button42.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button43.BackColor = Color.Red;
                                           button43.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button43.BackColor = Color.Green;
                                           button43.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button43.BackColor = Color.Black;
                                       button43.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button44.BackColor = Color.Red;
                                           button44.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button44.BackColor = Color.Green;
                                           button44.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button44.BackColor = Color.White;
                                       button44.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button45.BackColor = Color.Red;
                                           button45.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button45.BackColor = Color.Green;
                                           button45.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button45.BackColor = Color.Black;
                                       button45.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button46.BackColor = Color.Red;
                                           button46.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button46.BackColor = Color.Green;
                                           button46.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button46.BackColor = Color.White;
                                       button46.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button47.BackColor = Color.Red;
                                           button47.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button47.BackColor = Color.Green;
                                           button47.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button47.BackColor = Color.Black;
                                       button47.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button48.BackColor = Color.Red;
                                           button48.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button48.BackColor = Color.Green;
                                           button48.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button48.BackColor = Color.White;
                                       button48.Text = "";
                                   }
                                   break;
                               }
                       }
                       break;
                   }
               case 6:
                   {

                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button49.BackColor = Color.Red;
                                           button49.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button49.BackColor = Color.Green;
                                           button49.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button49.BackColor = Color.White;
                                       button49.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button50.BackColor = Color.Red;
                                           button50.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button50.BackColor = Color.Green;
                                           button50.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button50.BackColor = Color.Black;
                                       button50.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button51.BackColor = Color.Red;
                                           button51.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button51.BackColor = Color.Green;
                                           button51.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button51.BackColor = Color.White;
                                       button51.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button52.BackColor = Color.Red;
                                           button52.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button52.BackColor = Color.Green;
                                           button52.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button52.BackColor = Color.Black;
                                       button52.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button53.BackColor = Color.Red;
                                           button53.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button53.BackColor = Color.Green;
                                           button53.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button53.BackColor = Color.White;
                                       button53.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button54.BackColor = Color.Red;
                                           button54.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button54.BackColor = Color.Green;
                                           button54.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button54.BackColor = Color.Black;
                                       button54.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button55.BackColor = Color.Red;
                                           button55.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button55.BackColor = Color.Green;
                                           button55.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button55.BackColor = Color.White;
                                       button55.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button56.BackColor = Color.Red;
                                           button56.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button56.BackColor = Color.Green;
                                           button56.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button56.BackColor = Color.Black;
                                       button56.Text = "";
                                   }
                                   break;
                               }
                       }
                       break; 
                   }
               case 7:
                   {
                       switch (f)
                       {
                           case 0:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button57.BackColor = Color.Red;
                                           button57.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button57.BackColor = Color.Green;
                                           button57.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button57.BackColor = Color.Black;
                                       button57.Text = "";
                                   }
                                   break;
                               }

                           case 1:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button58.BackColor = Color.Red;
                                           button58.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button58.BackColor = Color.Green;
                                           button58.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button58.BackColor = Color.White;
                                       button58.Text = "";
                                   }
                                   break;
                               }
                           case 2:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button59.BackColor = Color.Red;
                                           button59.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button59.BackColor = Color.Green;
                                           button59.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button59.BackColor = Color.Black;
                                       button59.Text = "";
                                   }
                                   break;
                               }
                           case 3:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button60.BackColor = Color.Red;
                                           button60.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button60.BackColor = Color.Green;
                                           button60.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button60.BackColor = Color.White;
                                       button60.Text = "";
                                   }
                                   break;
                               }
                           case 4:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button61.BackColor = Color.Red;
                                           button61.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button61.BackColor = Color.Green;
                                           button61.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button61.BackColor = Color.Black;
                                       button61.Text = "";
                                   }
                                   break;
                               }
                           case 5:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button62.BackColor = Color.Red;
                                           button62.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button62.BackColor = Color.Green;
                                           button62.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button62.BackColor = Color.White;
                                       button62.Text = "";
                                   }
                                   break;
                               }
                           case 6:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button63.BackColor = Color.Red;
                                           button63.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button63.BackColor = Color.Green;
                                           button63.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button63.BackColor = Color.Black;
                                       button63.Text = "";
                                   }
                                   break;
                               }
                           case 7:
                               {
                                   if (q == 1)
                                   {
                                       if (k >= 1)
                                       {
                                           button64.BackColor = Color.Red;
                                           button64.Text = "  VEZİR" + "TEHTİT : " + k.ToString();
                                           k = 0;
                                       }
                                       else
                                       {
                                           button64.BackColor = Color.Green;
                                           button64.Text = "  VEZİR" + "TEHTİT YOK";
                                       }
                                   }
                                   else
                                   {
                                       button64.BackColor = Color.White;
                                       button64.Text = "";
                                   }
                                   break;
                               }
                       }
                       break;
                   }
           }
           l = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(sayaç==false)
            {
                tahta[0, 0] = 1;
                v++;
                sayaç = true;     
                dene();

            }
            else
            {
                tahta[0, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[0, 1] = 1;
                v++;
                sayaç = true; 
                dene();
            }
            else
            {
                tahta[0, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[0, 2] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[0, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[0, 3] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[0, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[0, 4] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[0, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[0, 5] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[0, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[0, 6] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[0, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[0, 7] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[0, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 0] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 1] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 2] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 3] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 4] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 5] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 6] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (sayaç == false)
            {
                tahta[1, 7] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[1, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 0] = 1;
                v++;
                sayaç = true; 
                dene();

            }
            else
            {
                tahta[2, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 1] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 2] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 3] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 4] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 5] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 6] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[2, 7] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[2, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 0] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 1] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 2] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 3] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 4] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 5] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 6] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[3, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[3, 7] = 1;
                v++;
                dene();
                sayaç = true;
            }
            else
            {
                tahta[3, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 0] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 1] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 2] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 3] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 4] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 5] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 6] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[4, 7] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[4, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 0] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 1] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 2] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 3] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 4] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 5] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 6] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[5, 7] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[5, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 0] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 1] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 2] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 3] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 4] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 5] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 6] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[6, 7] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[6, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 0] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 0] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 1] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 1] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 2] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 2] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 3] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 3] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 4] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 4] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 5] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 5] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 6] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 6] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (sayaç == false)
            {
                tahta[7, 7] = 1;
                v++;
                sayaç = true;
                dene();
            }
            else
            {
                tahta[7, 7] = 0;
                sayaç = false;
                v--;
                dene();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {
            button65.Text = "SIFIRLA";
            sayaç = false;
            sayaç1 = 0;
            l = 0;
            v = 0;
            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    tehtit[a, b] = 0;
                    tahta[a, b] = 0;
                }
            }
            dene();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

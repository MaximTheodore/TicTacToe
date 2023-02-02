using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace new_Window
{
    public partial class MainWindow : Window
    {
        static bool a=false;
        static bool q = true;
        static int b = 0;
        static int s=0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)//кнопки игры
        {
          
            if (a == true)
            {
                if (s == 0)T.Text = "Играет пользоватеть";
                else if (s == 1)T.Text = "Играет бот";
                switch (T.Text)
                {
                    case "Играет пользоватеть":
                        {
                            if (q==true)
                            {
                                ((Button)sender).Content = "X";
                                ((Button)sender).IsEnabled = false;
                            }
                            else
                            {
                                T.Text = "Играет бот";
                                Krestiki(1, 1);
                            }
                            s = 1;
                            break;
                        }
                    case "Играет бот":
                        {
                            if (q) { Krestiki(1, 0); }
                            else
                            {
                                T.Text = "Играет пользоватеть";
                                ((Button)sender).Content = "O";
                                ((Button)sender).IsEnabled = false;
                            }
                            s = 0;
                            break;
                        }
                }
            }
            winner(); 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (b ==0)
            {
                a = true;
                Txt.Text = "";
                T.Text = "";
                B1.Content = "";
                B2.Content = "";
                B3.Content = "";
                B4.Content = "";
                B5.Content = "";
                B6.Content = "";
                B7.Content = "";
                B8.Content = "";
                B9.Content = "";
                B1.IsEnabled = true;
                B2.IsEnabled = true;
                B3.IsEnabled = true;
                B4.IsEnabled = true;
                B5.IsEnabled = true;
                B6.IsEnabled = true;
                B7.IsEnabled = true;
                B8.IsEnabled = true;
                B9.IsEnabled = true;
                b = b + 1;
            }
            else if (b >0)
            {
                s = 0;
                q=false;
                a = false;
                Txt.Text = "";
                T.Text = "";
                B1.Content = " ";
                B2.Content = "";
                B3.Content = "";
                B4.Content = "";
                B5.Content = "";
                B6.Content = "";
                B7.Content = "";
                B8.Content = "";
                B9.Content = "";
                B1.IsEnabled = false;
                B2.IsEnabled = false;
                B3.IsEnabled = false;
                B4.IsEnabled = false;
                B5.IsEnabled = false;
                B6.IsEnabled = false;
                B7.IsEnabled = false;
                B8.IsEnabled = false;
                B9.IsEnabled = false;
                b -= 1;
            }
        }
        private void winner()
        {
            string pow = "";
            if (T.Text == "Играет пользоватеть"){  pow = "пользователь"; }
            else if (T.Text == "Играет бот") { pow = "бот"; }
            if (B1.Content == B2.Content && B2.Content == B3.Content && (string)B1.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B1.Content == B5.Content && B5.Content == B9.Content && (string)B1.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B3.Content == B5.Content && B5.Content == B7.Content && (string)B3.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B4.Content == B5.Content && B5.Content == B6.Content && (string)B4.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B7.Content == B8.Content && B8.Content == B9.Content && (string)B7.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B1.Content == B4.Content && B4.Content == B7.Content && (string)B1.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B2.Content == B5.Content && B5.Content == B8.Content && (string)B2.Content != "") { Txt.Text = "Победил\n " + pow; }
            else if (B3.Content == B6.Content && B6.Content == B9.Content && (string)B3.Content != "") { Txt.Text = "Победил\n " + pow; }
            else { Txt.Text = "Ничья"; }
        }
      
       
        private void Krestiki(int o, int u)
        {
            string simbol="";
            string sim="";
            Random random = new Random();
            if (o==1) {
                if (u == 0)
                {
                    simbol = "X";
                    sim = "O";
                }
                else if (u == 1) { simbol = "O"; sim = "X"; }

                if ((string)B1.Content== simbol )
                {
                    int r = random.Next(1, 9);
                    if (r==1) B2.Content = sim;
                    if(r==2) B3.Content = sim;
                    if(r==3) B4.Content = sim;
                    if(r==4) B5.Content = sim;
                    if(r==5) B6.Content = sim;
                    if(r==6) B7.Content = sim;
                    if(r==7) B8.Content = sim;
                    if(r==8) B9.Content = sim;

                }
                //доп случаи
                if ((string)B1.Content == simbol && (string)B3.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B5.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if(r==7) B8.Content = sim;

                }
                if ((string)B1.Content == "" && (string)B2.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 10);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B4.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B7.Content = sim;
                    if (r == 8) B8.Content = sim;
                    if (r == 9) B9.Content = sim;

                }
                if ((string)B1.Content == simbol && (string)B3.Content == simbol && (string)B8.Content == simbol )
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B5.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                   

                }

                if ((string)B1.Content == simbol && (string)B5.Content == simbol && (string)B6.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B3.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B9.Content = sim;
                    if (r == 6) B7.Content = sim;


                }
                if ((string)B7.Content == simbol && (string)B5.Content == simbol && (string)B6.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B3.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B9.Content = sim;
                    if (r == 6) B1.Content = sim;

                }
                if ((string)B3.Content == simbol && (string)B5.Content == simbol && (string)B4.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B6.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B9.Content = sim;
                    if (r == 6) B7.Content = sim;
                }
                if ((string)B9.Content == simbol && (string)B5.Content == simbol && (string)B4.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B6.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B3.Content = sim;
                    if (r == 6) B7.Content = sim;
                }
                if ((string)B2.Content == simbol && (string)B7.Content == simbol && (string)B9.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B5.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B3.Content = sim;


                }
                if ((string)B1.Content == simbol && (string)B2.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B7.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B3.Content = sim;


                }
                if ((string)B6.Content == simbol && (string)B2.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B7.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B1.Content = sim;
                    if (r == 6) B3.Content = sim;


                }
                if ((string)B1.Content == simbol && (string)B4.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B7.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B2.Content = sim;
                    if (r == 7) B3.Content = sim;


                }
                if ((string)B7.Content == simbol && (string)B4.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B2.Content = sim;
                    if (r == 7) B3.Content = sim;


                }
                if ((string)B5.Content == simbol && (string)B4.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B7.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B2.Content = sim;
                    if (r == 7) B3.Content = sim;
                }
                if ((string)B6.Content == simbol && (string)B3.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B7.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B2.Content = sim;
                    if (r == 7) B4.Content = sim;
                }
                if ((string)B6.Content == simbol && (string)B9.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B3.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B7.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B2.Content = sim;
                    if (r == 7) B4.Content = sim;
                }
                if ((string)B5.Content == simbol && (string)B2.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B3.Content = sim;
                    if (r == 2) B1.Content = sim;
                    if (r == 3) B7.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B4.Content = sim;
                }
                if ((string)B7.Content == simbol && (string)B4.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B9.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B1.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B3.Content = sim;


                }
                if ((string)B9.Content == simbol && (string)B6.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B1.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B3.Content = sim;


                }
                if ((string)B1.Content == simbol && (string)B4.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B9.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B3.Content = sim;


                }
                if ((string)B3.Content == simbol && (string)B6.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B1.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B9.Content = sim;


                }
                if ((string)B1.Content == simbol && (string)B5.Content == simbol )
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B9.Content = sim;


                }
                if ((string)B3.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B1.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B9.Content = sim;


                }
                if ((string)B7.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B9.Content = sim;


                }
                if ((string)B9.Content == simbol && (string)B5.Content == simbol)
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B1.Content = sim;


                }
                if ((string)B1.Content == simbol && (string)B5.Content == simbol && (string)B7.Content == simbol)
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B7.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B8.Content = sim;
                    if (r == 5) B4.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B9.Content = sim;


                }
                if ((string)B1.Content == simbol )
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B4.Content = sim;
                    if (r == 3) B5.Content = sim;
                    if (r == 4) B6.Content = sim;
                    if (r == 5) B7.Content = sim;
                    if (r == 6) B8.Content = sim;
                    if (r == 7) B9.Content = sim;
                  
                }
                if ((string)B7.Content == simbol )
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B4.Content = sim;
                    if (r == 3) B5.Content = sim;
                    if (r == 4) B6.Content = sim;
                    if (r == 5) B1.Content = sim;
                    if (r == 6) B8.Content = sim;
                    if (r == 7) B3.Content = sim;

                }
                if ((string)B1.Content == simbol && (string)B7.Content == simbol && (string)B2.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B3.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B4.Content = sim;
                    if (r == 3) B5.Content = sim;
                    if (r == 4) B6.Content = sim;
                    if (r == 5) B3.Content = sim;
                    if (r == 6) B8.Content = sim;
                    if (r == 7) B9.Content = sim;

                }
                if ((string)B3.Content == simbol && (string)B9.Content == simbol && (string)B2.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B1.Content == "")
                {
                    int r = random.Next(1, 8);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B4.Content = sim;
                    if (r == 3) B5.Content = sim;
                    if (r == 4) B6.Content = sim;
                    if (r == 5) B7.Content = sim;
                    if (r == 6) B8.Content = sim;
                    if (r == 7) B1.Content = sim;

                }
                if ((string)B3.Content == simbol && (string)B9.Content == simbol && (string)B1.Content==simbol && (string)B2.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" )
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B4.Content = sim;
                    if (r == 3) B5.Content = sim;
                    if (r == 4) B6.Content = sim;
                    if (r == 5) B7.Content = sim;
                    if (r == 6) B8.Content = sim;
                    

                }
                if ((string)B7.Content == simbol && (string)B9.Content == simbol && (string)B1.Content == simbol && (string)B2.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B3.Content == "" && (string)B8.Content == "")
                {
                    int r = random.Next(1, 7);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B4.Content = sim;
                    if (r == 3) B5.Content = sim;
                    if (r == 4) B6.Content = sim;
                    if (r == 5) B3.Content = sim;
                    if (r == 6) B8.Content = sim;
                    

                }
                if ((string)B2.Content == simbol && (string)B1.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B3.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B5.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B3.Content == simbol && (string)B2.Content == "" && (string)B1.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B5.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B4.Content == simbol && (string)B2.Content == "" && (string)B3.Content == "" && (string)B1.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B5.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B5.Content == simbol && (string)B2.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B1.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B4.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B6.Content == simbol && (string)B2.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B1.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B4.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B7.Content == simbol && (string)B2.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B1.Content == "" && (string)B8.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B4.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B8.Content == simbol && (string)B2.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B1.Content == "" && (string)B9.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B2.Content = sim;
                    if (r == 2) B3.Content = sim;
                    if (r == 3) B4.Content = sim;
                    if (r == 4) B5.Content = sim;
                    if (r == 5) B6.Content = sim;
                    if (r == 6) B7.Content = sim;
                    if (r == 7) B8.Content = sim;
                    if (r == 8) B9.Content = sim;
                }
                if ((string)B9.Content == simbol && (string)B2.Content == "" && (string)B3.Content == "" && (string)B4.Content == "" && (string)B5.Content == "" && (string)B6.Content == "" && (string)B7.Content == "" && (string)B8.Content == "" && (string)B1.Content == "")
                {
                    int r = random.Next(1, 9);
                    if (r == 1) B1.Content = sim;
                    if (r == 2) B2.Content = sim;
                    if (r == 3) B3.Content = sim;
                    if (r == 4) B4.Content = sim;
                    if (r == 5) B5.Content = sim;
                    if (r == 6) B6.Content = sim;
                    if (r == 7) B7.Content = sim;
                    if (r == 8) B8.Content = sim;
                }
                if ((string)B1.Content == simbol && (string)B2.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B3.Content = sim;
                    if (re == 2) B4.Content = sim;
                    if (re == 3) B5.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B2.Content == simbol && (string)B3.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B4.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B6.Content = sim;
                    if (re == 4) B7.Content = sim;
                    if (re == 5) B8.Content = sim;
                    if (re == 6) B9.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B3.Content == simbol && (string)B4.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B5.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B4.Content == simbol && (string)B5.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B3.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B5.Content == simbol && (string)B6.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B3.Content = sim;
                    if (re == 4) B4.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B6.Content == simbol && (string)B7.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B3.Content = sim;
                    if (re == 4) B4.Content = sim;
                    if (re == 5) B5.Content = sim;
                    if (re == 6) B8.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B7.Content == simbol && (string)B8.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B3.Content = sim;
                    if (re == 4) B4.Content = sim;
                    if (re == 5) B5.Content = sim;
                    if (re == 6) B6.Content = sim;
                    if (re == 7) B9.Content = sim;
                }
                if ((string)B8.Content == simbol && (string)B9.Content == simbol)
                {
                    int re = random.Next(1, 8);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B3.Content = sim;
                    if (re == 4) B4.Content = sim;
                    if (re == 5) B5.Content = sim;
                    if (re == 6) B6.Content = sim;
                    if (re == 7) B7.Content = sim;
                }
                if (((string)B1.Content == simbol && (string)B4.Content == simbol && (string)B7.Content == simbol) || ((string)B3.Content == simbol && (string)B6.Content == simbol && (string)B9.Content == simbol))
                {
                    int re = random.Next(1, 4);
                    if (re == 1) B2.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B8.Content = sim;
                }
                if ((string)B1.Content == simbol && (string)B5.Content == simbol && (string)B3.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B2.Content = sim;
                    if (re == 2) B4.Content = sim;
                    if (re == 3) B6.Content = sim;
                    if (re == 4) B7.Content = sim;
                    if (re == 5) B8.Content = sim;
                    if (re == 6) B9.Content = sim;
                }
                if ((string)B7.Content == simbol && (string)B5.Content == simbol && (string)B9.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B3.Content = sim;
                    if (re == 4) B4.Content = sim;
                    if (re == 5) B6.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B1.Content == simbol && (string)B5.Content == simbol && (string)B7.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B2.Content = sim;
                    if (re == 2) B3.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B8.Content = sim;
                    if (re == 6) B9.Content = sim;
                }
                if ((string)B3.Content == simbol && (string)B5.Content == simbol && (string)B9.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B3.Content == simbol && (string)B5.Content == simbol && (string)B1.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B9.Content = sim;
                    if (re == 2) B2.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B1.Content == simbol && (string)B2.Content == simbol && (string)B9.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B3.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B1.Content == simbol && (string)B2.Content == simbol && (string)B7.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B3.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B9.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B3.Content == simbol && (string)B2.Content == simbol && (string)B9.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B1.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B3.Content == simbol && (string)B2.Content == simbol && (string)B7.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B3.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B4.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B9.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
                if ((string)B1.Content == simbol && (string)B4.Content == simbol && (string)B9.Content == simbol)
                {
                    int re = random.Next(1, 7);
                    if (re == 1) B3.Content = sim;
                    if (re == 2) B5.Content = sim;
                    if (re == 3) B2.Content = sim;
                    if (re == 4) B6.Content = sim;
                    if (re == 5) B7.Content = sim;
                    if (re == 6) B8.Content = sim;
                }
            }
        }
       
    }
}

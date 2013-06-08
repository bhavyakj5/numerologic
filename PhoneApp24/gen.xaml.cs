using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApp24
{
    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        int lucky_gen, unlucky_gen;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                //{
                    int b = Convert.ToInt16(textBox1.Text);
                    int c = Convert.ToInt16(textBox2.Text);
                    int d = Convert.ToInt16(textBox3.Text);

                    if (b > 0 && b <= 31 && c > 0 && c <= 12 && d > 1925 && d <= 2012)
                    {
                        if (b > 9) { b = b % 10; }
                        if (b == 0) { b++; }
                        String a = (b.ToString() + "/" + textBox2.Text + "/" + textBox3.Text);
                        DateTime dob = Convert.ToDateTime(a);
                        int date = dob.Day;
                        int month = dob.Month;
                        int year = dob.Year;
                        int day = (int)dob.DayOfWeek;
                        int numerology = date + day;
                        if (numerology > month)
                        {
                            lucky_gen = month;
                            unlucky_gen = numerology;
                        }
                        else
                        {
                            lucky_gen = numerology;
                            unlucky_gen = month;
                        }

                        textBlock3.Text = ("Your lucky number is " + lucky_gen + "!" + "\nAvoid " + unlucky_gen + "!");
                    }

                   else
                    {
                        MessageBox.Show("Invaid date!");
                    }
                //}
                //else
                //{
                  //  MessageBox.Show("DD/MM/YYYY cannot be empty!");
                //}
            }
            catch (Exception) { MessageBox.Show("Invalid details!"); }
        }
        

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/today.xaml", UriKind.Relative));
        }
    }
}
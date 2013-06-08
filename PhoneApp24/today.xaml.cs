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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            int lucky_today, unlucky_today;
            int date = DateTime.Now.Day;
            int day = (int)DateTime.Now.DayOfWeek;
            int month = DateTime.Now.Month;
            //int time = Convert.ToUInt16(DateTime.Now.TimeOfDay.Minutes);

            if (date > 9) { date = date - 10; }
            int numerology = date + day;
            

            if (numerology > month)
            {
                lucky_today = month;
                unlucky_today = numerology;
            }
            else
            {
                lucky_today = numerology;
                unlucky_today = month;
            }

            textBlock1.Text = ("Your today's lucky number is " + lucky_today + "!" + "\nAvoid " + unlucky_today + " today!");

        }

       
        private void hyperlinkButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gen.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

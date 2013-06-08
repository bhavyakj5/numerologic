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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        

       
        private void hyperlinkButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/today.xaml", UriKind.Relative));
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/gen.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose an option above.\n'today's' tells your lucky & unlucky number of the day\n'general' tells your lucky number as per your birth date.");
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("numeroLogiC is not a random number generating app, it computes the numbers with a pure logic behind dates, month, years & time.");
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard1.Begin();
        } 
    }
}
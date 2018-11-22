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
using System.Windows.Shapes;


namespace Project_
{
    /// <summary>
    /// Logika interakcji dla klasy Logon.xaml
    /// </summary>
    public partial class Logon : Window
    {

        public Logon()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void main_Initialized(object sender, EventArgs e)
        {
            main.Content = new SignIn(this);
        }

        private void Rectangle_LayoutUpdated(object sender, EventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
        }
    }
}


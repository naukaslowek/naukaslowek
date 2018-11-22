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
using System.Data.SqlClient;
using System.Data;
using Project_;
using Project_.Strony;
namespace Project_
{
    /// <summary>
    /// Logika interakcji dla klasy Main.xaml
    /// </summary>
    public partial class Main : Window
    {

        public Main()
        {
            InitializeComponent();
          //  fillcombo4();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-SJKBFE5; Initial Catalog=DataBase; Integrated Security=True;");


        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (new Logon()).Show();

            this.Close();
        }

        private void ItemHome_Selected(object sender, RoutedEventArgs e)
        {
            main.Content = new Home_Screen();
        }

        private void ItemCreate_Selected(object sender, RoutedEventArgs e)
        {
            main.Content = new nauka();
        }






        /* void fillcombo4()
         { 
             sqlCon.Open();

             String SQL = "SELECT UserName FROM Employe";
             SqlDataAdapter Adpt = new SqlDataAdapter(SQL, sqlCon);
             DataSet login = new DataSet();
             Adpt.Fill(login);

                 txt_bl.Text += login.Tables[0].Rows[1]["USerName"].ToString();
              */
        public string _textBox
        {
            set {
                txt_bl.Text = value; }


        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            main.Content = new User_Page();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
      
            main.Content = new User_Settings();
        }
    } 



    }
      

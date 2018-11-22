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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Project_.DatabaseDataSet databaseDataSet = ((Project_.DatabaseDataSet)(this.FindResource("databaseDataSet")));
            // Załaduj dane do tabeli User. Możesz modyfikować ten kod w razie potrzeby.
            Project_.DatabaseDataSetTableAdapters.UserTableAdapter databaseDataSetUserTableAdapter = new Project_.DatabaseDataSetTableAdapters.UserTableAdapter();
            databaseDataSetUserTableAdapter.Fill(databaseDataSet.User);
            System.Windows.Data.CollectionViewSource userViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("userViewSource")));
            userViewSource.View.MoveCurrentToFirst();
        }
    }
}

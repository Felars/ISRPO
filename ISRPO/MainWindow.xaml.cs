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

namespace ISRPO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBEntities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new DBEntities();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new DBEntities();
            dgogrenci3.ItemsSource = db.Cash.ToList();
        }

        private void ADD1(object sender, RoutedEventArgs e)
        {
            I Insert = new I();
            Insert.Insert(Namee.Text, Price.Text, Quantity.Text, Sum.Text);
            dgogrenci3.ItemsSource = db.Cash.ToList();
            Namee.Clear();
            Price.Clear();
            Quantity.Clear();
            Sum.Clear();
        }
    }
}

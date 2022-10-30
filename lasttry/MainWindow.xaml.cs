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

namespace lasttry
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new LoginPage());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {


            if (MainFrame.CanGoBack)
            {
                Button_Login.Visibility = Visibility.Hidden;
                BtnBack.Visibility = Visibility.Visible;
                Materials.Visibility = Visibility.Visible;
                Supplier.Visibility = Visibility.Visible;
                //Button_Proizvodstvo.Visibility = Visibility.Hidden;

            }
            else
            {
                Button_Login.Visibility = Visibility.Visible;
                BtnBack.Visibility = Visibility.Hidden;
                Materials.Visibility = Visibility.Hidden;
                Supplier.Visibility = Visibility.Hidden;
                //Button_Proizvodstvo.Visibility = Visibility.Visible;
            }









        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            //LoginPage.TypeID = 0;
            Manager.MainFrame.Navigate(new SupplierPage(false));
            MessageBox.Show("Вы вошли анонимно!");
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MaterialPage());
        }

        private void Supplier_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SupplierPage(admin.isadmin));
        }

       
    }
}

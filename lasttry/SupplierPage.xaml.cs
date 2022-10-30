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
    /// Логика взаимодействия для SupplierPage.xaml
    /// </summary>
    public partial class SupplierPage : Page
    {
        public SupplierPage(bool isadmin)
        {
           
            InitializeComponent();
            if (admin.isadmin == false)
            {
                buttonDelete.Visibility = Visibility.Hidden;
                buttonAdd.Visibility = Visibility.Hidden;
                




            }
            else if (admin.isadmin == true)
            {
                buttonDelete.Visibility = Visibility.Visible;
                buttonAdd.Visibility = Visibility.Visible;
            }




            dataGridSupplier.ItemsSource = pachkaEntities.GetContext().Поставщик.ToList();

        }





        private void dataGridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {

            

            Manager.MainFrame.Navigate(new SupplierAddEditPage((sender as Button).DataContext as Поставщик));
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SupplierAddEditPage((sender as Button).DataContext as Поставщик));
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var SupplierForRemoving = dataGridSupplier.SelectedItems.Cast<Поставщик>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {SupplierForRemoving.Count()} элементов?", "Внимание",
               MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    pachkaEntities.GetContext().Поставщик.RemoveRange(SupplierForRemoving);
                    pachkaEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dataGridSupplier.ItemsSource = pachkaEntities.GetContext().Поставщик.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

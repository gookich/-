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
    /// Логика взаимодействия для SupplierAddEditPage.xaml
    /// </summary>
    public partial class SupplierAddEditPage : Page
    {
        private Поставщик _currentTab = new Поставщик();
        public SupplierAddEditPage(Поставщик currentTab)
        {
            InitializeComponent();
            if (currentTab != null)
                _currentTab = currentTab;
            DataContext = _currentTab;
            //ComboType.ItemsSource = pachkaEntities.GetContext().ТипОрганизации.ToString();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();


            if (string.IsNullOrWhiteSpace(_currentTab.Наименование))
                errors.AppendLine("Укажите название поставщика");
            if (_currentTab.Тип == null)
                errors.AppendLine("Выберите тип организации");
            if (string.IsNullOrWhiteSpace(_currentTab.ИНН))
                errors.AppendLine("Укажите ИНН организации");
            if (_currentTab.Рейтинг_качества < 1 || _currentTab.Рейтинг_качества > 100)
                errors.AppendLine("Рейтинг - число от 1 до 100");
            if (_currentTab.Дата_начала_работы == null)
                errors.AppendLine("Введите дату");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentTab.ID == 0)
                pachkaEntities.GetContext().Поставщик.Add(_currentTab);
            try
            {
                pachkaEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

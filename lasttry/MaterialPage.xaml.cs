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
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        public MaterialPage()
        {
            InitializeComponent();
            var currentTours = pachkaEntities.GetContext().Материал.ToList();
            ListViewMaterial.ItemsSource = currentTours.OrderBy(p => p.Наименование).ToList();
            
        }

        private void TextBoxSearch_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void TextBoxSearch_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }
    }
}

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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        pachkaEntities db = new pachkaEntities();
        private authoriz _users = new authoriz();
        authoriz authuser = null;
        authoriz adminunser = null;
        private string TypeUser;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TextBox_Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            var authuser = db.authorizs.FirstOrDefault(x => x.login == TextBox_Login.Text && x.password == PasswordBoxx.Password);
            var adminuser = db.authorizs.FirstOrDefault(x => x.login == TextBox_Login.Text && x.type_user == "Admin");
            var masterproiz = db.authorizs.FirstOrDefault(x => x.login == TextBox_Login.Text && x.type_user == "MASTER");




            if (masterproiz != null)
            {
                Manager.MainFrame.Navigate(new MasterSmeni());
                
            }




            if (authuser != null)

            {

               


                if (adminuser != null)
                {
                  
                    admin.isadmin = true;
                    Manager.MainFrame.Navigate(new SupplierPage(true));
                }


              else  if (masterproiz != null)
                {


                    Manager.MainFrame.Navigate(new MasterSmeni());
                }
                else

                {
                    MessageBox.Show("Вы вошли как рофлорыба");
                    Manager.MainFrame.Navigate(new MaterialPage());
                    admin.isadmin = false;
                }
            }
            else
            {
                MessageBox.Show("Ошибка!!!\nВведите данные");
            }
        }
    }
}

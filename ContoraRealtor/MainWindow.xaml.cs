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

namespace ContoraRealtor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aut_Click(object sender, RoutedEventArgs e) //авторизация
        {
            try
            {

                RealtorEntities db = new RealtorEntities();
                var rol = db.Manager.Where(us => us.Login == login.Text && us.Password == password.Text).FirstOrDefault().rol;
                if (rol == "Manager")
                {
                    Realtors realtor = new Realtors();
                    this.Hide();
                    realtor.Show();
                }
                else
                {
                    MessageBox.Show("Логин или пароль неверны");
                }
            }
            catch
            {
                MessageBox.Show("Данный логин уже существует");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e) //переход на форму менеджера
        {
            RealtorList rel = new RealtorList();
            this.Hide();
            rel.Show();
        }

        private void reg_Click(object sender, RoutedEventArgs e) //кнопка выхода
        {
            this.Close();
        }
    }
}

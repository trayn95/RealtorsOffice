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

namespace ContoraRealtor
{
    /// <summary>
    /// Логика взаимодействия для RegistrManager.xaml
    /// </summary>
    public partial class RegistrManager : Window
    {
        public RegistrManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //создание меденжера
        {
            try
            {
                if (Password.Text != "" && Login.Text != "")
                {
                    RealtorEntities db = new RealtorEntities();
                    Manager save = new Manager
                    {
                        Login = Login.Text,
                        Password = Password.Text,
                        rol = "Manager",
                    };
                    db.Manager.Add(save);
                    db.SaveChanges();
                    if (MessageBox.Show("Перейти на форму списка менеджеров?", "Данные успешно сохранены", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                    }
                    else
                    {
                        ManagerList re = new ManagerList();
                        this.Hide();
                        re.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Вы не ввели логин или пароль");
                }
            }
            catch
            {
                MessageBox.Show("Данный логин уже занят");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //форма списка менеджеров
        {
            ManagerList re = new ManagerList();
            this.Hide();
            re.Show();
        }

    }
}

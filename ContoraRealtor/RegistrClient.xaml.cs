using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RegistrClient.xaml
    /// </summary>
    public partial class RegistrClient : Window
    {
        public RegistrClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //форма списка клиентов
        {
            ClientList re = new ClientList();
            this.Hide();
            re.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //создание нового клиента
        {
            try
            {
                if (Email.Text != "" || phone.Text != "")
                {
                    RealtorEntities db = new RealtorEntities();
                    Client save = new Client
                    {
                        LastName = ClientLastName.Text,
                        Name = ClientName.Text,
                        MiddleName = ClientMiddleName.Text,
                        Phone = phone.Text,
                        Email = Email.Text,
                    };
                    db.Client.Add(save);
                    db.SaveChanges();
                    if (MessageBox.Show("Перейти на форму списка клиентов?", "Данные успешно сохранены", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                    }
                    else
                    {
                        ClientList re = new ClientList();
                        this.Hide();
                        re.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Вы должны заполнить Номер телефона или Эл.почту");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

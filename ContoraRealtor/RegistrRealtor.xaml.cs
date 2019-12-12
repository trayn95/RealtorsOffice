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
    /// Логика взаимодействия для RegistrRealtor.xaml
    /// </summary>
    public partial class RegistrRealtor : Window
    {
        public RegistrRealtor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //создание нового риелтора
        {
            try
            {
                if (RealtorName.Text != "" && RealtorLastName.Text != "" && RealtorMiddleName.Text != "")
                {
                    RealtorEntities db = new RealtorEntities();
                    Realtor save = new Realtor
                    {
                        LastName = RealtorLastName.Text,
                        Name = RealtorName.Text,
                        MiddleName = RealtorMiddleName.Text,
                        Comission = RealtorCommis.Text,
                    };
                    db.Realtor.Add(save);
                    db.SaveChanges();
                    if (MessageBox.Show("Перейти на форму списка риелторов?", "Данные успешно сохранены", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                    }
                    else
                    {
                        RealtorList re = new RealtorList();
                        this.Hide();
                        re.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Вы заполнили не все обязательные поля");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //форма списка риелтора
        {
            RealtorList reg = new RealtorList();
            this.Hide();
            reg.Show();
        }
    }
}

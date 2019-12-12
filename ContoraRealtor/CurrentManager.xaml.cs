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
    /// Логика взаимодействия для CurrentManager.xaml
    /// </summary>
    public partial class CurrentManager : Window
    {
        public CurrentManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManagerList re = new ManagerList();
            this.Hide();
            re.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //обновление
        {
            if (Password.Text != "" && Login.Text != "")
            {

                RealtorEntities db = new RealtorEntities();
                Manager manager = db.Manager.Find(SecurityContext.idManager);

                manager.Login = Login.Text;
                manager.Password = Password.Text;
                if (MessageBox.Show("Вы уверены что хотите обновить данного менеджера?", "Обнволение", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
                else
                {
                    db.Manager.Create();
                    db.SaveChanges();
                    ManagerList re = new ManagerList();
                    this.Hide();
                    re.Show();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            RealtorEntities db = new RealtorEntities();
            var manager = db.Manager.Find(SecurityContext.idManager);
            Login.Text = manager.Login;
            Password.Text = manager.Password;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //удаление
        {
            RealtorEntities db = new RealtorEntities();
            Manager manager = db.Manager.Find(SecurityContext.idManager);
            if (MessageBox.Show("Вы уверены что хотите удалить данного менеджера?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                db.Manager.Remove(db.Manager.Where(dr => dr.IdManager == SecurityContext.idManager).FirstOrDefault());
                db.SaveChanges();
                ManagerList re = new ManagerList();
                this.Hide();
                re.Show();
            }
            
        }
    }
}

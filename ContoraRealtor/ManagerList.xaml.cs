using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для ManagerList.xaml
    /// </summary>
    public partial class ManagerList : Window
    {
        public ManagerList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // форма менеджера
        {
            Realtors re = new Realtors();
            this.Hide();
            re.Show();
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e) //форма нового менеджера
        {
            RegistrManager re = new RegistrManager();
            this.Hide();
            re.Show();
        }
        DataTable dtManager = GetRealtorList();
        private void ManagerLi_Loaded(object sender, RoutedEventArgs e)
        {
            ManagerLi.ItemsSource = dtManager.DefaultView;
        }

        public static DataTable GetRealtorList()
        {
            RealtorEntities db = new RealtorEntities();
            DataTable dtManager = new DataTable();
            dtManager.Columns.Add("id");
            dtManager.Columns.Add("Логин");
            dtManager.Columns.Add("Пароль");
            var Query = db.Manager;

            foreach (var rel in Query)
            {

                dtManager.Rows.Add(rel.IdManager, rel.Login, rel.Password);

            }
            return dtManager;
        }

        private void ManagerLi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                SecurityContext.idManager = int.Parse((dtManager.Rows[ManagerLi.SelectedIndex].ItemArray[0].ToString()));
                CurrentManager re = new CurrentManager();
                this.Hide();
                re.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ManagerLi.ItemsSource = dtManager.DefaultView;
            }
        }
    }
}

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
    /// Логика взаимодействия для ClientList.xaml
    /// </summary>
    public partial class ClientList : Window
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientLi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        DataTable dtClient = GetClientList();
        private void ClientLi_Loaded(object sender, RoutedEventArgs e)
        {
            ClientLi.ItemsSource = dtClient.DefaultView;
        }
        public static DataTable GetClientList()
        {
            RealtorEntities db = new RealtorEntities();
            DataTable dtClient = new DataTable();
            dtClient.Columns.Add("id");
            dtClient.Columns.Add("Фамилия");
            dtClient.Columns.Add("Имя");
            dtClient.Columns.Add("Отчество");
            dtClient.Columns.Add("Номер телефона");
            dtClient.Columns.Add("Эл почта");
            var Query = db.Client;

            foreach (var rel in Query)
            {

                dtClient.Rows.Add(rel.id, rel.LastName, rel.Name, rel.MiddleName, rel.Phone, rel.Email);

            }
            return dtClient;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Realtors cur = new Realtors();
            this.Hide();
            cur.Show();

        }

        private void ClientLi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                SecurityContext.idClient = int.Parse((dtClient.Rows[ClientLi.SelectedIndex].ItemArray[0].ToString()));
                CurrentClient cur = new CurrentClient();
                this.Hide();
                cur.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClientLi.ItemsSource = dtClient.DefaultView;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrClient cur = new RegistrClient();
            this.Hide();
            cur.Show();
        }
    }
}

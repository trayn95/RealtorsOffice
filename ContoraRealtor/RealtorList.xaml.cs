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
    /// Логика взаимодействия для RealtorList.xaml
    /// </summary>
    public partial class RealtorList : Window
    {
        public RealtorList()
        {
            InitializeComponent();
        }
        DataTable dtRealtor = GetRealtorList();
         
        private void Loaded_grid(object sender, RoutedEventArgs e)
        {
            RealtorLi.ItemsSource = dtRealtor.DefaultView;
        }
        public static DataTable GetRealtorList()
        {
            RealtorEntities db = new RealtorEntities();
            DataTable dtRealtor = new DataTable();
            dtRealtor.Columns.Add("id");
            dtRealtor.Columns.Add("Фамилия");
            dtRealtor.Columns.Add("Имя");
            dtRealtor.Columns.Add("Отчество");
            dtRealtor.Columns.Add("Доля комисси");
            var Query = db.Realtor;

            foreach (var rel in Query)
            {

                dtRealtor.Rows.Add(rel.id, rel.LastName, rel.Name, rel.MiddleName, rel.Comission);

            }
            return dtRealtor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Realtors  cur = new Realtors();
            this.Hide();
            cur.Show();
        }
        
        private void RealtorLi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {  try
            {
                SecurityContext.idRealtor = int.Parse((dtRealtor.Rows[RealtorLi.SelectedIndex].ItemArray[0].ToString()));

                CurrentRealtor cur = new CurrentRealtor();
                this.Hide();
                cur.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                RealtorLi.ItemsSource = dtRealtor.DefaultView;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrRealtor reg = new RegistrRealtor();
            this.Hide();
            reg.Show();
        }
    }
}

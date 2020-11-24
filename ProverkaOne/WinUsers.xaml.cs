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
using System.Data.Entity;

namespace ProverkaOne
{
    /// <summary>
    /// Логика взаимодействия для WinUsers.xaml
    /// </summary>
    public partial class WinUsers : Window
    {
        public WinUsers()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Visibility = Visibility.Visible;

            ПрактикаOneEntities db = new ПрактикаOneEntities();
                db.Пользователи.Load();
            var query = from t in db.Пользователи select new { t.Логин, t.Пароль, t.ФИО };
            DataBase.ItemsSource = query.ToList();




        }
    }
}

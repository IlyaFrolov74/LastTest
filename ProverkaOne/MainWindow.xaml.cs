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
using System.Data.Entity;

namespace ProverkaOne
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string LoginCS = LoginWPF.Text;
            string PasswordCS = PasswordWPF.Text;

            ПрактикаOneEntities db = new ПрактикаOneEntities();

            db.Пользователи.Load();

            var Vxod = db.Пользователи.Where(u => u.Логин == LoginCS && u.Пароль == PasswordCS).FirstOrDefault();

            if(Vxod ==null)
            {
                MessageBox.Show("Не правильно указаны данные");
            }
            if(Vxod !=null)
            {
                if (Vxod != null && Vxod.Роль != "Администратор")
                {
                    WinUsers winUsers = new WinUsers();
                    winUsers.Show();
                    Close();
                }                    

            }

        }

        private void RegistrationButton(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();

        }
    }
}

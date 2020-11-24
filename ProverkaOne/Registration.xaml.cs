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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newLogin = LoginReg.Text;
            string newPassword = PasswordReg.Text;
            string newName = NameReg.Text;

            ПрактикаOneEntities db = new ПрактикаOneEntities();

            db.Пользователи.Load();

            var Regist = db.Пользователи.Where(u => u.Логин == newLogin).FirstOrDefault();


            if (LoginReg.Text == "" || PasswordReg.Text =="" || NameReg.Text =="")
            {
                MessageBox.Show("Заполните все данные");
            }

            if((Regist != null) && LoginReg.Text != "" || PasswordReg.Text != "" || NameReg.Text != "")
            {
                Regist = new Пользователи();
                Regist.Логин = newLogin;
                Regist.Пароль = newPassword;
                Regist.ФИО = newName;
                db.Пользователи.Add(Regist);
                db.SaveChanges();
                MessageBox.Show("Пользователь успешно добавлен! ");





            }



        }

        private void MainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

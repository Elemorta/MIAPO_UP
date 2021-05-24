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

namespace MIAPO_UP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Auth_User : Window
    {
        ApplicationContext db;
        public Auth_User()
        {
            InitializeComponent();
            db = new ApplicationContext();
            
        }

        private void Authbotton_Click(object sender, RoutedEventArgs e)
        {
            List<Employer> employers = db.Employer.ToList();
            string str = "";
            string loginuser = login.Text;
            string passworduser = password.Text;

            var FK_user_id = db.Users.Where(b => b.User_login == loginuser && b.User_password == passworduser).FirstOrDefault();
            if (FK_user_id != null)
            {
                var User = db.Employer.Where(b => b.FK_User_id == FK_user_id.User_id).FirstOrDefault();
                if (User.FK_Position_id == 1)
                {
                    this.Hide();
                    Administrator_Choose Adup = new Administrator_Choose();
                    Adup.Show();
                }
                if (User.FK_Position_id == 2 )
                {
                    this.Hide();
                    Employer_Choose emp = new Employer_Choose();
                    emp.Show();
                }
                if (User.FK_Position_id == 3)
                {
                    this.Hide();
                    Employer_Choose emp = new Employer_Choose();
                    emp.Show();
                }
                if (User.FK_Position_id == 4)
                {
                    this.Hide();
                    Employer_Shifts acc = new Employer_Shifts();
                    acc.Show();
                }
            }
        }
    }
}

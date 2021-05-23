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
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
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

            int FK_user_id = db.Users.Where(b => b.User_login = (loginuser || !b.User_password) = passworduser);
            foreach (Employer emp in employers)

            MessageBox.Show(str);
        }
    }
}

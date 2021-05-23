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

namespace MIAPO_UP
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AdministratorPage : Window
    {
        ApplicationContext db;
        public AdministratorPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void CreateEmployer_Click(object sender, RoutedEventArgs e)
        {
            
            Users newposition = new Users();
            newposition.User_login = Position.Text;
            newposition.User_password = Salary.Text;
            newposition.User_id = 1;
            db.Users.Add(newposition);
            db.SaveChanges();
            List<Users> users = db.Users.ToList();
            string str = "";
            foreach (Users use in users)
                str += "Должность: " + use.User_login + " | ";
            MessageBox.Show(str);
        }
    }
}

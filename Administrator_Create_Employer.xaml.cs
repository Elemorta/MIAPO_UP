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
    /// Логика взаимодействия для Administrator_Create_Employer.xaml
    /// </summary>
    public partial class Administrator_Create_Employer : Window
    {
        ApplicationContext db;
        public Administrator_Create_Employer()
        {
            
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Create_Employer(object sender, RoutedEventArgs e)
        {
            
            Employer newemployer = new Employer();
            newemployer.First_Name = First_Name.Text;
            newemployer.Second_Name = Second_Name.Text;
            if(Position.Text == "Бухгалтер")
            {
                newemployer.FK_Position_id = 4;
            }
            if (Position.Text == "Механик")
            {
                newemployer.FK_Position_id = 2;
            }
            if (Position.Text == "Водитель")
            {
                newemployer.FK_Position_id = 3;
            }
            newemployer.Salary = Convert.ToInt32(Salary.Text);
            newemployer.Expirience = Convert.ToInt32(Expirience.Text);
            Users newuser = new Users();
            newuser.User_login = Login.Text;
            newuser.User_password = Password.Text;
            db.Users.Add(newuser);
            db.SaveChanges();
            var user = db.Users.AsEnumerable().Last().User_id;
            MessageBox.Show(Convert.ToString(user));
            newemployer.FK_User_id = user;
            db.Employer.Add(newemployer);
            db.SaveChanges();
            var last = db.Employer.AsEnumerable().Last().First_Name;
            MessageBox.Show(last);
        }
    }
}

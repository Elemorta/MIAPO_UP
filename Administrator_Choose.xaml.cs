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
    /// Логика взаимодействия для Administrator_Choose.xaml
    /// </summary>
    public partial class Administrator_Choose : Window
    {
        public Administrator_Choose()
        {
            InitializeComponent();
        }

        private void Open_Window_Service_Car(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Service_Car_Window ads = new Service_Car_Window();
            ads.Show();
        }

        private void Open_Window_Create_Employer(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Administrator_Create_Employer ads = new Administrator_Create_Employer();
            ads.Show();
        }

        private void Open_Window_Edit_DataBase(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Administrator_Edit ads = new Administrator_Edit();
            ads.Show();
        }

        private void Open_Window_Shift_Employer(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employer_Shifts ads = new Employer_Shifts();
            ads.Show();
        }
    }
}

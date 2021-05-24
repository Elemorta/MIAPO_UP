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
    public partial class AdministratorChoose : Window
    {
        ApplicationContext db;
        public AdministratorChoose()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }


        private void CreateEmployer_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}

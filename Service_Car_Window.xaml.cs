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
    /// Логика взаимодействия для Service_Car_Window.xaml
    /// </summary>
    public partial class Service_Car_Window : Window
    {
        ApplicationContext db;
        public Service_Car_Window()
        {
            InitializeComponent();
            db = new ApplicationContext();
            DataGridfs.ItemsSource = db.Service_car.ToList();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            int Carid = Convert.ToInt32(Car_id.Text);
            DataGridfs.ItemsSource = db.Service_car.Where(ds => ds.Car_id == Carid).ToList();
        }
    }
}

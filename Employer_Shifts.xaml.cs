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
    /// Логика взаимодействия для Employer_Shifts.xaml
    /// </summary>
    public partial class Employer_Shifts : Window
    {
        ApplicationContext db;
        public Employer_Shifts()
        {
            InitializeComponent();
            db = new ApplicationContext();
            
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            int id_Employer = Convert.ToInt32(Employer_id.Text);
            List<Shift> Date = db.Shift.ToList();
            MessageBox.Show(Convert.ToString(Date.ToList()));

        }
    }
}

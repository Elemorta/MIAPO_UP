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
    /// Логика взаимодействия для Employer_Choose.xaml
    /// </summary>
    public partial class Employer_Choose : Window
    {
        ApplicationContext db;
        public int IP;
        public Employer_Choose(int Empid)
        {
            InitializeComponent();
            db = new ApplicationContext();
            IP = Empid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Shift beginshift = new Shift();
            beginshift.Employer_id = IP;
            beginshift.Date_begin = DateTime.Now.ToString();
            beginshift.Date_end = null;
            db.Shift.Add(beginshift);
            db.SaveChanges();
            MessageBox.Show("Смена открыта!");
            this.Hide();
            Service_Car_Window sd = new Service_Car_Window();
            sd.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Shift beginshift = new Shift();
            beginshift.Employer_id = IP;
            int lastReport = db.Shift.AsEnumerable().Last().shift_id;
            beginshift.Date_begin = db.Shift.Where(df => df.shift_id == lastReport).FirstOrDefault().Date_begin;
            beginshift.Date_end = DateTime.Now.ToString();
            db.Shift.Remove(db.Shift.AsEnumerable().Last());
            db.Shift.Add(beginshift);
            db.SaveChanges();
            MessageBox.Show("Смена закрыта!");
            this.Hide();
            Auth_User asd = new Auth_User();
            asd.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Service_Car_Window sd = new Service_Car_Window();
            sd.Show();
        }
    }
}

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

namespace DataGridViewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //PhonesContainer phones;
        List<Phone> phones;


        public MainWindow()
        {
            InitializeComponent();
            //phones = new PhonesContainer();
            phones = new List<Phone>();
            phonesGrid.ItemsSource = phones;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Phone simplePhone;
            simplePhone = new Phone();

            simplePhone.Company = "Nokia";
            simplePhone.Title = "6200";
            simplePhone.Price = 100;


            //Phone phone = new Phone { Title = "iPhone 6S", Company = "Apple", Price = 54990 };



            //phones.Add("iPhone 6S", "Apple", 54990);
            phones.Add(simplePhone);

            //phonesGrid.Items.Refresh();
            //phonesGrid.ItemsSource = null;
            //phonesGrid.ItemsSource = phones;
        }


        


    }
}

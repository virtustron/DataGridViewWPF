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
        List<Phone> phones;

        //PhonesContainer phones;
        //CommunicationDeviceColllection devices;

        public MainWindow()
        {
            InitializeComponent();
            phones = new List<Phone>();


            phonesGrid.ItemsSource = phones;


            //phones = new PhonesContainer();
            //devices = new CommunicationDeviceColllection();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            Phone simplePhone;
            simplePhone = new Phone();

            simplePhone.Company = "Nokia";
            simplePhone.Title = "6200";
            simplePhone.Price = 100;

            phones.Add(simplePhone);


            phonesGrid.ItemsSource = null;
            phonesGrid.ItemsSource = phones;



            /*
            Button b = (Button)sender;
                        
            
            CommunicationDevice device1 = new Phone { Title = "C62", Company = "Nokia", Price = 1000, QwertyKeyboard = true };
            devices.Add(device1);


            CommunicationDevice device2 = new SmartPhone { Title = "iPhone 10 Pro Max", Company = "Apple", Price = 10000, OperationSystem = "iOS 10"};
            devices.Add(device2);

            CommunicationDevice device3 = new Phone { Title = "C62", Company = "Nokia", Price = 1000, QwertyKeyboard = true };
            devices.Add(device3);

            CommunicationDevice device4 = new Phone { Title = "C62", Company = "Nokia", Price = 1000, QwertyKeyboard = true };
            devices.Add(device4);

            CommunicationDevice device5 = new SmartPhone { Title = "iPhone 10 Pro Max", Company = "Apple", Price = 10000, OperationSystem = "iOS 10" };
            devices.Add(device2);



            string s = devices.DisplayItems();
            */







            //Phone phone = new Phone { Title = "iPhone 6S", Company = "Apple", Price = 54990 };



            //phones.Add("iPhone 6S", "Apple", 54990);
            //

            //phonesGrid.Items.Refresh();










        }

    }
}

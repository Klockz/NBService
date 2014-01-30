using Controller;
using Interfaces;
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

namespace NB_Service
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerFacade cf = new CustomerFacade();
        private AppointmentFacade af;
        public List<ICustomer> customersList;

        public MainWindow()
        {
            af = new AppointmentFacade(cf);
            InitializeComponent();
            customersList = cf.LoadAllCustomers();
            customersListView.ItemsSource = customersList;
        }

        private void CreateCustomerClicked(object sender, RoutedEventArgs e)
        {
            CreateCustomerDialog ccd = new CreateCustomerDialog(this, cf, af);
            ccd.ShowDialog();
        }

        private void changeCustomerButtonClicked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

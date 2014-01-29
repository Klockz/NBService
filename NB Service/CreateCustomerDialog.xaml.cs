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
using System.Windows.Shapes;

namespace NB_Service
{
    /// <summary>
    /// Interaction logic for CreateCustomerDialog.xaml
    /// </summary>
    public partial class CreateCustomerDialog : Window
    {
        MainWindow mainWindow;
        CustomerFacade cf;
        ICustomer icustomer;

        public CreateCustomerDialog(MainWindow mainWindow, CustomerFacade cfInput)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            cf = cfInput;
            icustomer = cf.CreateCustomer();
        }

        private void SaveCustomerClicked(object sender, RoutedEventArgs e)
        {
            icustomer.Name = nameTextBox.Text;
            icustomer.ContactPerson = contactPersonTextBox.Text;
            icustomer.Address = addressTextBox.Text;
            icustomer.ZipCode = zipCodeTextBox.Text;
            icustomer.City = cityTextBox.Text;
            icustomer.PhoneNumber = phoneNumberTextBox.Text;

            cf.SaveCustomer(icustomer);
            mainWindow.customersListView.Items.Refresh();

            this.Close();
        }

        private void ExitButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addAppointmentClicked(object sender, RoutedEventArgs e)
        {

        }

        private void deleteAppointmentClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}

using DataAccess;
using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CustomerFacade
    {
        public List<ICustomer> customersList { get; set; }

        public CustomerFacade()
        {
            customersList = new List<ICustomer>();
        }

        public ICustomer CreateCustomer()
        {
            return new Customer();
        }

        public void SaveCustomer(ICustomer customer)
        {
            customersList.Add(customer);
            CustomerAccessFacade.SaveAllCustomers(customersList);
        }

        public List<ICustomer> LoadAllCustomers()
        {
            customersList = CustomerAccessFacade.LoadAllCustomers();
            return customersList;
        }

        public void AddAppointmentToCustomer(IAppointment iappointment, ICustomer icustomer)
        {
           
        }

        public List<IAppointment> AddAllCustomerAppointmentsToList(ICustomer icustomer, List<IAppointment> iappointmentsList)
        {
            for (int i = 0; i < icustomer.Appointments.Count; i++)
            {
                iappointmentsList.Add(icustomer.Appointments[i]);
            }
            return iappointmentsList;
        }

        //public List<IResource> theResources { get; private set; }
        //ResourceAccessFacade raf;

        //public ResourceFacade()
        //{
        //    theResources = new List<IResource>();
        //    raf = new ResourceAccessFacade();
        //}
         
        //public IResource Create(string Name, string Description)
        //{
        //    Resource r = new Resource(Name, Description);

        //    theResources.Add(r);
        //    raf.Create(r);
        //    return r;
        //}

        //public void Update(IResource ir) 
        //{
        //    raf.Update(ir);
        //}

        //public List<IResource> LoadAll() 
        //{
        //    theResources = raf.LoadAll();
        //    return theResources;
        //}

        //public void Delete(IResource ir)
        //{
        //    raf.Delete(ir);
        //}
    }
}

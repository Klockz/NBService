using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class CustomerAccessFacade
    {
        public static List<ICustomer> LoadAllCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>();

            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    return bin.Deserialize(stream) as List<ICustomer>;
                }
            }
            catch (Exception)
            {
            }
            return customers;
        }

        public static void SaveAllCustomers(List<ICustomer> customersList)
        {
            using (Stream stream = File.Open("data.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, customersList);
            }
        }
    }
}

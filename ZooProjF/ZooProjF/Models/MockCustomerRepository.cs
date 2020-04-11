/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Models
{
    public class MockCustomerRepository : ICustomerRepository
    {
        
        private readonly List<CustomerManagerment> _customerList;
        
        public MockCustomerRepository()
        {
            _customerList = new List<CustomerManagerment>()
            {

            };
        }
        public CustomerManagerment Get(int Customer_Id)
        {
            return _customerList.FirstOrDefault(c => c.Customer_Id == Customer_Id);
        }
    }
}*/

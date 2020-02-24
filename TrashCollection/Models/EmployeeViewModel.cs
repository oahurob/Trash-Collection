using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollection.Models
{
    public class EmployeeViewModel
    {
      
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public Address Address { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
    }
}

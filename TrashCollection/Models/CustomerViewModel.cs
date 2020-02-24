using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollection.Models
{
    public class CustomerViewModel
    {
        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public ServiceInfo ServiceInfo { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // Business Class
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine(customer.CustomerNo + "is added.");
        }
    }
}

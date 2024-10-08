﻿using System;
using System.Collections.Generic;
namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer() //Default and primity constructor
        {
            Orders = new List<Order>();
        }

        public Customer(int id) //Overloading Constructor
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

    }
}


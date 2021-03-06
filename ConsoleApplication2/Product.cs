﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Product
    {
        private string name;
        private string vendor;
        private double price;

        public Product(double price)
        {
            this.Price = price;
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Vendor
        {
            get
            {
                return vendor;
            }

            set
            {
                vendor = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public int ComperTo(object obj)
        {
            if (obj as Product != null)
            {
                Product pd = (Product)obj;
                int result;
                if (this.price > pd.price)
                {
                    result = 1;
                }
                else if (this.price < pd.price)
                {
                    result = -1;
                }
                else
                {
                    return 0;
                }
              
            }
            return 2;

       
        }
    }
}


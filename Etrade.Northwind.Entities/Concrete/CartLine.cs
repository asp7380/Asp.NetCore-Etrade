﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Etrade.Northwind.Entities.Concrete
{
    public class CartLine
    {

        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}

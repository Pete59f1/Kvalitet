﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Control
    {
        DBControl dbc;
        public Control()
        {
            dbc = new DBControl();

        }
       
       
        public void CreateCustomer(string name, string address, int zip, string town, string tlf)
        {
            
            dbc.CreateCustomer(name, address, zip, town, tlf);
        }
    }
}

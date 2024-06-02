using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rira_Task
{
       //product properties 
        public class Product
        {
            public int id { get; set; }

            public string name { get; set; }

            public Categories category { get; set; }

            public int price { get; set; }
        }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        public List<Customer>customer;
        private string price;
        private string weather;
       
        public int GetCustomer()
        {
            var randomCustomer = Random.Next() * 100;
            if (0 < randomCustomer < 20)
            {              
                //enter variable for weather and varible for price for grouping of customers
            }
            else (20 < randomCustomer < 40)
            {
                price = 
                weather = 
            }   
        } 
        public int CustomerCups()
        {
            //pass through what is in GetCustomer
        }  
        //store information about customers that purchase
    }
}

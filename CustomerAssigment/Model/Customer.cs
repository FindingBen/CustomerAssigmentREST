using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAssigment.Model
{
    public class Customer
    {

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Year { get; set; }
        


        public Customer(int id, string firstName, string lastName, int year)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Year = year;
            
        }

        //For json
        public Customer()
        {

        }

    }
}

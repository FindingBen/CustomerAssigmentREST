using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CustomerAssigment.Model;

namespace CustomerAssigment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static List<Customer> cList = new List<Customer>()
        {
            new Customer(1, "John", "Doe", 1972),
            new Customer(2, "Ben", "Linus", 1952),
            new Customer(3, "Jack", "Shepard", 1942)
        };
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return cList;
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            var Customer = cList.Find(s => s.Id == id);
            return Customer;
        }

        // POST: api/Customer
        [HttpPost]
        public Customer Post([FromBody] Customer customer)
        {
            cList.Add(customer);
            return customer;


        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer newcustomer)
        {
            var Customer = cList.Find(s => s.Id == id);
            Customer.firstName = newcustomer.firstName;
            Customer.lastName = newcustomer.lastName;
            Customer.Year = newcustomer.Year;
            Customer.Id = newcustomer.Id;
           
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var Customer = cList.Find(s => s.Id == id);
            if (Customer.Id != 0)
            {
                cList.Remove(Customer);
            }
        }
    }
}

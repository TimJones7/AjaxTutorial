using AjaxTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTutorial.Controllers
{
    public class CustomerController : Controller
    {

        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Sherry", 37));
            customers.Add(new Customer(1, "Time", 32));
            customers.Add(new Customer(2, "Charlene", 27));
            customers.Add(new Customer(3, "Jerry", 34));
            customers.Add(new Customer(4, "Barry", 87));
            customers.Add(new Customer(5, "Harry", 23));
            customers.Add(new Customer(6, "Larry", 43));
        }



        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);           

            return View("Customer", tuple);
        }
    }
}
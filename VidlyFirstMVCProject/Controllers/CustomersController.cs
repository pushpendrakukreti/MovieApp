﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyFirstMVCProject.Models;

namespace VidlyFirstMVCProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View();
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c=>c.Id==id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        private  IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1,Name="John Smith"},
                new Customer{Id=2,Name="Mary Williams"}
            };
        }
    }
}
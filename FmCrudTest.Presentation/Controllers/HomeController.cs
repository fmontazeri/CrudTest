using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FmCrudTest.Domain;
using FmCrudTest.Domain.CustomerAgg;
using FmCrudTest.Presentation.ExtenstionMethods;
using FmCrudTest.Presentation.Models;

namespace FmCrudTest.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var customers = customerRepository.GetAll();
            return View(customers);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var customer = customerRepository.GetById(id);
            return View(customer);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(CreateCustomerModel collection)
        {
            try
            {
                // TODO: Add insert logic here
                var dateOfBirth = DateTimeExtensionMethods.ToDateTime(collection.DateOfBirth);
                var customer = new Customer(collection.FirstName,collection.LastName, dateOfBirth, collection.PhoneNumber,collection.Email,collection.BankAccountNumber);
                 customerRepository.Add(customer);
                return RedirectToAction("Index");
            }
            catch (BusinessException ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error" , ex.Message);
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = customerRepository.GetById(id);
            var customerDto = new EditCustomerModel()
            {
                Id = customer.Id ,
                FirstName =  customer.FirstName ,
                LastName =  customer.LastName ,
                BankAccountNumber = customer.BankAccountNumber ,
                DateOfBirth = ExtenstionMethods.DateTimeExtensionMethods.ToStringFormat(customer.DateOfBirth),// customer.DateOfBirth ,
                Email = customer.Email ,
                PhoneNumber = customer.PhoneNumber
            };
            return View(customerDto);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EditCustomerModel collection)
        {
            try
            {
                // TODO: Add update logic here
                var customer = customerRepository.GetById(id);
                var dateOfBirth = DateTimeExtensionMethods.ToDateTime(collection.DateOfBirth);
                customer.Update(collection.FirstName, collection.LastName, dateOfBirth,
                    collection.PhoneNumber, collection.Email, collection.BankAccountNumber);
                customerRepository.Update(customer);
                return RedirectToAction("Index");
            }
            catch (BusinessException ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View();
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", "An unhandle error has been occured!");
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = customerRepository.GetById(id);
            return View(customer);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                customerRepository.Delete(id);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
}

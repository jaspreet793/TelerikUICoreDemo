using TelerikUICoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUICoreDemo.DL
{
    public class CustomerDataLogic
    {
        readonly List<string> _randomTitle = new List<string>() { "Demo One", "Demo Two", "Demo Three" };
        // Get All Records
        public List<Dealer> GetAll()
        {
            var customerList = new List<Dealer>();

            for (var i = 1; i <= 100; i++)
            {
                Random rnd = new Random();
                int val = rnd.Next(0, 2);

                var customer = new Dealer
                {
                    Id = i,
                    Balance = 3.33m,
                    Email = "jay@jay.com",
                    StartDate = DateTime.Today,
                    Name = _randomTitle[val],
                    EditUrl = "https://www.google.com"
                };

                customerList.Add(customer);
            }

            return customerList;
        }


        // Get a record by Id
        public Dealer Get(int id)
        {
            Console.WriteLine("Get All got called");
            var customer = new Dealer
            {
                Id = id,
                Balance = 3.33m,
                Email = "jay@jay.com",
                StartDate = DateTime.Today,
                Name = "The Id Is " + id,
                EditUrl = "https://www.google.com"
            };

            return customer;
        }

        // Delete
        public bool Delete(int id)
        {
            Console.WriteLine("Delete got called");
            return true;
        }

        // Save
        public Dealer Post(Dealer dto)
        {
            Console.WriteLine("Post got called");

            if (dto.Email == "jay@gmail.com")
            {
                throw new Exception("Email is not Valid");
            }

            Random rnd = new Random();
            int val = rnd.Next(101, 200);

            var customer = new Dealer
            {
                Id = val,
                Balance = dto.Balance,
                Email = dto.Email,
                StartDate = dto.StartDate,
                Name = dto.Name,
                EditUrl = dto.EditUrl
            };

            return customer;
        }

        // Update
        public Dealer Put(Dealer dto)
        {
            Console.WriteLine("Update Got Called");
            var customer = new Dealer
            {
                Id = dto.Id,
                Balance = dto.Balance,
                Email = dto.Email,
                StartDate = dto.StartDate,
                Name = dto.Name,
                EditUrl = dto.EditUrl
            };

            return customer;
        }

    }
}

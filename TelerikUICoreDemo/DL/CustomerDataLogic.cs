using TelerikUICoreDemo.Models;
using System;
using System.Collections.Generic;

namespace TelerikUICoreDemo.DL
{
    public class CustomerDataLogic
    {
        readonly List<string> _randomTitle = new List<string>() { "Demo One", "Demo Two", "Demo Three", "Demo Four" };
        // Get All Records For a give group id
        public List<CallListDto> GetAll()
        {
            var customerList = new List<CallListDto>();
            int id = 100;

            for (var i = 1; i <= 100; i++)
            {
                Random rnd = new Random();
                int val = rnd.Next(0, 3);

                var customer = new CallListDto
                {
                    Id = i + id,
                    Status = "New",
                    Name = _randomTitle[val],
                    CallStartDate = DateTime.Today,
                    LastCallDate = DateTime.Today,
                    CallSheet = "https://www.google.com"
                };

                customerList.Add(customer);
            }

            return customerList;
        }


        // Get a record by Id
        public CallListDto Get(int id)
        {
            Console.WriteLine("Get All got called");
            var customer = new CallListDto
            {
                Id = id,
                Status = "New",
                Name = _randomTitle[2],
                CallStartDate = DateTime.Today,
                LastCallDate = DateTime.Today,
                CallSheet = "https://www.google.com"
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
        public CallListDto Post(CallListDto dto)
        {
            Console.WriteLine("Post got called");

            if (dto.Name == "jay")
            {
                throw new Exception("Name is not Valid");
            }

            Random rnd = new Random();
            int val = rnd.Next(101, 200);

            var customer = new CallListDto
            {
                Id = 1,
                Status = "New",
                Name = _randomTitle[2],
                CallStartDate = DateTime.Today,
                LastCallDate = DateTime.Today,
                CallSheet = "https://www.google.com"
            };

            return customer;
        }

        // Update
        public CallListDto Put(CallListDto dto)
        {
            Console.WriteLine("Update Got Called");
            var customer = new CallListDto
            {
                Id = 1,
                Status = "New",
                Name = _randomTitle[2],
                CallStartDate = DateTime.Today,
                LastCallDate = DateTime.Today,
                CallSheet = "https://www.google.com"
            };

            return customer;
        }

    }
}

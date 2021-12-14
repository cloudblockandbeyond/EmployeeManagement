using System;

namespace Backend.Api.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Dept Department { get; set; }

        public string Email { get; set; }
    }
}

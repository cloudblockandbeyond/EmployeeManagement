using System;
using System.Collections.Generic;
using Backend.Api.Models;

namespace Backend.Api.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeRepository()
        {
            this._employees = new List<Employee>()
            {
                new Employee() { Id = new Guid(), Name = "Pavan", Department = Dept.IT, Email = "pavan@employeemanagement.com" },
                new Employee() { Id = new Guid(), Name = "Kumar", Department = Dept.Admin, Email = "kumar@employeemanagement.com" },
                new Employee() { Id = new Guid(), Name = "Singh", Department = Dept.HR, Email = "singh@employeemanagement.com" }
            };
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return this._employees;
        }
    }
}

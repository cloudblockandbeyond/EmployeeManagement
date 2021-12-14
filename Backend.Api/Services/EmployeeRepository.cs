using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Api.Models;

namespace Backend.Api.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEnumerable<Employee> _employees;

        public EmployeeRepository()
        {
            this._employees = new List<Employee>()
            {
                new Employee() { Id = Guid.NewGuid(), Name = "Pavan", Department = Dept.IT, Email = "pavan@employeemanagement.com" },
                new Employee() { Id = Guid.NewGuid(), Name = "Kumar", Department = Dept.Admin, Email = "kumar@employeemanagement.com" },
                new Employee() { Id = Guid.NewGuid(), Name = "Singh", Department = Dept.HR, Email = "singh@employeemanagement.com" }
            };
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            return Task.Run(() => this._employees);
        }
    }
}

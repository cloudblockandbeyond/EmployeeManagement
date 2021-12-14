using System;
using System.Collections.Generic;
using Backend.Api.Models;

namespace Backend.Api.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Api.Models;

namespace Backend.Api.Services
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}

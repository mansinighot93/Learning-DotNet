using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using PrimaryForeinKeyEF.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;
        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public List<Employee> GetAll() => _employeeRepo.GetAll();
        public Employee GetById(int id) => _employeeRepo.GetById(id);
        public void Insert(Employee employee) => _employeeRepo.Insert(employee);
        public void Update(Employee employee) => _employeeRepo.Update(employee);
        public void Delete(int id) =>_employeeRepo.Delete(id);

    }
}
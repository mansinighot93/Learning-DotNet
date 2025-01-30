using Core.Models;
using PrimaryForeinKeyEF.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public void Insert(Employee employee);
        public void Update(Employee employee);
        public void Delete(int id);
    }
}

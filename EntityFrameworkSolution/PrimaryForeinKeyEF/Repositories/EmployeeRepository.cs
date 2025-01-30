using Core.Context;
using Core.Models;
using Core.Repositories.Interfaces;

namespace Core.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAll()
        {
            using(var context = new CollectionContext())
            {
                var emp = from prod in context.Employees select prod;
                return emp.ToList<Employee>();
            }
        }

        public Employee GetById(int id)
        {
            using(var context = new CollectionContext())
            {
                var emp = context.Employees.Find(id);
                return emp;
            }
        }

        public void Insert(Employee employee)
        {
            using(var context = new CollectionContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public void Update(Employee employee)
        {
            using(var context = new CollectionContext())
            {
                var theEmp = context.Employees.Find(employee.EmployeeId);
                theEmp.Name = employee.Name;
                theEmp.Position = employee.Position;
                theEmp.DepartmentId = employee.DepartmentId;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Employees.Remove(context.Employees.Find(id));
                context.SaveChanges();
            }
        }
    }
}


using Core.Context;
using Core.Models;
using Core.Repositories.Interfaces;

namespace Core.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public List<Department> GetAll()
        {
            using(var context = new CollectionContext())
            {
                var dept = from prod in context.Departments select prod;
                return dept.ToList<Department>();
            }
        }

        public Department GetById(int id)
        {
            using(var context = new CollectionContext())
            {
                var dept = context.Departments.Find(id);
                return dept;
            }
        }

        public void Insert(Department department)
        {
            using(var context = new CollectionContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public void Update(Department department)
        {
            using(var context = new CollectionContext())
            {
                var theDept = context.Departments.Find(department.DepartmentId);
                theDept.Name = department.Name;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using(var context = new CollectionContext())
            {
                context.Departments.Remove(context.Departments.Find(id));
                context.SaveChanges();
            }
        }
    }
}


using Core.Models;
using PrimaryForeinKeyEF.Models;
using System.Collections.Generic;

namespace Core.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department GetById(int id);
        void Insert(Department product);
        void Update(Department product);
        void Delete(int id);   
    }
}

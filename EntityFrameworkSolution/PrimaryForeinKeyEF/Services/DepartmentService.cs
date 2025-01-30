using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;
using PrimaryForeinKeyEF.Models;
using System.Collections.Generic;

namespace Core.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepo;
        public DepartmentService(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        public List<Department> GetAll() => _departmentRepo.GetAll();
        public Department GetById(int id) => _departmentRepo.GetById(id);
        public void Insert(Department department) => _departmentRepo.Insert(department);
        public void Update(Department department) => _departmentRepo.Update(department);
        public void Delete(int id) =>_departmentRepo.Delete(id);

    }
}
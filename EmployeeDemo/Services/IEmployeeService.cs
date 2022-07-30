using EmployeeDemo.Dtos;
using EmployeeDemo.Model;

namespace EmployeeDemo.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee Get(int id);
        void Delete(int id);
        Employee Create(EmployeeDto dto);
        void Update(int id)
    }
}

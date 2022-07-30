using EmployeeDemo.Data;
using EmployeeDemo.Dtos;
using EmployeeDemo.Model;

namespace EmployeeDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _context;

        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }

        public Employee Create(EmployeeDto dto)
        {

            var employee = new Employee
            {
                Department = dto.Department,
                Name = dto.Name,
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
           
            return employee;
        }
        public void Update(int id)
        {
            var emp = _context.Employees.Find(id);

            _context.Employees.Update(emp);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var emp = _context.Employees.Find(id);

            _context.Employees.Remove(emp);
            _context.SaveChanges();
        }

        public Employee Get(int id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        
    }
}

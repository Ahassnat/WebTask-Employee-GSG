using EmployeeDemo.Dtos;
using EmployeeDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
           
             _service.Delete(Id);
            return Ok();
        }
        public IActionResult Create(EmployeeDto dto)
        {
            var employee = _service.Create(dto);
            return Ok(employee);
        }
        public IActionResult Update(int  Id)
        {

            _service.Update(Id);
            return Ok();
        }
    }
}

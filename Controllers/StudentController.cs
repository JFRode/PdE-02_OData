using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SanFranciscoSchool.Infrastructure.Contexts;
using SanFranciscoSchool.Models;
using System.Collections.Generic;
using System.Linq;

namespace SanFranciscoSchool.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly SanFranciscoSchoolContext _dbContext;

        public StudentController(SanFranciscoSchoolContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Student> Get()
        {
            return _dbContext.Students.ToList();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();

            return new NoContentResult();
        }
    }
}
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using SanFranciscoSchool.Infrastructure.Contexts;
using SanFranciscoSchool.Models;
using System.Collections.Generic;
using System.Linq;

namespace SanFranciscoSchool.Controllers
{
    [Route("[controller]")]
    public class SchoolClassController : Controller
    {
        private readonly SanFranciscoSchoolContext _dbContext;

        public SchoolClassController(SanFranciscoSchoolContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        [EnableQuery()]
        public IEnumerable<SchoolClass> Get()
        {
            return _dbContext.SchoolClasses.ToList();
        }

        [HttpPost]
        public IActionResult Post([FromBody] SchoolClass schoolClass)
        {
            _dbContext.SchoolClasses.Add(schoolClass);
            _dbContext.SaveChanges();

            return new NoContentResult();
        }
    }
}
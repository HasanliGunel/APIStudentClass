using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIStudentClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ID=1, Name="Lale",Surname="Eliyeva",Age=25},
                new Student(){ID=2,Name="Tahir",Surname="Meherremov",Age=30}
            };
            return Ok(students);
        }
    }
}

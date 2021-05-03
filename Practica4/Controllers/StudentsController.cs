using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica4.Controllers
{
    [ApiController]
    [Route("/api/students")]
    public class StudentsController : ControllerBase
    {

        public StudentsController()
        {

        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            List<Student> lista = new List<Student>();
            lista.Add(new Student { Name = "Mauricio Angulo" });
            lista.Add(new Student { Name = "Mayra Oropeza" });
            lista.Add(new Student { Name = "Camila Medina" });
            lista.Add(new Student { Name = "Fabricio Fernandez" });
            lista.Add(new Student { Name = "Carlos Coronado" });
            lista.Add(new Student { Name = "Nicolas Barbery" });
            return lista;

        }

        [HttpPost]
        public Student CreateStudent([FromBody] string studentName)
        {
            return new Student()
            {
                Name = studentName
            };
        }

        [HttpPut]
        public Student UpdateStudent([FromBody] Student student)
        {
            student.Name = "updated";
            return student;
        }
        [HttpDelete]
        public Student DeleteStudent([FromBody] Student student)
        {
            student.Name = "deleted";
            return student;
        }
    }
}

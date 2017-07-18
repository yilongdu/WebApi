using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Model;
using MyWebApi.DataAsistent;

namespace MyWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        // GET: api/Student
        [HttpGet]
        public IEnumerable<StudentModel> Get()
        {
            return new List<StudentModel> { new StudentModel { Name = "张三" }, new StudentModel { Name = "李四" } };
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public StudentModel Get(int id)
        {
            StudentAsistent asistent = new StudentAsistent();
            return asistent.Get(id);
            return new StudentModel();
        }
        
        // POST: api/Student
        [HttpPost]
        public void Post([FromBody]IEnumerable<StudentModel> value)
        {
            StudentAsistent asistent = new StudentAsistent();
            //foreach (var val in value)
            //{
            //    asistent.Add(val);
            //}
        }
        
        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using MyWebApi.DataAsistent;
using MyWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentModel> Get([FromUri]StudentModel value)
        {
            StudentAsistent asist = new StudentAsistent();
            return asist.GetList(value);
        }

        // GET: api/Student/5
        public StudentModel Get(int id)
        {
            StudentAsistent asist = new StudentAsistent();
            return asist.Get(id);
        }

        // POST: api/Student
        [HttpPost]
        public int Post([FromBody]StudentModel value)
        {
            StudentAsistent asist = new StudentAsistent();
            return asist.Add(value);
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]StudentModel value)
        {
            StudentAsistent asist = new StudentAsistent();
            asist.Update(id,value);
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
            StudentAsistent asist = new StudentAsistent();
            asist.Delete(id);
        }

        [HttpPatch]
        public void Patch()
        {

        }
    }
}

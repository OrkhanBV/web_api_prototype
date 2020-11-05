using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevFactoryZ.Web.api
{
    [Route("api/[controller]")]
    public class SubjectsController : ControllerBase
    {

        //private readonly MyDbContext db;
        //public SubjectsController(MyDbContext db)
        //{
        //    this.db = db;
        //}


        //ПРИМЕР ТОГО КАК ВЫТЯНУТЬ ОБЩИЙ ПУЛ ИЗ БАЗЫ ДАННЫХ ПО GET
        // GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<Subject> Get()
        //{
        //return db.Set<Subject>().ToList();
        //}

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //ПРИМЕР ТОГО КАК ЧТО-ТО КОНКРЕТНОЕ ЗАПУСТИТЬ ИЗ БАЗЫ ДАННЫХ
        // GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Subject Get(int id)
        //{
        //      return db.Set<Subject>().Single(x => x.Id == id);
        //}



        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //ЕЩЕ ОДИН ПРИМЕР КАК ПРАВИЛЬНО ОБРАБАТЫВАТЬ ЗАПРОСЫ ПО ID
        //[HttpGet("{id}")]
        //public ActionResult<Subject> Get(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return BadRequest();
        //    }
        //\
        //    var subjects = db.Set<Subject>();
        //    return Subjects.Any(x => x.Id == id)
        //        ? (ActionResult<Subject>)Subjects.Single(x => x.Id == id)
        //        : NotFound();
        //}


        //ПРИМЕР РЕАЛИЗАЦИИ GET ЗАПРОСА ЧЕРЕЗ ИНДИВИДУАЛЬНЫЙ ПУТЬ К ОБЪЕКТУ С ИСПОЛЬЗОВАНИЕМ [Route("путь")]
        [HttpGet]
        [Route("orkhan")]
        public string GetOrkhan()
        {
            return "Hello from Orkhan";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        //ПРИМЕР РЕАЛИЗАЦИИ HTTPPOST НА ПРИМЕРЕ УСЛОВНОЙ БАЗЫ ДАННЫХ
        // POST api/<controller>
        //public int Post([FromBody]string title)
        //{
        //    db.Add(Subject);
        //    db.SaveChanges();
        //    return subject.Id;
        //}

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        //ПРИМЕР РЕАЛИЗАЦИИ PUT 
        //[HttpPut("{id}")]
        //public Subject Put(int id, [FromBody]string title)
        //{
        //    var subject = db.Set<subject>().Single(x => x.Id == id);
        //    subject.Title = title;
        //    db.SaveChanges();

        //    return subject;
        //}

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //ПРИМЕР РЕАЛИЗАЦИИ DELETE
        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var subject = db.Set<Subject>().Single(x => x.Id == id);
        //    db.Remove(subject);
        //    db.SaveChanges();
        //}
    }
}
}

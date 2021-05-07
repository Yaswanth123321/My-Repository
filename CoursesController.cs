using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TrainingCompany.Controllers
{
    public class CoursesController : ApiController
    {
        public static List<Course> courses = initcourse();
        private static List<Course> initcourse()
        {
            var ret = new List<Course>();
            ret.Add(new Course() { Id = 1, Title = "first" });
            ret.Add(new Course() { Id = 2, Title = "second" });
            ret.Add(new Course() { Id = 3, Title = "third" });
            ret.Add(new Course() { Id = 4, Title = "fourth" });
            ret.Add(new Course() { Id = 5, Title = "fifth" });
            return ret;
        }
        public IEnumerable<Course> Get()
        {
            return courses;
        }
        public HttpResponseMessage Get(int id)
        {
            if (courses.Count > id)
            {
                var ret = (from c in courses where c.Id == id select c).FirstOrDefault();
                return Request.CreateResponse<Course>(HttpStatusCode.OK, ret);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error Not Found");
            }
        }
        public HttpResponseMessage Post([FromBody] Course c)
        { 
            courses.Add(c);
            var msg = Request.CreateResponse(HttpStatusCode.Created);
            msg.Headers.Location = new Uri(Request.RequestUri + "/" + (courses.Count).ToString());
            return msg;
        }
        public HttpResponseMessage Put(int id,[FromBody]Course course1)
        {
            var ret = (from c in courses where c.Id == id select c).FirstOrDefault();
            ret.Title = course1.Title;
            var msg1 = Request.CreateResponse(HttpStatusCode.Accepted);
            msg1.Headers.Location = new Uri(Request.RequestUri.ToString());
            return msg1;
        }
        public HttpResponseMessage Delete(int id)
        {
            courses.RemoveAt(id);
            var msg = Request.CreateResponse(HttpStatusCode.Gone);
            return msg;
        }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

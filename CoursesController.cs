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
        [HttpGet]
        public IEnumerable<Course> AllCourses()
        {
            return courses;
        }
        public static List<Course> courses = Initcourses();
        private static List<Course> Initcourses()
        {
            var ret = new List<Course>() { new Course() { Id = 0, Title = "first" },
                                           new Course() { Id = 1, Title = "second" },
                                           new Course() { Id = 2, Title = "third" },
                                           new Course() { Id = 3, Title = "fourth"},
                                           new Course() { Id = 4, Title = "fifth"}};
            return ret;
        }
        public Course Get(int id)
        {
            var ret = (from c in courses
                       where c.Id == id
                       select c).FirstOrDefault();
            return ret;

        }
        public void Post(Course c)
        {
            c.Id = courses.Count;
            courses.Add(c);
        }
        public class Course
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }
    }
}

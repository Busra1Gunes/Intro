using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CourseDal //veya Dao ,repository 
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();//newlemek :referans oluşturmak 
            course1.Id = 1;
            course1.Name = "C# kursu";
            course1.Description = ".Net 8";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java kursu";
            course2.Description = ".Java 8";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python kursu";
            course3.Description = "Python 20";
            course3.Price = 20;
            courses = new List<Course> { course1,course2,course3 };

        }
        public List<Course> GetAll()
        {
            return courses;
            //Burada db işlemleri yapılır 
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}

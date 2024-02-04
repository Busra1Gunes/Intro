using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //coursemanager newlendiğinde olduğu zaman çalışacak olan komut ctor
    //constructor
    Course[] courses=new Course[3];
    public CourseManager()
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;   
        
    }
    public Course[] GetAll() //getall çağrıldığında course datası geri döndürlecek 
    {
        //public void herhangi bir veri döndürülmeyecek
        //veri kaynağından çekilir
        return courses;
    }

}

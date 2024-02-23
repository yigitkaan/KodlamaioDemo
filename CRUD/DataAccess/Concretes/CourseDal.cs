using CRUD.DataAccess.Abstracts;
using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = "Yazılım Geliştirici Kampı";
        course1.Price = 0.0;
        course1.CategoryId = 1;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "JAVA + REACT";
        course2.Price = 100.99;
        course2.CategoryId = 1;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = ".NET";
        course3.Description = "Senior Yazılım Geliştirme";
        course3.Price = 100.99;
        course3.CategoryId = 1;

        Course course4 = new Course();
        course4.Id = 4;
        course4.Name = "Adobe Illustrate";
        course4.Description = "Grafik Tasarımcı Yetiştirme Kampı";
        course4.Price = 500.0;
        course4.CategoryId = 2;

        courses = new List<Course> { course1, course2, course3, course4 };
    }
    public void Add(Course course)
    {
        Course courseToAdd = courses.Find(x => x.Id == course.Id);

        if (courseToAdd == null)
        {
            courses.Add(course);
        }
        else
        {
            Console.WriteLine("Girdiğiniz id numaralı bir ders zaten mevcut olduğundan ekleme işlemi gerçekleştirilemedi!");
        }

        
    }

    public void Delete(int courseId)
    {
        Course courseToDelete = courses.Find(x => x.Id == courseId);

        if (courseToDelete != null)
        {
            courses.Remove(courseToDelete);
        }else
        {
            Console.WriteLine("Girdiğiniz id numaralı ders mevcut olmadığı için silme işlemi gerçekleştirilemedi!");
        }

        
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Update(int courseId, string newName, string newDescription, int newCatagoryId, double newPrice)
    {
        Course courseToUpdate = courses.Find(x => x.Id == courseId);

        if (courseToUpdate != null)
        {
            courseToUpdate.Name = newName;
            courseToUpdate.Description = newDescription;
            courseToUpdate.Price = newPrice;
            courseToUpdate.CategoryId = newCatagoryId;
        }else
        {
            Console.WriteLine("Girdiğiniz id numaralı ders mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
        }

        
    }
}

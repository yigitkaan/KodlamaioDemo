using CRUD.DataAccess.Abstracts;
using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUD.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;
    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.FirstName = "ENGİN";
        instructor1.LastName = "DEMİROĞ";
        instructor1.CourseIdentities = new List<int> { 1, 2, 3 };

        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.FirstName = "HALİT";
        instructor2.LastName = "KALAYCI";
        instructor2.CourseIdentities = new List<int> { 4};

        instructors = new List<Instructor> {instructor1, instructor2 };
    }

    

    public void Add(Instructor instructor)
    {
        Instructor instructorToAdd = instructors.Find(x => x.Id == instructor.Id);

        if (instructorToAdd == null)
        {
            instructors.Add(instructor);
        }else
        {
            Console.WriteLine("Girdiğiniz id numaralı bir öğretmen zaten mevcut olduğundan ekleme işlemi gerçekleştirilemedi!");
        }

        
    }

    public void Delete(int instructorId)
    {
        Instructor instructorToDelete = instructors.Find(x => x.Id == instructorId);

        if (instructorToDelete != null)
        {
            instructors.Remove(instructorToDelete);
        }
        else
        {
            Console.WriteLine("Girdiğiniz id numaralı öğretmen mevcut olmadığı için silme işlemi gerçekleştirilemedi!");
        }

        
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }
   

    public void Update(int instructorId, string newFirstName, string newLastName, List<int> newCourseIdentities)
    {
        Instructor instructorToUpdate = instructors.Find(x => x.Id == instructorId);

        if(instructorToUpdate != null)
        {
            instructorToUpdate.FirstName = newFirstName;
            instructorToUpdate.LastName = newLastName;
            instructorToUpdate.CourseIdentities = new List<int>(newCourseIdentities);
        }
        else
        {
            Console.WriteLine("Girdiğiniz id numaralı öğretmen mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
        }

        
    }
}

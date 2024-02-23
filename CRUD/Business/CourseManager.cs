using CRUD.DataAccess.Abstracts;
using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Business;

public class CourseManager
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(int courseId) {

        _courseDal.Delete(courseId);
    }

    public void Update(int courseId, string newName, string newDescription, int newCatagoryId, double newPrice)
    {
        _courseDal.Update(courseId, newName, newDescription, newCatagoryId, newPrice);
    }
}

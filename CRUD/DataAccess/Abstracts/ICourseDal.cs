using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DataAccess.Abstracts;

public interface ICourseDal
{
    void Add(Course course);
    void Update(int courseId, string newName, string newDescription, int newCatagoryId, double newPrice);
    void Delete(int courseId);
    List<Course> GetAll();
}

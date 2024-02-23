using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DataAccess.Abstracts;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    void Update(int instructorId, string newFirstName, string newLastName, List<int> newCourseIdentities);
    void Delete(int instructorId);
    List<Instructor> GetAll();
}

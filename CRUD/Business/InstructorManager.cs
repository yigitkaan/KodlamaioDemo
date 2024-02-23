using CRUD.DataAccess.Abstracts;
using CRUD.DataAccess.Concretes;
using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Business;

public class InstructorManager
{
    IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(int instructorId)
    {
        _instructorDal.Delete(instructorId);
    }

    public void Update(int instructorId, string newFirstName, string newLastName, List<int> newCourseIdentities)
    {
        _instructorDal.Update(instructorId, newFirstName, newLastName, newCourseIdentities);
    }
}

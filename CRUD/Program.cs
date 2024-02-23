// See https://aka.ms/new-console-template for more information
using CRUD.Business;
using CRUD.DataAccess.Concretes;
using CRUD.Entities;



Category category1 = new Category();
category1.Id = 1;
category1.Name = "Programlama";

Category category2 = new Category();
category2.Id = 2;
category2.Name = "Grafik Tasarım";

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category1);
categoryManager.Add(category2);


CourseManager courseManager = new CourseManager(new CourseDal());
InstructorManager instructorManager = new(new InstructorDal());
//InstructorManager instructorManager = new(new OutSourceInstructorDal());

List<Course> courses = courseManager.GetAll();
List<Instructor> instructors = instructorManager.GetAll();
List<Category> categories = categoryManager.GetAll();





Course course1 = new Course();
course1.Id = 5;
course1.Name = "Photoshop";
course1.Description = "Görsel düzenleme";
course1.Price = 175.0;
course1.CategoryId = 2;


courseManager.Add(course1);
courseManager.Update(1, "C++", "C++ Programlama", 1, 1000.0);
courseManager.Delete(5);



foreach (Course course in courses)
{
    Console.WriteLine(course.Id);
    Console.WriteLine(course.Name);
    Console.WriteLine(course.Description);
    Console.WriteLine(categories.Find(x => x.Id == course.CategoryId).Name);
    Console.WriteLine(course.Price);
    Console.WriteLine("----------------------");

}



Instructor instructor1 = new Instructor();
instructor1.Id = 3;
instructor1.FirstName = "REŞAT";
instructor1.LastName = "GÜNTEKİN";
instructor1.CourseIdentities = new List<int> {4};

instructorManager.Add(instructor1);
instructorManager.Update(2, "Yiğit", "Topcu", new List<int> { 2 });
instructorManager.Delete(1);

foreach (Instructor instructor in instructors)
{
    Console.WriteLine(instructor.Id);
    Console.WriteLine(instructor.FirstName);
    Console.WriteLine(instructor.LastName);

    for (int i = 0; i < instructor.CourseIdentities.Count; i++)
    {
        Console.Write(courses.Find(x => x.Id == instructor.CourseIdentities[i]).Name + ", ");
    }
    Console.WriteLine();
    Console.WriteLine("-------------------------");
}


Category category3 = new Category();
category3.Id = 3;
category3.Name = "Edebiyat";

categoryManager.Add(category3);
categoryManager.Delete(1);
categoryManager.Update(2, "Matematik");

foreach (Category category in categories)
{
    Console.WriteLine(category.Id);
    Console.WriteLine(category.Name);
    Console.WriteLine("---------------------");
}



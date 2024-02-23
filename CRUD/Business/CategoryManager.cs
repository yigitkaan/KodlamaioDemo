using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Business;

public class CategoryManager
{
    List<Category> categories = new List<Category>();
  

    public void Add(Category category)
    {
        Category categoryToAdd = categories.Find(x => x.Id == category.Id);

        if (categoryToAdd == null)
        {
            categories.Add(category);
        }
        else
        {
            Console.WriteLine("Girdiğiniz id numaralı bir kategori zaten mevcut olduğundan ekleme işlemi gerçekleştirilemedi!");
        }

               
        
    }

    public void Delete(int categoryId)
    {
        Category categoryToDelete = categories.Find(x => x.Id == categoryId);

        if (categoryToDelete != null)
        {
            categories.Remove(categoryToDelete);
        }
        else
        {
            Console.WriteLine("Girdiğiniz id numaralı kategori mevcut olmadığı için silme işlemi gerçekleştirilemedi!");
        }

        
    }

    public void Update(int categoryId, string newCategoryName)
    {
        Category categoryToUpdate = categories.Find(x => x.Id == categoryId);

        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = newCategoryName;
        }
        else
        {
            Console.WriteLine("Girdiğiniz id numaralı kategori mevcut olmadığı için güncelleme işlemi gerçekleştirilemedi!");
        }

        
    }

    public List<Category> GetAll()
    {
        return categories;
    }
}

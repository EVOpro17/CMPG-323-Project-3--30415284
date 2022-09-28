using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using DeviceManagement_WebApp.Data;
using System.Collections.Generic;

public interface ICategoriesRepository : IGenericRepository<Category>
{
    IEnumerable<Category> GetAllCategories();

    new Category GetById(int id);
    void Delete(IEnumerable<Category> categories);

    new void Add(Category entity);

}

using DeviceManagement_WebApp.Controllers;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
{
    public CategoriesRepository(ConnectedOfficeContext context) : base(context)
    {
    }

    public IEnumerable<Category> GetAllCategories()
    {
        return _context.Set<Category>().ToList();
    }

    public Category GetById(int id)
    {
        return _context.Set<Category>().Find(id);
    }
    public void Delete(IEnumerable<Category> categories)
    {
        _context.Remove(categories);
    }
    public void Add(Category entity)
    {
        _context.Add(entity);
    }
}

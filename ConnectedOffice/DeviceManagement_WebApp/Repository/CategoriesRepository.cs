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

    
}

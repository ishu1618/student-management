using Microsoft.EntityFrameworkCore;
using MVC_Project_2.Models;

namespace MVC_Project_2.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOption<AppDBContext>option):base(option)
        {
            
        }

    }
}

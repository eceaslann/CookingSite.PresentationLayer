using CookingSite.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSite.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RCI54VP;initial catalog=DbCookingSite;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipes> Recipess { get; set; }
        public DbSet<Cooker> Cookers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}

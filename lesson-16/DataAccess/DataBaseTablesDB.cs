using DbModel;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class DataBaseTablesDB:DbContext
    {
        public DbSet<Person> Students { get; set; }
        
        public 
    }
}
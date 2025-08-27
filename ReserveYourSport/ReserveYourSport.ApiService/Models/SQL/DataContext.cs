using Microsoft.EntityFrameworkCore;

namespace ReserveYourSport.ApiService.Models.SQL
{
    public class DataContext : DbContext
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<Court> Court { get; set; }
        public DbSet<Sport> Sport { get; set; }
    }
}

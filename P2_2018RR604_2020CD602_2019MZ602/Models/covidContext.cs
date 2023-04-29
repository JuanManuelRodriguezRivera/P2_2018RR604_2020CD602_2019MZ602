using Microsoft.EntityFrameworkCore;
using P2_2018RR604_2020CD602_2019MZ602.Models;

namespace P2_2018RR604_2020CD602_2019MZ602.Models
{
    public class covidDbContext : DbContext
    {
        public covidDbContext(DbContextOptions<covidDbContext> options) : base(options) { }

        public DbSet<Generos> Generos { get; set; }

        public DbSet<Departamentos> Departamentos {get; set;} 
    }
}

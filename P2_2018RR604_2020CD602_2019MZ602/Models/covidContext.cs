using Microsoft.EntityFrameworkCore;

namespace P2_2018RR604_2020CD602_2019MZ602.Models
{
    public class covidDbContext: DbContext
    {
        public covidDbContext(DbContextOptions options) : base(options) 
        {

        }
    }
}

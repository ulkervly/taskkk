using ALLUP2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ALLUP2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}

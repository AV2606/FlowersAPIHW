using FlowersAPIHW.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace FlowersAPIHW.DB
{
    public class FlowerDbContext : DbContext
    {
        //contructor that uses option builder
        public FlowerDbContext(DbContextOptions<FlowerDbContext> options) : base(options)
        {
            
        }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    //optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=FlowersApi;Trusted_Connection=True;");
        //}

        public DbSet<FlowerItem> Flowers { get; set; }
    }
}

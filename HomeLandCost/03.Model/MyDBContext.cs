using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLandCost._03.Model
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HomeLandCost;Integrated Security=True");
        }
        public DbSet<CostWorkerModel> CostWorker { get; set; }
        public DbSet<CostItemModel> CostItem { get; set; }
        public DbSet<UserModel> UserModels { get; set; }


    }
}

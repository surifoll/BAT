using System;
using BAT.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BAT.WebApi
{
    public class BatDbContext: DbContext
    {
        
        public BatDbContext(DbContextOptions<BatDbContext> options)
        : base(options)
        {
        }
        //entities

        public DbSet<Diy> Diys { get; set; }
    }

}

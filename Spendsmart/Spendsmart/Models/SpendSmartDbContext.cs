﻿using Microsoft.EntityFrameworkCore;

namespace Spendsmart.Models
{
    public class SpendSmartDbContext : DbContext 
    {
        public DbSet<Expense> expenses {  get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            : base(options) 
        { 

        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<tblEmployees> tblEmployees { get; set; }
        //public DbSet<tblEmployees> tblskil { get; set; }
        //public DbSet<tblEmployees> tblproduct { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDCore.Models;
namespace CRUDCore.Models
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {
        }
        public DbSet<CRUDCore.Models.Customer> Customer { get; set; }
    }
}

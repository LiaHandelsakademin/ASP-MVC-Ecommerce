using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LIAECommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LIAECommerce.Data
{
    public class DBContext : IdentityDbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
    }
}

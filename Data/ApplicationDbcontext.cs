using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DangThiAnh037.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<DangThiAnh037.Models.CompanyDTA037> CompanyDTA037 { get; set; } = default!;
    }

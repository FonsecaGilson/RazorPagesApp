﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class RazorPagesAppContext : DbContext
    {
        public RazorPagesAppContext (DbContextOptions<RazorPagesAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesApp.Models.TurmaModel> TurmaModel { get; set; } = default!;
        public DbSet<RazorPagesApp.Models.InscricaoModel> InscricaoModel { get; set; } = default!;
    }
}

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ApiNoviosTaylor.Model;

namespace ApiNoviosTaylor.Data
{
    public class NoviosContext:DbContext
    {
          public NoviosContext(DbContextOptions<NoviosContext> options) : base(options) { }

            public DbSet<Novio> Novios { get; set; }


        
    }
}

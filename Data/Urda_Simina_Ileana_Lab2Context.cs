using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Urda_Simina_Ileana_Lab2.Models;

namespace Urda_Simina_Ileana_Lab2.Data
{
    public class Urda_Simina_Ileana_Lab2Context : DbContext
    {
        public Urda_Simina_Ileana_Lab2Context (DbContextOptions<Urda_Simina_Ileana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Urda_Simina_Ileana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Urda_Simina_Ileana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Urda_Simina_Ileana_Lab2.Models.Author> Author { get; set; }

        public DbSet<Urda_Simina_Ileana_Lab2.Models.Category> Category { get; set; }

        public DbSet<Urda_Simina_Ileana_Lab2.Models.Member> Member { get; set; }

        public DbSet<Urda_Simina_Ileana_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}

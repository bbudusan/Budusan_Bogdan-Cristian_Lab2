using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Budusan_Bogdan_Cristian_Lab2.Models;

namespace Budusan_Bogdan_Cristian_Lab2.Data
{
    public class Budusan_Bogdan_Cristian_Lab2Context : DbContext
    {
        public Budusan_Bogdan_Cristian_Lab2Context (DbContextOptions<Budusan_Bogdan_Cristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Budusan_Bogdan_Cristian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Budusan_Bogdan_Cristian_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Budusan_Bogdan_Cristian_Lab2.Models.Author> Author { get; set; }

        public DbSet<Budusan_Bogdan_Cristian_Lab2.Models.Category> Category { get; set; }

        public DbSet<Budusan_Bogdan_Cristian_Lab2.Models.Member> Member { get; set; }

        public DbSet<Budusan_Bogdan_Cristian_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}

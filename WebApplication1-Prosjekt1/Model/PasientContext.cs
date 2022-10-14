using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Text;

namespace WebApplication1_Prosjekt1.Model
{
    public class PasientContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PasientContext(DbContextOptions<PasientContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public Microsoft.EntityFrameworkCore.DbSet<Pasient> Pasienter { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using RegistroPrioridad2.Models;

namespace RegistroPrioridad2.BLL
{
    public class Contexto: DbContext
    {
        public DbSet<Prioridad> prioridads { get; set; }

        public Contexto(DbContextOptions <Contexto> options): base(options)
        {
        }
    }
}

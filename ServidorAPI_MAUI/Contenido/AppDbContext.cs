using Microsoft.EntityFrameworkCore;
using ServidorAPI_MAUI.Models;

namespace ServidorAPI_MAUI.Contenido
{
    public class AppDbContext: DbContext

    {
        public DbSet<Plato> Platos => Set<Plato>();
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op)
        {  

        }
    }
}

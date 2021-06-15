using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Practica4.Models
{
    public class ImagenContext : IdentityDbContext
    {
        public DbSet<Imagen> Imagenes { get; set;}
        public DbSet<Comentario> Comentarios { get; set; }

        public ImagenContext(DbContextOptions dco) : base(dco) {
            
        }
    }
}
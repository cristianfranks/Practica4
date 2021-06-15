using System.Collections.Generic;

namespace Practica4.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Imagen> Imagenes{ get; set; }
    }
}
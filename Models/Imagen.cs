using System;
using System.ComponentModel.DataAnnotations;

namespace Practica4.Models
{
    public class Imagen
    {
        public int Id { get; set; }
        [Required]
          [Display(Name="Nombre de Usuario")]
        public string Nombre { get; set; }
          [Required]
        public string Foto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Comentario Comentario { get; set; }
        public int ComentarioId { get; set; }

        public Imagen(){
            FechaRegistro = DateTime.Now;
        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNetCore5.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50, ErrorMessage ="El campo {0} debe ser de al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        [Display(Name ="Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo fecha obligatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Precio { get; set; }

    }
}

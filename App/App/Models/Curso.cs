using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int idCurso { get; set; }

        [Display(Name = "Nombre del curso")]
        [Required(ErrorMessage = "El nombre del curso es requerido.")]
        public string nombreCurso { get; set;}

    }
}

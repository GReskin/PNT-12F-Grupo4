using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace App.Models
{
    public class Clase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClase { get; set; }

        [Display(Name = "Nombre de la Clase")]
        [Required(ErrorMessage = "Debe cargar el nombre de la clase!")]
        public String nombreClase { get; set; }

        [Display(Name = "Nombre del Curso")]
        [Required(ErrorMessage = "Debe cargar el nombre del curso!")]
        public int numeroClase { get; set; }


        [Display(Name = "Fecha de la clase")]
        [Required(ErrorMessage = "Debe cargar la fecha de la clase!")]
        public DateTime fechaClase { get; set; }

        [Display(Name = "Link de la clase")]
        [Required(ErrorMessage = "Debe cargar un link al video de la clase!")]
        public String linkVideo { get; set; }
        
        [Display(Name = "Nombre del Curso")]
        public int idCurso { get; set; }
        [ForeignKey("idCurso")]
        
        [Display(Name = "Nombre del Curso")]
        public virtual Curso ? curso { get; set; }

    }
}
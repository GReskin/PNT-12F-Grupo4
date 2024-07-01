using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace App.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe cargar el nombre del Usuario!")]
        public String nombreUsuario { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Debe cargar el email del Usuario")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email no es valido!")]
        public String emailUsuario { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Debe cargar la edad del Usuario")]
        [Range(0,120,ErrorMessage = "La edad no puede ser negativa!")]
        public int edadUsuario { get; set; }

        [Display(Name = "Nombre del Curso")]
        public int idCurso { get; set; }
        [ForeignKey("idCurso")]

        [Display(Name = "Nombre del Curso")]
        public virtual Curso? Curso { get; set; }

    }
}

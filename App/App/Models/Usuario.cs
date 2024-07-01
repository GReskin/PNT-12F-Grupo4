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
        public String nombreUsuario { get; set; }
        public String emailUsuario { get; set; }
        public int edadUsuario { get; set; }

        [Display(Name = "Id del Curso")]
        public int idCurso { get; set; }
        [ForeignKey("idCurso")]

        [Display(Name = "Nombre del Curso")]
        public virtual Curso? Curso { get; set; }

    }
}

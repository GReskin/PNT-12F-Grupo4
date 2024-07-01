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
        public String nombreClase { get; set; }
        public int numeroClase { get; set; }

        public String linkVideo { get; set; }
        
        [Display(Name = "Id del Curso")]
        public int idCurso { get; set; }
        [ForeignKey("idCurso")]
        
        [Display(Name = "Nombre del Curso")]
        public virtual Curso ? curso { get; set; }

    }
}
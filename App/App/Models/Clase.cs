using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using App.Validators;

namespace App.Models
{

    

    public class Clase
    {


        [Display(Name = "Nombre de la Clase")]
        [Required(ErrorMessage = "Debe cargar el nombre de la clase!")]
        public String nombreClase { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClase { get; set; }



        [Display(Name = "Fecha de la clase")]
        [Required(ErrorMessage = "Debe cargar la fecha de la clase!")]
        [FechaValidator]
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
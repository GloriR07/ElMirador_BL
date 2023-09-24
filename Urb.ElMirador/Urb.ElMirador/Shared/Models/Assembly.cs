using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Urb.ElMirador.Shared.Models;
public class Assembly
{
    [Key] //establece que el Id es una clave primaria (se pone encima del que se desea establecer)
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "Codigo Identificador Asamblea")] //le muestra al usuario en pantalla 
    [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]//es el valor de la propiedad y el 1 es el valor de la condicion o parametro
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public int Id_Assembly { get; set; }

    [Display(Name = "Fecha Asamblea")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string CreatedDate { get; set; }

    [Display(Name = "Hora Asamblea")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string CreatedTime { get; set; }

    [Display(Name = "Lugar Asamblea")]
    [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string Place { get; set; }

    [Display(Name = "Agenda Asamblea")]
    [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string Diary { get; set; }
}


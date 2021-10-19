// using System.ComponentModel.Annotations;

namespace ExitoLogGames.App.Dominio
{
    public class Employ : Login
    {
        public int Id {get;set;}
        // [Required, MinLength(3, ErrorMessage = "El {0} debe tener mínimo {0} caracteres.")]
        public string Nombre{get;set;}
        // [Required, MinLength(3, ErrorMessage = "El {0} debe tener mínimo {0} caracteres.")]

        public string Apellido{get;set;}
        // [Required, MinLength(6, ErrorMessage = "El {0} debe tener mínimo {0} caracteres."), MinLength(14, ErrorMessage = "El {0} debe tener máximo {0} caracteres.")]
        public string Cedula{get;set;}
        // [Required]
        public string Sucursal{get;set;}
        // [Required]
        public string Cargo{get;set;}
    }
}
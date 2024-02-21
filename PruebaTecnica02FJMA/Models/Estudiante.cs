using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica02FJMA.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; } = null!;
        public byte[]? Imagen { get; set; }
        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; } = null!;
    }
}

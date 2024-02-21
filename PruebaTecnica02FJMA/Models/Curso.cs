namespace PruebaTecnica02FJMA.Models
{
    public partial class Curso
    {

        public Curso()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int CursoId { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Estudiante> Estudiantes { get; set; }

    }
}

namespace Catalogo_Cursos_Tarea4.Models;

public class Curso
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;

    public string Instructor { get; set; } = string.Empty;

    public int DuracionHoras { get; set; }

    public string Nivel { get; set; } = string.Empty;
}

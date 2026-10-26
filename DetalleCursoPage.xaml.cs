
using Catalogo_Cursos_Tarea4.Models;

namespace Catalogo_Cursos_Tarea4;

[QueryProperty(nameof(CursoId), "Id")]
public partial class DetalleCursoPage : ContentPage
{
    private int _cursoId;

    public string CursoId
    {
        get => _cursoId.ToString();

        set
        {
            if (int.TryParse(value, out int id))
            {
                _cursoId = id;
                CargarCurso();
            }
        }
    }

    private Curso? _curso;

    public DetalleCursoPage()
    {
        InitializeComponent();
    }

    private void CargarCurso()
    {
        _curso = CursosRepositorio.Cursos
            .FirstOrDefault(c => c.Id == _cursoId);

        if (_curso is null)
            return;

        NombreLabel.Text = _curso.Nombre;
        DescripcionLabel.Text = _curso.Descripcion;
        InstructorLabel.Text = _curso.Instructor;
        DuracionLabel.Text = $"Duración: {_curso.DuracionHoras} horas";
        NivelLabel.Text = $"Nivel: {_curso.Nivel}";
    }

    private async void OnEditarClicked(object? sender, EventArgs e)
    {
        if (_curso is null)
            return;

        var parametros = new Dictionary<string, object>
        {
            ["CursoSeleccionado"] = _curso
        };

        await Shell.Current.GoToAsync(
            nameof(EditarCursoPage), parametros);
    }

    private async void OnRegresarClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}

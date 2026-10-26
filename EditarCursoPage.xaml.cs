
using Catalogo_Cursos_Tarea4.Models;

namespace Catalogo_Cursos_Tarea4;

[QueryProperty(nameof(CursoSeleccionado), "CursoSeleccionado")]
public partial class EditarCursoPage : ContentPage
{
    private Curso? _cursoSeleccionado;

    public Curso? CursoSeleccionado
    {
        get => _cursoSeleccionado;
        set
        {
            _cursoSeleccionado = value;

            if (_cursoSeleccionado is not null)
                CargarDatos();
        }
    }

    public EditarCursoPage()
    {
        InitializeComponent();
    }

    private void CargarDatos()
    {
        if (_cursoSeleccionado is null)
            return;

        NombreEntry.Text = _cursoSeleccionado.Nombre;
        DescripcionEditor.Text = _cursoSeleccionado.Descripcion;
        InstructorEntry.Text = _cursoSeleccionado.Instructor;
        DuracionEntry.Text = _cursoSeleccionado.DuracionHoras.ToString();

        NivelPicker.SelectedItem = _cursoSeleccionado.Nivel;
    }

    private async void OnGuardarClicked(object? sender, EventArgs e)
    {
        if (_cursoSeleccionado is null)
            return;

        if (string.IsNullOrWhiteSpace(NombreEntry.Text))
        {
            await DisplayAlertAsync(
                "Validación",
                "Escribe el nombre del curso.",
                "Aceptar");
            return;
        }

        if (!int.TryParse(DuracionEntry.Text, out int duracion) ||
            duracion <= 0)
        {
            await DisplayAlertAsync(
                "Validación",
                "Ingresa una duración válida mayor que cero.",
                "Aceptar");
            return;
        }

        _cursoSeleccionado.Nombre = NombreEntry.Text.Trim();
        _cursoSeleccionado.Descripcion =
            DescripcionEditor.Text?.Trim() ?? string.Empty;
        _cursoSeleccionado.Instructor =
            InstructorEntry.Text?.Trim() ?? string.Empty;
        _cursoSeleccionado.DuracionHoras = duracion;
        _cursoSeleccionado.Nivel =
            NivelPicker.SelectedItem?.ToString() ?? "Principiante";

        await DisplayAlertAsync(
            "Éxito",
            "El curso se actualizó correctamente.",
            "Aceptar");

        await Shell.Current.GoToAsync("..");
    }

    private async void OnCancelarClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}

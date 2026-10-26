
using Catalogo_Cursos_Tarea4.Models;

namespace Catalogo_Cursos_Tarea4;

public partial class CursosPage : ContentPage
{
    public CursosPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ListaCursos.ItemsSource = null;
        ListaCursos.ItemsSource = CursosRepositorio.Cursos;
    }

    private async void OnVerDetalleClicked(object? sender, EventArgs e)
    {
        if (sender is Button boton && boton.CommandParameter is int id)
        {
            await Shell.Current.GoToAsync(
                $"{nameof(DetalleCursoPage)}?Id={id}");
        }
    }

    private async void OnEditarCursoClicked(object? sender, EventArgs e)
    {
        if (sender is Button boton &&
            boton.CommandParameter is Curso curso)
        {
            var parametros = new Dictionary<string, object>
            {
                ["CursoSeleccionado"] = curso
            };

            await Shell.Current.GoToAsync(
                nameof(EditarCursoPage), parametros);
        }
    }
}

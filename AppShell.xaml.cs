
namespace Catalogo_Cursos_Tarea4;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            nameof(DetalleCursoPage),
            typeof(DetalleCursoPage));

        Routing.RegisterRoute(
            nameof(EditarCursoPage),
            typeof(EditarCursoPage));

    }

    private async void OnAcercaDeClicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync(
            "Acerca de",
            "Catálogo de Cursos\nAplicación desarrollada con .NET MAUI y Shell " +
            "por el Grupo N°3 de la clase de Programacion de Dispositivos Móviles II.",
            "Aceptar");
    }

    private async void OnSalirClicked(object? sender, EventArgs e)
    {
        bool salir = await DisplayAlertAsync(
            "Salir",
            "¿Deseas salir de la aplicación?",
            "Sí",
            "No");

        if (salir)
        {
            Application.Current?.Quit();
        }
    }
}

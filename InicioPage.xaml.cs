
namespace Catalogo_Cursos_Tarea4;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    private async void OnExplorarCursosClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Principal/CursosPage");
    }
}

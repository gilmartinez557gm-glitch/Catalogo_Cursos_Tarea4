
namespace Catalogo_Cursos_Tarea4;

public partial class PerfilPage : ContentPage
{
    public PerfilPage()
    {
        InitializeComponent();

        TemaPicker.SelectedIndex = Application.Current?.UserAppTheme switch
        {
            AppTheme.Light => 1,
            AppTheme.Dark => 2,
            _ => 0
        };
    }

    private void OnTemaChanged(object? sender, EventArgs e)
    {
        if (TemaPicker.SelectedIndex == 0)
        {
            Application.Current!.UserAppTheme = AppTheme.Unspecified;
        }
        else if (TemaPicker.SelectedIndex == 1)
        {
            Application.Current!.UserAppTheme = AppTheme.Light;
        }
        else if (TemaPicker.SelectedIndex == 2)
        {
            Application.Current!.UserAppTheme = AppTheme.Dark;
        }
    }

    private async void OnGuardarPerfilClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NombrePerfilEntry.Text))
        {
            await DisplayAlertAsync(
                "Validación",
                "Escribe tu nombre antes de guardar.",
                "Aceptar");
            return;
        }

        await DisplayAlertAsync(
            "Perfil",
            $"Nombre registrado: {NombrePerfilEntry.Text.Trim()}",
            "Aceptar");
    }
}

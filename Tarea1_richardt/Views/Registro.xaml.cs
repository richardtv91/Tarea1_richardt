namespace Tarea1_richardt.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}
	private async void btnGuardar_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsuario.Text;
		string contrase�a = txtContrase�a.Text;
        await Navigation.PushAsync(new Views.Login(usuario, contrase�a));
       // Navigation.PushModalAsync(new Views.Login(usuario, contrase�a));
	}
}
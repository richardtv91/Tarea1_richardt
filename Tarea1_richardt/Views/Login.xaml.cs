namespace Tarea1_richardt.Views;

public partial class Login : ContentPage
{
	private string[] user = { "carlos", "ana", "jose" };
	private string[] password = { "carlos123", "ana123", "jose123" };
	public Login()
	{
		InitializeComponent();
	}
	public Login(string usuario, string contrase�a)
	{
		InitializeComponent();
	}
	private async void btnIniciar_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsuario.Text;
		string contrase�a = txtContrase�a.Text;
		int index = Array.IndexOf(user, usuario);
		if (index >= 0 && password[index] == contrase�a)
		{
            _ = DisplayAlert("Bienvenido", $"Hola,{usuario}!", "Cerrar");
			//Navigation.PushModalAsync(new Views.Home());
			await Navigation.PushAsync(new Views.Home());



		}
		else {
            _ = DisplayAlert("Error", "Usuario o Contrase�a incorrectos", "cerrar");
		}

	}
	private async void btnRegistrase_Clicked(object sender, EventArgs e)
	{
		//Navigation.PushModalAsync(new Views.Registro());
        await Navigation.PushAsync(new Views.Registro());
    }
}
namespace Tarea1_richardt.Views;

public partial class Login : ContentPage
{
	private string[] user = { "xavier", "diana", "carolina" };
	private string[] password = { "1234as", "123qw", "diana12" };
	public Login()
	{
		InitializeComponent();
	}
	public Login(string usuario, string contrase�a)
	{
		InitializeComponent();
	}
	private void btnIniciar_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsuario.Text;
		string contrase�a = txtContrase�a.Text;
		int index = Array.IndexOf(user, usuario);
		if (index >= 0 && password[index] == contrase�a)
		{
			DisplayAlert("Bienvenido", $"Hola,{usuario}!", "Cerrar");
			Navigation.PushAsync(new Views.Home());

		}
		else {
			DisplayAlert("Error", "Usuario o Contrase�a incorrectos", "cerrar");
		}

	}
	private void btnRegistrase_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Views.Registro());
	}
}
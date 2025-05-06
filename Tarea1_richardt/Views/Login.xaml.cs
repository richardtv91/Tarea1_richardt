namespace Tarea1_richardt.Views;

public partial class Login : ContentPage
{
	private string[] user = { "carlos", "ana", "jose" };
	private string[] password = { "carlos123", "ana123", "jose123" };
	public Login()
	{
		InitializeComponent();
	}
	public Login(string usuario, string contraseña)
	{
		InitializeComponent();
	}
	private void btnIniciar_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsuario.Text;
		string contraseña = txtContraseña.Text;
		int index = Array.IndexOf(user, usuario);
		if (index >= 0 && password[index] == contraseña)
		{
			DisplayAlert("Bienvenido", $"Hola,{usuario}!", "Cerrar");
			Navigation.PushModalAsync(new Views.Home());

		}
		else {
			DisplayAlert("Error", "Usuario o Contraseña incorrectos", "cerrar");
		}

	}
	private void btnRegistrase_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Views.Registro());
	}
}
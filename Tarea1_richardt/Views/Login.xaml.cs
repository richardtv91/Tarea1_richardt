namespace Tarea1_richardt.Views;

public partial class Login : ContentPage
{
	private string[] user = { "xavier", "diana", "carolina" };
	private string[] password = { "1234as", "123qw", "diana12" };
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
			Navigation.PushAsync(new Views.Home());

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
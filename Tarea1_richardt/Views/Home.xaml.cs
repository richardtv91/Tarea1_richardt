namespace Tarea1_richardt.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
	public void NotaClicked(object sender, EventArgs e)
	{
		if (double.TryParse(txtSeguimiento1.Text, out double seguimiento) &&
			double.TryParse(txtExamen1.Text, out double examen1) &&
			double.TryParse(txtSeguimiento2.Text, out double seguimiento2) &&
			double.TryParse(txtExamen2.Text, out double examen2))

		{
			if (IsValid(seguimiento) &&
				IsValid(examen1) &&
				IsValid(seguimiento2) &&
				IsValid(examen2))
			{
				double par1 = (seguimiento * 0.3) + (examen1 * 0.2);
				double par2 = (seguimiento2 * 0.3) + (examen2 * 0.2);
				double notaFinal = par1 + par2;
				string estado = GetEstado(notaFinal);
				string fecha = dFechas.Date.ToString("d");
				string message = $"Su nota 1:{seguimiento}\n" +
					$"Su examen 1:{examen1}\n" +
					$"Su nota 2:{seguimiento2}n" +
					$"Su examen 2:{examen2}\n" +
					$"Su nota final es:{notaFinal:f2}\n" +
					$"Estado:{estado}\n" +
					$"Fecha:{fecha}\n";
				DisplayAlert("Alert", message, "Cerrar");
				ResultadoLab.Text = $"Nota Final:{notaFinal:f2}-Estado: {estado}";



			}
			else
			{
				DisplayAlert("Error", "Las notas no estan entre el rango permitido de 0,10 ingresar nuevamente:", "OK");
			}
		}
		else
		{
			DisplayAlert("Error", "Por favor ingrese valores numericos validos", "OK");
		}
	}

	private bool IsValid(double value)
	{
		return value >= 0 && value <= 10;
	}
	private string GetEstado(double notaFinal)
	{
		if (notaFinal>=7) 
			return "Aprobado";
			else if (notaFinal >= 5 && notaFinal < 7)
				return "Complementario";
			else
			
				return "Reprobado";
	}
	

	
}
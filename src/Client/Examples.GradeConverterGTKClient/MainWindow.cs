using System;
using Gtk;
using System.ServiceModel;
using Samples.GradeConverterService;

public partial class MainWindow: Gtk.Window
{
	ChannelFactory<IGradeConverter> factory = null;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnConvertClicked (object sender, EventArgs e)
	{
		if (txtGrades.Text.Length > 0) {
			var grades = Convert.ToDouble (txtGrades.Text);
			try {
				BasicHttpBinding binding = new BasicHttpBinding();
				EndpointAddress address = new EndpointAddress("http://localhost:5388");
				factory = new ChannelFactory<IGradeConverter>(binding,address);
				IGradeConverter channel = factory.CreateChannel();
				if(rbCelsius.Active)
				{
					txtCelsius.Text = txtGrades.Text;
					txtFahrenheit.Text = channel.CelsiusToFahrenheit(grades).ToString();
					txtKelvin.Text = channel.CelsiusToKelvin(grades).ToString();
				}
				if(rbFarehnheit.Active)
				{
					txtFahrenheit.Text = txtGrades.Text;
					txtCelsius.Text = channel.FahrenheitToCelsius(grades).ToString();
					txtKelvin.Text = channel.FahrenheitToKelvin(grades).ToString();
				}
				if(rbKelvin.Active)
				{
					txtKelvin.Text = txtGrades.Text;
					txtCelsius.Text = channel.CelsiusToKelvin(grades).ToString();
					txtFahrenheit.Text = channel.FahrenheitToKelvin(grades).ToString();
				}
			} catch (CommunicationException commEx) {
				AbortCommunication();
				lbMessage.Text = "Communication error: " + commEx.Message;
			}
			catch(TimeoutException timeEx){
				AbortCommunication ();
				lbMessage.Text = "TimeOut error: " + timeEx.Message;
			}
			catch(Exception ex){
				AbortCommunication ();
				lbMessage.Text = "Exception error: " + ex.Message;
			}
		} else
			lbMessage.Text = "Grades is empty";
	}

	void AbortCommunication()
	{
		if (factory != null)
			factory.Abort ();
	}
}

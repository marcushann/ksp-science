using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnButton30Clicked (object sender, EventArgs e)
	{
	    Window deltav = new kspscience.Delta_V ();
		deltav.Show ();
	}
}

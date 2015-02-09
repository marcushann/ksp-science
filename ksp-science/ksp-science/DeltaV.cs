using System;

namespace kspscience
{
	public partial class Delta_V : Gtk.Window
	{
		public Delta_V () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton13Clicked (object sender, EventArgs e)
		{
			//Collect all values
			double starting = spinbutton1.Value;
			double finishing = spinbutton2.Value;
			double specificImpulse = spinbutton3.Value;

			//Check all values
			if(starting == 0 || finishing == 0 || specificImpulse == 0){
				//If any values are zero, abort
				return;
			}
		}
	}
}


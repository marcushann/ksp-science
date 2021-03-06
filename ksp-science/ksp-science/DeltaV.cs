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

			//Calculate Delta-V
			double deltav = Math.Log (starting / finishing) * (specificImpulse * 9.81);

			//Write answer to the answer box
			entry1.Text = deltav.ToString();

			//display calculation in the text view
			textview1.Buffer.Text = "ln(" + starting.ToString() + " / " + finishing.ToString() + ") * (" + specificImpulse.ToString() + " * 9.81) = " + deltav.ToString() + "";
		}
	}
}


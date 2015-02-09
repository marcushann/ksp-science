using System;

namespace kspscience
{
	public partial class DeltaV : Gtk.Window
	{
		public DeltaV () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}


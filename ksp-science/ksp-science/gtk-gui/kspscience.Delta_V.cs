
// This file has been generated by the GUI designer. Do not modify.
namespace kspscience
{
	public partial class Delta_V
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label1;
		private global::Gtk.SpinButton spinbutton1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label2;
		private global::Gtk.SpinButton spinbutton2;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label3;
		private global::Gtk.SpinButton spinbutton3;
		private global::Gtk.Button button13;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textview1;
		private global::Gtk.Entry entry1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget kspscience.Delta_V
			this.Name = "kspscience.Delta_V";
			this.Title = global::Mono.Unix.Catalog.GetString ("DeltaV");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child kspscience.Delta_V.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Starting Mass:");
			this.vbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.spinbutton1 = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbutton1.WidthRequest = 140;
			this.spinbutton1.CanFocus = true;
			this.spinbutton1.Name = "spinbutton1";
			this.spinbutton1.Adjustment.PageIncrement = 10;
			this.spinbutton1.ClimbRate = 1;
			this.spinbutton1.Numeric = true;
			this.vbox3.Add (this.spinbutton1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.spinbutton1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("End Mass:");
			this.vbox4.Add (this.label2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.spinbutton2 = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbutton2.WidthRequest = 140;
			this.spinbutton2.CanFocus = true;
			this.spinbutton2.Name = "spinbutton2";
			this.spinbutton2.Adjustment.PageIncrement = 10;
			this.spinbutton2.ClimbRate = 1;
			this.spinbutton2.Numeric = true;
			this.vbox4.Add (this.spinbutton2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.spinbutton2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox4]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Isp of engine (in seconds)");
			this.vbox5.Add (this.label3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label3]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.spinbutton3 = new global::Gtk.SpinButton (0, 100, 1);
			this.spinbutton3.WidthRequest = 140;
			this.spinbutton3.CanFocus = true;
			this.spinbutton3.Name = "spinbutton3";
			this.spinbutton3.Adjustment.PageIncrement = 10;
			this.spinbutton3.ClimbRate = 1;
			this.spinbutton3.Numeric = true;
			this.vbox5.Add (this.spinbutton3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.spinbutton3]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox5]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button13 = new global::Gtk.Button ();
			this.button13.WidthRequest = 140;
			this.button13.CanFocus = true;
			this.button13.Name = "button13";
			this.button13.UseUnderline = true;
			this.button13.Label = global::Mono.Unix.Catalog.GetString ("Calculate");
			this.hbox1.Add (this.button13);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button13]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.Editable = false;
			this.GtkScrolledWindow.Add (this.textview1);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w13.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = false;
			this.entry1.InvisibleChar = '•';
			this.vbox2.Add (this.entry1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.entry1]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 693;
			this.DefaultHeight = 428;
			this.Show ();
			this.button13.Clicked += new global::System.EventHandler (this.OnButton13Clicked);
		}
	}
}

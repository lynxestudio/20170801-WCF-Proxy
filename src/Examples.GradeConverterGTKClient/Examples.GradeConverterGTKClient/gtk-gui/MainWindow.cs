
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox mainLayout;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.RadioButton rbCelsius;
	
	private global::Gtk.RadioButton rbFarehnheit;
	
	private global::Gtk.RadioButton rbKelvin;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Entry txtGrades;
	
	private global::Gtk.Button btnConvert;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Entry txtCelsius;
	
	private global::Gtk.Entry txtFahrenheit;
	
	private global::Gtk.Entry txtKelvin;
	
	private global::Gtk.Label lbMessage;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("GTK Temperature converter");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainLayout = new global::Gtk.VBox ();
		this.mainLayout.Name = "mainLayout";
		this.mainLayout.Spacing = 6;
		this.mainLayout.BorderWidth = ((uint)(8));
		// Container child mainLayout.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Temperature convert");
		this.mainLayout.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.mainLayout [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child mainLayout.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Homogeneous = true;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rbCelsius = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Celsius"));
		this.rbCelsius.CanFocus = true;
		this.rbCelsius.Name = "rbCelsius";
		this.rbCelsius.DrawIndicator = true;
		this.rbCelsius.UseUnderline = true;
		this.rbCelsius.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.hbox1.Add (this.rbCelsius);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.rbCelsius]));
		w2.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rbFarehnheit = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Farehnheit"));
		this.rbFarehnheit.CanFocus = true;
		this.rbFarehnheit.Name = "rbFarehnheit";
		this.rbFarehnheit.DrawIndicator = true;
		this.rbFarehnheit.UseUnderline = true;
		this.rbFarehnheit.Group = this.rbCelsius.Group;
		this.hbox1.Add (this.rbFarehnheit);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.rbFarehnheit]));
		w3.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rbKelvin = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Kelvin"));
		this.rbKelvin.CanFocus = true;
		this.rbKelvin.Name = "rbKelvin";
		this.rbKelvin.DrawIndicator = true;
		this.rbKelvin.UseUnderline = true;
		this.rbKelvin.Group = this.rbCelsius.Group;
		this.hbox1.Add (this.rbKelvin);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.rbKelvin]));
		w4.Position = 2;
		this.mainLayout.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.mainLayout [this.hbox1]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child mainLayout.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Homogeneous = true;
		this.hbox2.Spacing = 2;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtGrades = new global::Gtk.Entry ();
		this.txtGrades.CanFocus = true;
		this.txtGrades.Name = "txtGrades";
		this.txtGrades.IsEditable = true;
		this.txtGrades.InvisibleChar = '•';
		this.hbox2.Add (this.txtGrades);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtGrades]));
		w6.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnConvert = new global::Gtk.Button ();
		this.btnConvert.CanFocus = true;
		this.btnConvert.Name = "btnConvert";
		this.btnConvert.UseStock = true;
		this.btnConvert.UseUnderline = true;
		this.btnConvert.Label = "gtk-ok";
		this.hbox2.Add (this.btnConvert);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.btnConvert]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		this.mainLayout.Add (this.hbox2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.mainLayout [this.hbox2]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child mainLayout.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), true);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(2));
		this.table1.ColumnSpacing = ((uint)(2));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Celsius");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Fahrenheit");
		this.table1.Add (this.label3);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Kelvin");
		this.table1.Add (this.label4);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
		w11.TopAttach = ((uint)(2));
		w11.BottomAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtCelsius = new global::Gtk.Entry ();
		this.txtCelsius.CanFocus = true;
		this.txtCelsius.Name = "txtCelsius";
		this.txtCelsius.IsEditable = true;
		this.txtCelsius.InvisibleChar = '•';
		this.table1.Add (this.txtCelsius);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtCelsius]));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtFahrenheit = new global::Gtk.Entry ();
		this.txtFahrenheit.CanFocus = true;
		this.txtFahrenheit.Name = "txtFahrenheit";
		this.txtFahrenheit.IsEditable = true;
		this.txtFahrenheit.InvisibleChar = '•';
		this.table1.Add (this.txtFahrenheit);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtFahrenheit]));
		w13.TopAttach = ((uint)(1));
		w13.BottomAttach = ((uint)(2));
		w13.LeftAttach = ((uint)(1));
		w13.RightAttach = ((uint)(2));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.txtKelvin = new global::Gtk.Entry ();
		this.txtKelvin.CanFocus = true;
		this.txtKelvin.Name = "txtKelvin";
		this.txtKelvin.IsEditable = true;
		this.txtKelvin.InvisibleChar = '•';
		this.table1.Add (this.txtKelvin);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.txtKelvin]));
		w14.TopAttach = ((uint)(2));
		w14.BottomAttach = ((uint)(3));
		w14.LeftAttach = ((uint)(1));
		w14.RightAttach = ((uint)(2));
		w14.YOptions = ((global::Gtk.AttachOptions)(4));
		this.mainLayout.Add (this.table1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.mainLayout [this.table1]));
		w15.Position = 3;
		w15.Expand = false;
		w15.Fill = false;
		// Container child mainLayout.Gtk.Box+BoxChild
		this.lbMessage = new global::Gtk.Label ();
		this.lbMessage.Name = "lbMessage";
		this.lbMessage.LabelProp = global::Mono.Unix.Catalog.GetString ("Running");
		this.mainLayout.Add (this.lbMessage);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.mainLayout [this.lbMessage]));
		w16.PackType = ((global::Gtk.PackType)(1));
		w16.Position = 4;
		w16.Expand = false;
		w16.Fill = false;
		this.Add (this.mainLayout);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 186;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnConvert.Clicked += new global::System.EventHandler (this.OnBtnConvertClicked);
	}
}

using System;
using Gtk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;
using Application = Gtk.Application;

namespace GTKTest.GTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            Forms.Init();


            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("GTK TEST");
            window.Show();

            Application.Run();
        }
    }
}

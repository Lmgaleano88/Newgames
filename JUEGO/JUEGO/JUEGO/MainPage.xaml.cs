using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JUEGO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Crear.Clicked += crear_Clicked;
            incio.Clicked += inicio_Clicked;
        }

        private void crear_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new registro());
        }
        private void inicio_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Inicio());
        }
    }
}

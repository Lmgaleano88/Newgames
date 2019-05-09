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

            incio.Clicked += incio_Clicked;
            Crear.Clicked += crear_Clicked;
           
        }
        private void incio_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Inicio());
        }
        private void crear_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new registro());
        }


    }
}

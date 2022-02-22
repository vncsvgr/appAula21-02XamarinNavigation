using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appAula21_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnProxima_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina02());
        }
    }
}

using System;
using System.Collections.Generic;
using PokedexNET;
using Xamarin.Forms;

namespace MultiscreenXamarin
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Pokemon pokemon)
        {
            InitializeComponent();
            var pokedex = new Pokedex();
            var info = pokedex.GetPokemonInfo(pokemon);
            imgDetail.Source = pokemon.ImageUrl;
            lblNamePokemon.Text = pokemon.Name;
            lblWeight.Text = info.WeightEu;
            lblHeight.Text = info.HeightEu;
            lblDetail.Text = info.PokedexEntries.OmegaRuby.En;
            this.Title = "Info Pokemon";
            //var navigationPage = Application.Current.MainPage as NavigationPage;
            //navigationPage.BarBackgroundColor = Color.White;
            //navigationPage.BarTextColor = Color.Blue;
            //navigationPage.BarTextColor = Color.Blue;
            //navigationPage.bac
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var url = "https://www.youtube.com";
            Device.OpenUri(new Uri(url));
        }
    }
}

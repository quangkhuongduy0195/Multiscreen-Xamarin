using PokedexNET;
using Xamarin.Forms;

namespace MultiscreenXamarin
{
    public partial class MultiscreenXamarinPage : ContentPage
    {

        private Pokedex _pokedex;
        private Pokemon pokemon;
        public MultiscreenXamarinPage()
        {
            InitializeComponent();
            //var navigationPage = Application.Current.MainPage as NavigationPage;
            //navigationPage.BarBackgroundColor = Color.Gray;
            //navigationPage.BarTextColor = Color.White;
            //navigationPage.BarTextColor = Color.White;
            this.Title = "Find Pokemon";
            NavigationPage.SetBackButtonTitle(this, "");
            _pokedex = new Pokedex();

        }

        void ButtonFind_Clicked(object sender, System.EventArgs e)
        {
            var textNumber = txtNumberPokemon.Text;
            if (textNumber != null && textNumber.Length > 0)
            {
                int number = int.Parse(textNumber);
                pokemon = _pokedex.GetPokemon(number);
                imgPokemon.Source = pokemon.ImageUrl;
                lblName.Text = pokemon.Name;
            }
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (pokemon != null)
            {
                Navigation.PushAsync(new DetailPage(pokemon));
            }
        }
    }
}

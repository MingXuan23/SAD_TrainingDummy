using Org.W3c.Dom;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Training17122025.models;

namespace Training17122025
{
    public partial class MainPage : ContentPage
    {

        public List<game> list = new List<game>();

        public MainPage()
        {
            InitializeComponent();
            //loaddata();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            loaddata();

        }
        public async void loaddata()
        {

            await Task.Delay(500);
            list = await helper.get<List<game>>("games")
                ?? new List<game>();


            //list = await helper.get<List<Dictionary<string, JsonElement>>>("games")
            //    ?? new List<Dictionary<string, JsonElement>>();

            gamelist.ItemsSource = null;
            gamelist.ItemsSource = list;
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            var item = (sender as Border).BindingContext as game;

            Navigation.PushAsync(new gamepage(item));

            //xml take longer time, 2 side , do data binding

            //cs faster, action , databinding will be problem
            //like flutter, go to learn kotlin jetpack compose (android studio)

            //Navigation.PushAsync(new NewPage1());
        }
    }
}

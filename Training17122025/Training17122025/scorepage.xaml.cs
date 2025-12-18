using Android.App;
using System.Text.Json;
using System.Threading.Tasks;

namespace Training17122025;

public partial class scorepage : ContentPage
{
    decimal point { get; set; }
    int gameId { get; set; }
    public scorepage(decimal point, int gameId)
    {
        InitializeComponent();
        this.point = point;
        this.gameId = gameId;

        score.Text = point.ToString("0");
        loadlist();
    }

    public async void loadlist()
    {
        var list = await helper.get<List<Dictionary<string, JsonElement>>>($"leaderboards/{gameId}");

        list = list.OrderByDescending(x => x["totalPoint"].GetInt32()).ToList();

        var i = 1;

        list.ForEach(x => x.Add("ranking", JsonSerializer.SerializeToElement(i++)));

        itemlist.ItemsSource = null;
        itemlist.ItemsSource = list;
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(nicknametxt.Text))
        {
            DisplayAlert("Alert", "Please provide nick name", "OK");
            return;
        }

        var req = await helper.postres("leaderboards", new { gameID = gameId, nickname = nicknametxt.Text, totalPoint = point });
        if (req == 200)
        {
            DisplayAlert("Alert", "Success to save", "OK");

            scoresec.IsEnabled = false;

            loadlist();
        }
        else
        {
            DisplayAlert("Alert", "Error in saving score", "OK");

        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
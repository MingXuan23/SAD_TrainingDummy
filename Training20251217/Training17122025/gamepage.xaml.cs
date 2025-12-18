
using Microsoft.Maui.Animations;
using System.Text.Json;
using System.Threading.Tasks;
using Training17122025.models;

namespace Training17122025;

public partial class gamepage : ContentPage
{


    game game { get; set; }

    int index = 0;

    List<Dictionary<string, JsonElement>> words = new List<Dictionary<string, JsonElement>>();


    public gamepage(game game)
    {
        InitializeComponent();
        this.game = game;
        loaddata();
    }

    public async void loaddata()
    {
        words = await helper.get<List<Dictionary<string, JsonElement>>>($"words/{game.id}") ?? new();
        index = 0;

        loaditem();
    }


    public void loaditem()
    {
        prevbtn.IsEnabled = index > 0;
        nextbtn.Text = index == words.Count - 1 ? "FINISH" : "NEXT";
        var item = words[index];

        if (!item.TryGetValue("hint", out _))
        {
            var rand = new Random();
            var hint = string.Concat(item["word"].ToString().OrderBy(x => rand.Next()));
            item.Add("hint", JsonSerializer.SerializeToElement(hint));

            item.Add("answer", JsonSerializer.SerializeToElement(""));




        }
        var source = ImageSource.FromUri(new Uri($"http://10.0.2.2:5000/images/{item["image"]}"));
        image1.Source = null;
        image1.Source = source;

        image2.Source = null;
        image2.Source = item["image"].ToString();
        ;



        itemsec.BindingContext = null;
        itemsec.BindingContext = item;



    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        index--;
        index = Math.Max(0, Math.Min(words.Count - 1, index));
        loaditem();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(input.Text))
        {
            DisplayAlert("Alert", "Please provide the answer", "OK");
            return;
        }

        words[index]["answer"] = JsonSerializer.SerializeToElement(input.Text);

        if (index == words.Count - 1)
        {
            var points = words.Where(x => x["answer"].ToString() == x["word"].ToString()).Sum(x => x["point"].GetDecimal());

            Navigation.InsertPageBefore(new scorepage(points, game.id), this);
            Navigation.PopAsync();

        }
        index++;
        index = Math.Max(0, Math.Min(words.Count - 1, index));
        loaditem();


    }
}
namespace Training17122025;

public class NewPage1 : ContentPage
{
	public NewPage1()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!",
				
				},
                new Button {Text = "adadsa"}
            }
		};
	}
}
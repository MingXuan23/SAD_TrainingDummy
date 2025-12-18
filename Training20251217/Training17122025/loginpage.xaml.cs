namespace Training17122025;

public partial class loginpage : ContentPage
{
    public loginpage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(emailtxt.Text) || string.IsNullOrEmpty(passwordtxt.Text))
        {
            DisplayAlert("Alert", "Provide your email and password", "Ok");
            return;
        }
        bool loginsuccess = true;
        if (loginsuccess)
        {
            Application.Current.MainPage = new AppShell();
        }
    }
}
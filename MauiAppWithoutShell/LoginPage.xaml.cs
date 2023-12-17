namespace MauiAppWithoutShell;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
        Navigation.InsertPageBefore(new Page1(), this);
        await Navigation.PopAsync();
    }
}
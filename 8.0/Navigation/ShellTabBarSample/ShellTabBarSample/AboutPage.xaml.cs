namespace ShellTabBarSample;

public partial class AboutPage : ContentPage
{
	int count = 0;

	public AboutPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        await Launcher.Default.OpenAsync("https://w-2.de");
    }
}


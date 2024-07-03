namespace ShellTabBarSample;

public partial class AboutPage : ContentPage
{
	int count = 0;

	public AboutPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"About {count} time";
		else
			CounterBtn.Text = $"About {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


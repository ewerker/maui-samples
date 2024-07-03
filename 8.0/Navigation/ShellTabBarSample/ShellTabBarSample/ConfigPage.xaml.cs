namespace ShellTabBarSample;

public partial class ConfigPage : ContentPage
{
	int count = 0;

	public ConfigPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Config {count} time";
		else
			CounterBtn.Text = $"Config {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


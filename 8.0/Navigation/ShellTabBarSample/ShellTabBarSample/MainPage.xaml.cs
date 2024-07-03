namespace ShellTabBarSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	async public void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
        if (count>10) await DisplayAlert("ALERT", count.ToString(), "OK");
          
        
		if (count == 1)
			CounterBtn.Text = $"Main {count} time";
		else
			CounterBtn.Text = $"Main {count} times";
		    


        SemanticScreenReader.Announce(CounterBtn.Text);
        return;
    }

}


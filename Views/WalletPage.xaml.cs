namespace Crypto_NFT_UI.Views;

public partial class WalletPage : ContentPage
{
	public WalletPage()
	{
		InitializeComponent();
	}
	public async void back(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
    public async void home(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());

    }
}
namespace Crypto_NFT_UI.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    public async void navigation(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WalletPage());
    }
}
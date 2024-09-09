namespace Maui_Navigation_EventHandling_Task1;

public partial class GetProductPage : ContentPage
{
    public GetProductPage()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
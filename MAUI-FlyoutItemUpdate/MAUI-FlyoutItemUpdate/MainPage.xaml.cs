namespace MAUI_FlyoutItemUpdate;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage() { InitializeComponent(); }

    private void AddBtn_Clicked(object sender, EventArgs e)
    {
        Microsoft.Maui.Controls.ShellItem item = new Microsoft.Maui.Controls.ShellItem()
        {
            Title = "New Item",
            Route = "MainPage"
        };

        Shell.Current.Items.Add(this);
    }

    private void ShowBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.Items[2].IsEnabled = true;
        Shell.Current.Items[2].IsVisible = true;
        Shell.Current.Items[2].FlyoutItemIsVisible = true;
    }
}


namespace Mauiv2;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    // สร้าง Event Handler ให้ตรงกับ XAML
    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        ((Button)sender).Text = $"Clicked {count} times!";
    }
}


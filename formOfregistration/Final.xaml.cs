namespace formOfregistration;

public partial class Final : ContentPage
{
	public Final()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Application.Current.MainPage = new MainPage();
    }
}

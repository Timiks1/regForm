namespace formOfregistration;

public partial class Registr : ContentPage
{
	public Registr()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Application.Current.MainPage = new MainPage();
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        if(login.Text != null &&  password.Text != null)
        {

            string content = login.Text + "&&" + password.Text+"|";
            File.AppendAllText("/Users/tim/Desktop/s3/mat.txt",content);

        }
        else
        {
            if(login.Text == null)
            {
                login.BackgroundColor = Colors.Red;
            }
            if(password.Text == null)
            {
                password.BackgroundColor = Colors.Red;
            }
        }



    }
}

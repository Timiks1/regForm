namespace formOfregistration;

public partial class Vhod : ContentPage
{
	public Vhod()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Application.Current.MainPage = new MainPage();
    }
    List<string> users = new List<string>();
    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {


        if (login.Text != null && password.Text != null)
        {

            string text = File.ReadAllText("/Users/tim/Desktop/s3/mat.txt");
            string[] dannie = text.Split("|");
            users.Clear();
            foreach(string a in dannie)
            {
                string[] mass = a.Split("&&");
                foreach(string b in mass)
                {
                    users.Add(b);
                }
            }

        }
        else
        {
            if (login.Text == null)
            {
                login.BackgroundColor = Colors.Red;
            }
            if (password.Text == null)
            {
                password.BackgroundColor = Colors.Red;
            }
        }


        foreach(string a in users)
        {
            if(a == login.Text)
            {
                int b = users.IndexOf(a)+1;

                if (users[b] == password.Text)
                {
                    Application.Current.MainPage = new Final();
                }
                else
                {
                    password.BackgroundColor = Colors.Red;
                }
            }
        }







    }
}

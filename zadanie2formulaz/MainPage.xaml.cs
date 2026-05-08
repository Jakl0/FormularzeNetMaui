namespace zadanie2formulaz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        void abc123(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Eentry.Text) && !string.IsNullOrEmpty(Pentry.Text))
            {
                Buatoun.IsEnabled = true;
            }
            else
            {
                Buatoun.IsEnabled = false;
            }
        }
        void xyz678(object sender, EventArgs e)
        {
            DisplayAlert("Zalogowano", "😎😎😎", "👍👍👍");
        }
    }
}

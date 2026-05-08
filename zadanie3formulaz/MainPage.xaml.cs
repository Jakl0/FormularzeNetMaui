namespace zadanie3formulaz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void abc123(object sender , EventArgs e)
        {
            rejButton.IsEnabled = !(rejButton.IsEnabled);
        }
        void xyz567(object sender, EventArgs e)
        {
            DisplayAlert("Zarejestrowano", "😎😎😎", "👍👍👍");
        }
    }
}

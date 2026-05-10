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
/*
 **********************************************************************
nazwa          abc123
opis           zmienia dostępność do przycisku jeśli użytkownik akceptuje bądź nie akceptuje warunków użytkowania

parametry       object sender, EventArgs e
opis            sender: obiekt wywołujący funkcję , e : Szczegóły dotyczące wywołania funkcji

zwracany typ    brak

***********************************************************************
nazwa          xyz567
opis            informuje o pomyślnej rejestracji wysyłając alert

parametry       object sender, EventArgs e
opis            sender: obiekt wywołujący funkcję , e : Szczegóły dotyczące wywołania funkcji

zwracany typ    brak

*************************************************************************
 */

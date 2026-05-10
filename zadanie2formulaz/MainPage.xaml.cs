namespace zadanie2formulaz
{
    public partial class MainPage : ContentPage
    {

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
/*
 **********************************************************************
nazwa          abc123
opis            zamyka dostęp do przycisku jeśli przynajmniej jedno z pól będzie puste

parametry       object sender, EventArgs e
opis            sender: obiekt wywołujący funkcję , e : Szczegóły dotyczące wywołania funkcji

zwracany typ    brak

***********************************************************************
nazwa          xyz678
opis            wyświetla na ekranie Alert o pomyślnym zalogowaniu

parametry       object sender, EventArgs e
opis            sender: obiekt wywołujący funkcję , e : Szczegóły dotyczące wywołania funkcji

zwracany typ    brak

***********************************************************************

*
 */

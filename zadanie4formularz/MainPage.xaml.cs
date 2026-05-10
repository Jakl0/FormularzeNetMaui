namespace zadanie4formularz
{
    public partial class MainPage : ContentPage
    {
        List<string> poziomy1  = new List<string> {"Niski","Średni","Wysoki" };
        List<string> poziomy2 = new List<string> { "Niski", "Średni" };

        List<string> Tematy = new List<string> {"Reklamacja","Podziękowanie","Pytanie","Inne" };

        string priorytet,title;
        
        public MainPage()
        {
            InitializeComponent();
            tematPicker.ItemsSource = Tematy;
            priorPicker.ItemsSource = poziomy1;
        }
        public void tematchanged(object sender, EventArgs e)
        {
            priorPicker.IsEnabled = true;
            var picker = (Picker)sender;
            title = (string)picker.SelectedItem;
            if (title == "Reklamacja")
            {
                priorPicker.ItemsSource = poziomy1;
            }
            else if (title=="Pytanie")
            {
                priorPicker.ItemsSource = poziomy2;
            }
            else
            {
                priorytet = "Domyślny";
                priorPicker.IsEnabled = false;
            }
        }
        public void priorytetchanged(object sender , EventArgs e)
        {
            var picker = (Picker)sender;
            priorytet = (string)picker.SelectedItem;

        }
        public void OnMessageClicked(object sender,EventArgs e)
        {
            string kopiamessage;
            bool kopia = copyCheckbox.IsChecked;
            if (kopia) kopiamessage = "Tak";
            else kopiamessage = "Nie";
                string message = $" {nameEntry.Text} \n {mailEntry.Text} \n Wysłać kopię na email:{kopiamessage}\n Temat: {title}    priorytet: {priorytet} ";
            DisplayAlert("Wiadomość wysłana pomyślnie",message, "Ok");
        }
        
    }
}

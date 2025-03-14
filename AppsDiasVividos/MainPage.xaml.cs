namespace AppsDiasVividos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnCalcularDiasOnClicked(object sender, EventArgs e) 
        {
            int diasVividos = 0;

            diasVividos = int.Parse(etrIdade.Text) * 365;

            etrDiasVividos.Text = diasVividos.ToString();

            DisplayAlert("APP DIAS VIVIDOS", "Você já viveu " + etrDiasVividos.Text + " dias", "OK");
        }

        private void btnLimparOncliked(object sender, EventArgs e)
        {
            etrIdade.Text = "";
            etrDiasVividos.Text = "";
        }
    }

}

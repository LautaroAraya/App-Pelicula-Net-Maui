namespace AppPelicula
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void AlPresionarBoton(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Presionado {count} vez";
            else
                CounterBtn.Text = $"Presionad {count} veces";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
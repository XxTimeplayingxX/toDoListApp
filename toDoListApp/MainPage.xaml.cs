using System.Collections.ObjectModel;

namespace toDoListApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Task> MyTasks { get; set; }
        public string MyTitle { get; set; } = "Lista de Tareas";

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("¿Seguro que quieres salir?",
                "Al salir tu riñon izquierdo será nuestro",
                "Bueno....");
        }
    }
}
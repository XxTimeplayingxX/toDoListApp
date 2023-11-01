using System.Collections.ObjectModel;

namespace toDoListApp
{
    public partial class MainPage : ContentPage
    {
        public Tasks Tarea { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Tarea = new Tasks();
            Tarea.TaskName = "Comprar Pan";
            Tarea.Status = "Pendiente";
            BindingContext = Tarea;
            
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            Tarea.TaskName = "Estudiar";
            Tarea.Status = "Completado";
        }
    }
}
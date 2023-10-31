using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace toDoListApp
{
    public partial class MainPage : ContentPage
    {
        public Tasks MyTask { get; set; }

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
            BindingContext = MyTask;
        }
        private void CreateOneTask()
        {
            MyTask = new Tasks()
            {
                TaskName = "Estudiar",
                Status = "Pendiente",
                ColorText = "Blue"
            };
        }


        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            
            var MyNewTask = new Tasks();

            MyNewTask.TaskName = "Terminar la tarea";
            MyTask.Status = "Completado";

            //Source
            //var task = new Tasks()
            //{
            //    TaskName = "Lavar los platos",
            //    Status = "Pendiente",
            //    ColorText = "Yellow"
            //};


            ////Binding
            //var bindingTaskName = new Binding();
            //bindingTaskName.Source = task;
            //bindingTaskName.Path = "TaskName"; // LO que quiero mostrar

            //var bindingStatus = new Binding();
            //bindingStatus.Source = task;
            //bindingStatus.Path = "Status";

            //var bindingColor = new Binding();
            //bindingColor.Source = task;
            //bindingColor.Path = "ColorText";

            //Target
            //Tarea.SetBinding(Label.TextProperty, bindingTaskName); //Text property: definir la propiedad a usarse
            //Tarea.SetBinding(Label.TextColorProperty, bindingColor);
            //Estado.SetBinding(Label.TextProperty, bindingStatus);


        }

    }
}
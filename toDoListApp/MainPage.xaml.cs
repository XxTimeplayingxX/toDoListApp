using System.Collections.ObjectModel;

namespace toDoListApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            //Source
            var task = new Tasks()
            {
                TaskName = "Estudiar C#",
                Status = "Pendiente",
                ColorTask = "Blue"
            };


            //Binding
            var bindingTaskName = new Binding();
            bindingTaskName.Source = task;
            bindingTaskName.Path = "TaskName"; // LO que quiero mostrar

            var bindingStatus = new Binding();
            bindingStatus.Source = task;
            bindingStatus.Path = "Status";

            var bindingColor = new Binding();
            bindingColor.Source = task;
            bindingColor.Path = "ColorTask";

            //Target
            Tarea.SetBinding(Label.TextProperty, bindingTaskName); //Text property: definir la propiedad a usarse
            Tarea.SetBinding(Label.TextColorProperty, bindingColor);
            Estado.SetBinding(Label.TextProperty, bindingStatus);


        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoListApp
{
    public class Tasks :    INotifyPropertyChanged
    {
        private string taskName;
        private string status;
        private string colorTask;

        //Propiedad autoimplementada

        public string TaskName
        {
            get
            { return taskName; }
            set
            {
                taskName = value;
                OnPropertyChanged(nameof(TaskName));
            }
        } //Se conecta con MainPage :0
        public string Status
        {
            get => status; set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }
        public string ColorTask
        {
            get => colorTask; set
            {
                colorTask = value;
                OnPropertyChanged(nameof(ColorTask));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}

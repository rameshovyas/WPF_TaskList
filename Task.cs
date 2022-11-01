using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    public class Task : INotifyPropertyChanged
    {
        private string _description;
        private string _name;       
        private TaskType _type;
        private int _priority;

        public Task() { }

        public Task(string name,string description,int priority,TaskType type)
        {
            _name = name;
            _description = description;
            _priority = priority;
            _type = type;
        }

        public string TaskName
        {
            get { return _name; }
            set
            {
                _name  = value;
                OnPropertyChanged("TaskName");
            }
        }

        public string Description
        {
            get { return _description; }
            set 
            {
                _description = value;
                OnPropertyChanged("Desscription");
            }
        }

        public int Priority
        {
            get { return _priority; }
            set 
            {
                _priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public TaskType Type
        {
            get {  return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public override string ToString() => _name;       

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}

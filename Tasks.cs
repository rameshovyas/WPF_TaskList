using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    public class Tasks : ObservableCollection<Task>
    {
        public Tasks()
        {
            Add(new Task("Groceries", "Pick up Groceries from store", 2, TaskType.Home));
            Add(new Task("Laundry", "Do Laundry for my family", 2, TaskType.Home));
            Add(new Task("Code Review", "Review code for my new project", 1, TaskType.Work));
            Add(new Task("Paint", "Paint my office walls", 3, TaskType.Work));
            Add(new Task("Dinner", "Prepare diner for family", 1, TaskType.Home));
            Add(new Task("Walk", "Take walk after dinner", 2, TaskType.Home));
        }
    }
}

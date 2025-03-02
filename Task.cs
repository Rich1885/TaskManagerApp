using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp
{
    internal class Task
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }


        // Constructor
        public Task(int TaskId, string TaskTitle, string TaskDescription, int Priority, DateTime DueDate) 
        {
            this.TaskId = TaskId;
            this.TaskTitle = TaskTitle;
            this.TaskDescription = TaskDescription;
            this.Priority = Priority;
            this.DueDate = DueDate;
            this.IsCompleted = false;
        }

        // Mark task as completed
        public void MaAsCompleted ()
        {
            this.IsCompleted = true;
        }

        // Duplicate Task
        public Task DuplicateTask()
        {
            return new Task(GenerateNewId(), TaskTitle, TaskDescription, Priority, DueDate);
        }

        // Generate a new unique ID
        public int GenerateNewId()
        {
            return new Random().Next(1000, 9999);  // Temporary solution
        }

        // Override ToString()
        public override string ToString()
        {
            return $"[{TaskId}] {TaskTitle} (Priority: {Priority}, Due: {DueDate.ToShortDateString()}) - Completed: {IsCompleted}";
        }
         

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    internal class TodoItem: program
    {
        public int Id { get; set; }                     // unique identifier
        public string Task { get; set; }                 //The task description
        public bool IsCompleted { get; set; }             //The completion status

        public override string ToString()
        {
            return $"{Id}. [{(IsCompleted ? "X" : " ")}] {Task}";
        }
    }
}

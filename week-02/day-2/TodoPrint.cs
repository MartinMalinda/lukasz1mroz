using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = "- Buy milk\n";
            string listName = "My todo: \n";
            string task2 = "- Download games\n";
            string subtask2 = "    - Diablo\n";

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder todo = new StringBuilder(todoText);
            todo.Insert(0, listName);
            todo.Append(task2);
            todo.Append(subtask2);

            Console.WriteLine(todo);
        }
    }
}
namespace ToDoListBlazor.Pages
{
    public class FileOperation
    {
        public static bool SaveTasksToFile(List<TodoItem> todoItems, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false)) // Overwrite the file
                {
                    foreach (var item in todoItems)
                    {
                        writer.WriteLine($"{item.Id}, {item.TaskName}, {item.IsCompleted}");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}

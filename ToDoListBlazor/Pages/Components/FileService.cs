using ToDoListBlazor.Pages;

public class FileService
{
    private readonly string filePath;

    public FileService(string filePath)
    {
        this.filePath = filePath;
    }

    public bool SaveTasksToFile(List<TodoItem> todoItems)
    {
        try
        {
            // Serialize the list to a string
            string serializedTasks = string.Join(Environment.NewLine, todoItems.Select(item =>
                $"{item.Id}, {item.TaskName}, {item.IsCompleted}"));

            // Write the serialized string to the file
            File.WriteAllText(filePath, serializedTasks);

            return true;
        }
        catch
        {
            return false;
        }
    }
}

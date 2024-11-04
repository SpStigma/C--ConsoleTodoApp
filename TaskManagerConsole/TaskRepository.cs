using System.Text.Json;

public class TaskRepository
{
    private readonly string filePath = "tasks.json";
    private List<Task> tasks;

    public TaskRepository()
    {
        tasks = LoadTasks();
    }

    private List<Task> LoadTasks()
    {
        if (!File.Exists(filePath))
        {
            return new List<Task>();
        }

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
    }

    private void SaveTasks()
    {
        string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public void AddTask(Task task)
    {
        task.Id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
        task.DateCreated = DateTime.Now;
        tasks.Add(task);
        SaveTasks();
    }

    public void UpdateTask(int id, string newTitle, string newDescription, bool isCompleted)
    {
        Task? task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.Title = newTitle;
            task.Description = newDescription;
            task.IsCompleted = isCompleted;
            SaveTasks();
        }
    }

    public void DeleteTask(int id)
    {
        Task? task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
            SaveTasks();
        }
    }

    public Task? GetTaskById(int id)
    {
        return tasks.FirstOrDefault(t => t.Id == id);
    }

    public List<Task> GetAllTasks()
    {
        return tasks;
    }
}

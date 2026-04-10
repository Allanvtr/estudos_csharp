using Microsoft.AspNetCore.Http.HttpResults;

public class TaskService
{
    static List<ToDoTask> Tasks = new List<ToDoTask>();
    
    public static List<ToDoTask> GetAll() => Tasks;

    public static ToDoTask? GetById(int id) => Tasks.FirstOrDefault(t => t.Id == id);
    
    public static bool Add(ToDoTask task)
    {
        try
        {
            Tasks.Add(task);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool Delete (int id)
    {
        var task = TaskService.GetById(id);

        if (task != null) 
        {
            Tasks.Remove(task);
            return true;
        }
    
        return false;
    }

    public static bool Update (int id, ToDoTask task)
    {
        var taskToUpdate = TaskService.GetById(id);

        if (taskToUpdate == null) return false;

        taskToUpdate.Description = task.Description;
        taskToUpdate.Done = task.Done;

        return true;
    }
}
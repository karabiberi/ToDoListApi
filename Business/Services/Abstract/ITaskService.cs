using Entity;
using Entity.TaskItemEntity;

namespace Business.Services.Abstract;

public interface ITaskService
{
    Task<List<TaskItem>> GetAllTasksAsync();

    Task<TaskItem> GetTaskByIdAsync(int id);

    Task CreateTaskAsync(TaskItem task);

    Task UpdateTaskAsync(TaskItem task);

    Task DeleteTaskAsync(int id);
}
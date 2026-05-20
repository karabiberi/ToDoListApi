using Business.Services.Abstract;
using DAL.Repositories.Abstract;
using Entity;
using Entity.TaskItemEntity;

namespace Business.Services.Concrete;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<List<TaskItem>> GetAllTasksAsync()
    {
        return await _taskRepository.GetAllAsync();
    }

    public async Task<TaskItem> GetTaskByIdAsync(int id)
    {
        return await _taskRepository.GetByIdAsync(id);
    }

    public async Task CreateTaskAsync(TaskItem task)
    {
        await _taskRepository.AddAsync(task);
        await _taskRepository.SaveAsync();
    }

    public async Task UpdateTaskAsync(TaskItem task)
    {
        _taskRepository.Update(task);
        await _taskRepository.SaveAsync();
    }

    public async Task DeleteTaskAsync(int id)
    {
        var task = await _taskRepository.GetByIdAsync(id);

        _taskRepository.Delete(task);

        await _taskRepository.SaveAsync();
    }
}
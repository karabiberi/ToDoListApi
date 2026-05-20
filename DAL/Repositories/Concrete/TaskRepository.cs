using DAL.DBContext;
using DAL.Repositories.Abstract;
using Entity;
using Entity.TaskItemEntity;

namespace DAL.Repositories.Concrete;

public class TaskRepository : GenericRepository<TaskItem>, ITaskRepository
{
    public TaskRepository(AppDbContext context) : base(context)
    {
    }
}
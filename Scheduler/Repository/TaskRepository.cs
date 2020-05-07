using Scheduler.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Scheduler.Data.Entities;

namespace Scheduler.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _ctx;

        public TaskRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Task> GetTaskOfUser(string userId)
        {
            return _ctx.Tasks.Where(t => t.UserId == userId).ToList();
        }

        public IEnumerable<Task> GetTaskOfDate(DateTime date)
        {
            return _ctx.Tasks.Where(t => t.CreationTime == date).ToList();
        }

        public IEnumerable<Task> GetTasksOfUserWithDate(string userId)
        {
            return _ctx.Tasks.Where(t => t.CreationTime.Value.Month == DateTime.Now.Month && t.UserId == userId).ToList();
        }

        public IEnumerable<Task> GetTasksOfUserInDate(string userId, int month, int year)
        {
            return _ctx.Tasks.Where(t => t.CreationTime.Value.Month == month && t.UserId == userId && t.CreationTime.Value.Year == year).ToList();
        }

        public void CreateTask(Task task)
        {
            _ctx.Tasks.Add(task);
        }

        public bool Commit()
        {
            return _ctx.SaveChanges() > 0;
        }

        public Task Find(int id)
        {
            return _ctx.Tasks.Find(id);
        }

        public void Delete(Task task)
        {
            _ctx.Tasks.Remove(task);
            _ctx.Update(task).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }
    }
}

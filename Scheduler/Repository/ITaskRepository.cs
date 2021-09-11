using Scheduler.Data.Entities;
using System;
using System.Collections.Generic;

namespace Scheduler.Repository
{
    public interface ITaskRepository
    {
        bool Commit();
        void CreateTask(Task task);
        IEnumerable<Task> GetByName(string name);
        IEnumerable<Task> GetTaskOfDate(DateTime date);
        IEnumerable<Task> GetTaskOfUser(string userId);
        IEnumerable<Task> GetTasksOfUserWithDate(string userId);
        IEnumerable<Task> GetTasksOfUserInDate(string userId, int month, int year);
        Task Find(int id);
        void Delete(Task task);
    }
}
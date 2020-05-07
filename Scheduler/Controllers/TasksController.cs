using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Scheduler.Repository;
using Scheduler.ViewModels;

namespace Scheduler.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IUserRepository _userRepository;

        public TasksController(ITaskRepository taskRepository, IUserRepository userRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var user = _userRepository.FindUserByName(User.Identity.Name);
            MyScheduleViewModel model = new MyScheduleViewModel
            {
                CurrentDateTime = DateTime.Now,
                Tasks = _taskRepository.GetTasksOfUserWithDate(user.Id).OrderBy(t => t.CreationTime).ToList(),
                Year = DateTime.Now.Year
            };
            return View(model);
        }

        public IActionResult NextMonth(string current, int year)
        {
            int monthNumber = Calender.Lib.Calender.GetMonthNumber(current);
            var user = _userRepository.FindUserByName(User.Identity.Name);
            if (monthNumber < 12)
            {
                monthNumber++;
            }
            else
            {
                monthNumber = 1;
                year++;
            }
            MyScheduleViewModel model = new MyScheduleViewModel
            {
                Month = monthNumber,
                Year = year,
                Tasks = _taskRepository.GetTasksOfUserInDate(user.Id, monthNumber, year).OrderBy(t => t.CreationTime).ToList()
            };
            return PartialView("_MonthDays", model);
        }

        public IActionResult PrevMonth(string current, int year)
        {
            int monthNumber = Calender.Lib.Calender.GetMonthNumber(current);
            if (monthNumber > 1)
            {
                monthNumber--;
            }
            else
            {
                monthNumber = 12;
                year--;
            }
            var user = _userRepository.FindUserByName(User.Identity.Name);
            MyScheduleViewModel model = new MyScheduleViewModel
            {
                Month = monthNumber,
                Year = year,
                Tasks = _taskRepository.GetTasksOfUserInDate(user.Id, monthNumber, year).OrderBy(t => t.CreationTime).ToList()
            };
            return PartialView("_MonthDays", model);
        }

        public IActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTask(Data.Entities.Task task)
        {
            if(!ModelState.IsValid)
            {
                return View(task);
            }
            var jj = User.Identity.Name;
            var user = _userRepository.FindUserByName(User.Identity.Name);
            task.UserId = user.Id;
            _taskRepository.CreateTask(task);
            _taskRepository.Commit();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int day, string month, int year)
        {
            var task = _taskRepository.GetTaskOfDate(Convert.ToDateTime($"{month}/{day}/{year}")).FirstOrDefault();
            if(task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _taskRepository.Find(id);
            if(task == null)
            {
                return NotFound();
            }
            _taskRepository.Delete(task);
            _taskRepository.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}
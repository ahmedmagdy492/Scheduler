using Calender.Lib;
using Scheduler.Data;
using Scheduler.Data.Entities;
using Scheduler.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduler.ViewModels
{
    public class MyScheduleViewModel
    {
        public DateTime CurrentDateTime { get; set; }        
        public Months Months { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public List<Task> Tasks { get; set; }        
    }
}

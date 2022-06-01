using Core;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Task:IEntity
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Priority { get; set; }
        public bool Urgency { get; set; }
        public DateTime CompletionTime { get; set; }
        public States State { get; set; }
        public int EmployeeId { get; set; }
    }
}

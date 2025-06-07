using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain.Common;

namespace TaskApp.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description {  get; set; }
        public bool IsDone { get; set; } = false;
        public DateTime? DueDate { get; set; }

        public void MarkAsDone()
        {
            IsDone = true;
        }
        public void MarkAsUndone()
        {
            IsDone = false;
        }
    }
}

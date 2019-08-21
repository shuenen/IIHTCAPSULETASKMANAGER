using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDL
{
   public  class TaskParentDetail
    {
        public int id { get; set; }
        public int Parent_Id { get; set; }
        public string Task_Name { get; set; }
        public string parentTaskName { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Range { get; set; }
    }
}

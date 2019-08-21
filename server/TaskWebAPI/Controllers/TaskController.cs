using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskBL;
using TaskDL;

namespace TaskWebAPI.Controllers
{
    public class TaskController : ApiController
    {
        TaskBusiness obj = new TaskBusiness();
        // GET: api/Employee
        public IEnumerable<TaskParentDetail> Get()
        {
            return obj.GetTasks();
        }

        // GET: api/Employee/5
        public TaskParentDetail Get(int id)
        {
            return obj.GetTask(id);
        }

        // POST: api/Employee
        public void Post(TaskDetail item)
        {
            obj.Add(item);
        }

        // PUT: api/Employee/5
        public void Put(TaskDetail item)
        {
            obj.Update(item);
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
            obj.Delete(id);
        }

    }
}

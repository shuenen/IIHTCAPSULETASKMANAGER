﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskDL;

namespace TaskWebAPI.Controllers
{
    public class TaskDetailController : ApiController
    {
        public List<TaskParentDetail> Get()
        {
            using (CapsuleEntities1 db = new CapsuleEntities1())
            {
                List<ParentTask> listParent = db.ParentTasks.ToList();
                List<TaskDetail> listTask = db.TaskDetails.ToList();
                List<TaskParentDetail> listTaskParentDetailNew = new List<TaskParentDetail>();
                var r4 = from i in listTask
                         join
                         i2 in listParent
                         on i.Parent_Id equals i2.Parent_Id
                         select new { i.Id, i.Parent_Id, i.Range, i.Start_Date, i.End_Date, i.Task_Name, i2.Parent_Task_Name };

                foreach (var item in r4)
                {
                    TaskParentDetail objtaskParentDetailNew = new TaskParentDetail();
                    objtaskParentDetailNew.id = item.Id;
                    objtaskParentDetailNew.Parent_Id = item.Parent_Id.Value;
                    objtaskParentDetailNew.parentTaskName = item.Parent_Task_Name;
                    objtaskParentDetailNew.Range = item.Range.Value;
                    objtaskParentDetailNew.Start_Date = item.Start_Date.Value;
                    objtaskParentDetailNew.End_Date = item.End_Date.Value;
                    objtaskParentDetailNew.Task_Name = item.Task_Name;
                    listTaskParentDetailNew.Add(objtaskParentDetailNew);
                }
                return listTaskParentDetailNew;

            }
        }
        //Get task details by id
        public TaskParentDetail Get(int id)
        {
            TaskParentDetail objtaskParentDetailNew = new TaskParentDetail();
            using (CapsuleEntities1 db = new CapsuleEntities1())
            {
                List<ParentTask> listParent = db.ParentTasks.ToList();
                List<TaskDetail> listTask = db.TaskDetails.ToList();

                var r4 = from i in listTask
                         join
                         i2 in listParent
                         on i.Parent_Id equals i2.Parent_Id
                         where i.Id == id
                         select new { i.Id, i.Parent_Id, i.Range, i.Start_Date, i.End_Date, i.Task_Name, i2.Parent_Task_Name };
                foreach (var item in r4)
                {
                    objtaskParentDetailNew.id = item.Id;
                    objtaskParentDetailNew.Parent_Id = item.Parent_Id.Value;
                    objtaskParentDetailNew.parentTaskName = item.Parent_Task_Name;
                    objtaskParentDetailNew.Range = item.Range.Value;
                    objtaskParentDetailNew.Start_Date = item.Start_Date.Value;
                    objtaskParentDetailNew.End_Date = item.End_Date.Value;
                    objtaskParentDetailNew.Task_Name = item.Task_Name;
                }
            }
            return objtaskParentDetailNew;


        }
        //Add new Task details
        public void Post(TaskDetail item)
        {
            using (CapsuleEntities1 db = new CapsuleEntities1())
            {
                db.TaskDetails.Add(item);
                db.SaveChanges();
            }
        }
        //delete Task details
        public void Delete(int id)
        {
            using (CapsuleEntities1 db = new CapsuleEntities1())
            {
                TaskDetail obj = db.TaskDetails.Find(id);
                db.TaskDetails.Remove(obj);
                db.SaveChanges();
            }
        }
        //update Task details
        public void Put(TaskDetail item)
        {
            using (CapsuleEntities1 db = new CapsuleEntities1())
            {
                TaskDetail obj = db.TaskDetails.Find(item.Id);
                obj.Id = item.Id;
                obj.Parent_Id = item.Parent_Id;
                obj.Range = item.Range;
                obj.Task_Name = item.Task_Name;
                obj.Start_Date = item.Start_Date;
                obj.End_Date = item.End_Date;
                db.SaveChanges();
            }
        }
    }
}

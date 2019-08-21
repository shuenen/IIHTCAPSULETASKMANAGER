using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBL;
using TaskDL;
using TaskWebAPI;
using NUnit.Framework;

namespace TaskTest
{    [TestFixture]
    public class TaskTestDetail
    {
        List<TaskParentDetail> li;           
        [Test]
        public void GetTaskCountDetailsPass()
        {
        
        TaskBusiness objTaskBusiness = new TaskBusiness();
            li = objTaskBusiness.GetTasks();
            Assert.AreEqual(8, li.Count);
        }
        [Test]
        public void GetTaskCountDetailsFail()
        {

            TaskBusiness objTaskBusiness = new TaskBusiness();
            li = objTaskBusiness.GetTasks();
            Assert.AreNotEqual(0, li.Count);
        }
        [Test]
        public void GetTaskDetailsFail()
        {
            List<TaskParentDetail> li1 = new List<TaskParentDetail>();
            TaskParentDetail objTaskParentDetail = new TaskParentDetail();
            objTaskParentDetail.id = 1;
            objTaskParentDetail.Parent_Id = 1;
            objTaskParentDetail.Range = 10;
            objTaskParentDetail.Task_Name = "Task 1";
            objTaskParentDetail.parentTaskName = "Parent Task 1";
            objTaskParentDetail.Start_Date = DateTime.Parse("Jan 1, 2018");
            objTaskParentDetail.End_Date = DateTime.Parse("Jan 1, 2019");
            li1.Add(objTaskParentDetail);
            TaskBusiness objTaskBusiness = new TaskBusiness();
            li = objTaskBusiness.GetTasks();
            Assert.AreEqual(li1, li);
        }
        [Test]
        public void GetTaskDetailsPass()
        {
            List<TaskParentDetail> li1 = new List<TaskParentDetail>();
            TaskParentDetail objTaskParentDetail = new TaskParentDetail();
            objTaskParentDetail.id = 1;
            objTaskParentDetail.Parent_Id = 1;
            objTaskParentDetail.Range = 10;
            objTaskParentDetail.Task_Name = "Task 1";
            objTaskParentDetail.parentTaskName = "Parent Task 1";
            objTaskParentDetail.Start_Date = DateTime.Parse("Jan 1, 2018");
            objTaskParentDetail.End_Date = DateTime.Parse("Jan 1, 2019");
            li1.Add(objTaskParentDetail);
             objTaskParentDetail = new TaskParentDetail();
            objTaskParentDetail.id = 2;
            objTaskParentDetail.Parent_Id = 1;
            objTaskParentDetail.Range = 20;
            objTaskParentDetail.Task_Name = "Task 2";
            objTaskParentDetail.parentTaskName = "Parent Task 1";
            objTaskParentDetail.Start_Date = DateTime.Parse("Jan 1, 2017");
            objTaskParentDetail.End_Date = DateTime.Parse("Jan 1, 2019");
            li1.Add(objTaskParentDetail);
             objTaskParentDetail = new TaskParentDetail();
            objTaskParentDetail.id = 3;
            objTaskParentDetail.Parent_Id = 2;
            objTaskParentDetail.Range = 30;
            objTaskParentDetail.Task_Name = "Task 3";
            objTaskParentDetail.parentTaskName = "Parent Task 2";
            objTaskParentDetail.Start_Date = DateTime.Parse("Jan 1, 2017");
            objTaskParentDetail.End_Date = DateTime.Parse("Jan 1, 2018");
            li1.Add(objTaskParentDetail);
            TaskBusiness objTaskBusiness = new TaskBusiness();
            li = objTaskBusiness.GetTasks();
            Assert.AreEqual(li1, li);
        }
        [Test]
        public void GetTaskDetailByIdPass()
        {
            TaskParentDetail objTaskParentDetail = new TaskParentDetail();
            objTaskParentDetail.Parent_Id = 2;
            objTaskParentDetail.Range = 30;
            objTaskParentDetail.Task_Name = "Task 3";
            objTaskParentDetail.parentTaskName = "Parent Task 2";
            objTaskParentDetail.Start_Date = DateTime.Parse("Jan 1, 2017");
            objTaskParentDetail.End_Date = DateTime.Parse("Jan 1, 2018");
            TaskBusiness objTaskBusiness = new TaskBusiness();
            TaskParentDetail objTaskParentDetailNew = new TaskParentDetail();
            objTaskParentDetailNew = objTaskBusiness.GetTask(3);
            Assert.AreEqual(objTaskParentDetailNew, objTaskParentDetail);

        }
        [Test]
        public void GetTaskDetailByIdFail()
        {
            TaskParentDetail objTaskParentDetail = new TaskParentDetail();
            objTaskParentDetail.Parent_Id = 2;
            objTaskParentDetail.Range = 30;
            objTaskParentDetail.Task_Name = "Task 3";
            objTaskParentDetail.parentTaskName = "Parent Task 2";
            objTaskParentDetail.Start_Date = DateTime.Parse("Jan 1, 2017");
            objTaskParentDetail.End_Date = DateTime.Parse("Jan 1, 2018");
            TaskBusiness objTaskBusiness = new TaskBusiness();
            TaskParentDetail objTaskParentDetailNew = new TaskParentDetail();
            objTaskParentDetailNew = objTaskBusiness.GetTask(6);
            Assert.AreEqual(objTaskParentDetailNew, objTaskParentDetail);

        }
    }

    }


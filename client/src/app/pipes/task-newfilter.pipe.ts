import { Pipe, PipeTransform } from '@angular/core';
import { Task } from '../model/task';

@Pipe({
  name: 'taskNewfilter'
})
export class TaskNewfilterPipe implements PipeTransform {

  transform(items: Task[], srchTask: string, srchParentTask: string, srchPriorityFrom: number,srchPriorityTo:number,srchStartDate:Date,srchEndDate:Date): Task[] {
      if (items && items.length){
      return items.filter(item =>{
        if (srchTask && item.Task_Name.toLowerCase().indexOf(srchTask.toLowerCase()) === -1){
          return false;
      }
      if (srchParentTask && item.parentTaskName.toLowerCase().indexOf(srchParentTask.toLowerCase()) === -1){
        return false;
    }
    if (srchPriorityFrom && srchPriorityFrom >= item.Range ){
      return false;
    }
    if (srchPriorityTo && srchPriorityTo <= item.Range){
    return false;
    }
    if (srchStartDate && item.Start_Date <= srchStartDate){
  return false;
    }
    if (srchEndDate && item.End_Date >= srchEndDate){
  return false;
    }
  return true;
})
}
else{
  return items;
}
}
}



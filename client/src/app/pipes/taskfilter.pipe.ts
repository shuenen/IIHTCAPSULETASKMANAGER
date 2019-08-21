import { Pipe, PipeTransform } from '@angular/core';
import { Task } from '../model/task';

@Pipe({
  name: 'taskfilter'
})
export class TaskfilterPipe implements PipeTransform {

  transform(value: Task[], srchTask: string, srchParentTask: string, srchPriorityFrom: string): Task[] {
    if(!srchTask)
  return value;
  if(value==null)
  return [];
  // stext=stext.toLowerCase();
  return value.filter(it=>{
    return it.Task_Name.startsWith(srchTask)
  })
}
}

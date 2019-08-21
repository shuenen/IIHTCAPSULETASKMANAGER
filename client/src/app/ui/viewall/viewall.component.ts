import { Component, OnInit } from '@angular/core';
import { Product } from '../../model/product';
import { SharedService } from '../../services/shared.service';
//import { Book } from '../../model/book';
import { Task } from '../../model/task';
import {Router, RouterLink} from '@angular/router';

@Component({
  selector: 'app-viewall',
  templateUrl: './viewall.component.html',
  styleUrls: ['./viewall.component.css']
})
export class ViewallComponent implements OnInit {
list:Task[];
res:any;
id:any;
book=new Task()
  constructor(private _service:SharedService,private _route:Router) {
    this._service.GetAll().subscribe(k=>this.list=k);
   }

  ngOnInit() {
    //location.reload();
    //this._service.GetAll().subscribe(k=>this.list=k);
    
  }
  
  Modify(Pid:number)
  {
    this.id=2;
    //this._service.Get(this.id).subscribe(k=>this.res=k);
    this._route.navigateByUrl("/update/" + Pid);
    //this._route.navigateByUrl('/update/1');

  }
  Delete(Pid:number)
  {
  //  this.id=item.id;
    //this._service.Get(this.id).subscribe(k=>this.res=k);
    this._service.Delete(Pid).subscribe(k=>this.res=k);
    //this.ngOnInit();


   //this._service.GetAll().subscribe(k=>this.list=k);
   //this._route.navigateByUrl('/viewall');
   location.reload();

  }

}

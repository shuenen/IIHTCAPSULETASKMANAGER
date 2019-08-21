import { Component, OnInit } from '@angular/core';
import { Product } from '../../model/product';
import {Router, RouterLink} from '@angular/router';
import { SharedService } from '../../services/shared.service';
import { Task } from '../../model/task';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {
item:Task;
res:string;
  constructor(private _service:SharedService,private _route:Router) {
    this.item=new Task();
   }

  ngOnInit() {
  }
  Add()
  {
    this._service.Add(this.item).subscribe(k=>this.res=k);
   this._route.navigateByUrl('/viewall')
   location.reload();
  }

}

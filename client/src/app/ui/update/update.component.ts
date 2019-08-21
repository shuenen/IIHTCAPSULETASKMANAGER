import { Component, OnInit } from '@angular/core';
import { Product } from '../../model/product';
import {Router, RouterLink} from '@angular/router';
import {ActivatedRoute} from '@angular/router';
import { SharedService } from '../../services/shared.service';
import { Task } from '../../model/task';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';


@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {
  item:Task;
  res:string;
  id:number;
  constructor(private _active:ActivatedRoute,private _service:SharedService,private _router:Router) {
  //  this._service.Get(this.id).subscribe(k=>this.res=k);
  this._active.params.subscribe(k=>this.id=k["id"])
  this._service.Get(this.id).subscribe(k=>this.item=k);

   }

  ngOnInit() {
  }
  Update()
  {
    this._service.Update(this.item).subscribe(k=>this.res=k);
    //this._router.navigateByUrl('/viewall', {skipLocationChange: true}).then(()=>
    //this._router.navigate(["/update"])); 

   this._router.navigateByUrl('/viewall')
   location.reload();
  }
}

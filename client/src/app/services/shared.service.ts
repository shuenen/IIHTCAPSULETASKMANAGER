import { Injectable } from '@angular/core';
import {Http,Response} from '@angular/http';
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Task } from '../model/task';

@Injectable()
export class SharedService {
url:string='http://localhost:53120/api/';
  constructor(private _http:Http) { }
  GetAll():Observable<Task[]>
  {
    return this._http.get(this.url+'taskdetailnew')
    .map((res:Response)=><Task[]>res.json())
  }
  Get(id:number):Observable<Task>
  {
    return this._http.get(this.url+'taskdetailnew/'+id)
    .map((res:Response)=><Task>res.json())
  }
  Add(data:Task):Observable<any>
  {
    return this._http.post(this.url+'taskdetailnew',data)
    .map((res:Response)=><any>res.json())
  }
  Update(item:Task):Observable<any>
  {
    return this._http.put(this.url+'taskdetailnew',item)
    .map((res:Response)=><any>res.json())
  }
  Delete(id:number):Observable<any>
  {
    return this._http.delete(this.url+'taskdetailnew/'+id)
    .map((res:Response)=><any>res.json())
  }


}

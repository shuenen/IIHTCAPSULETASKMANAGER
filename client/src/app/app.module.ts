import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule,Routes} from '@angular/router';
import {HttpModule} from '@angular/http';
import {FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { AddComponent } from './ui/add/add.component';
import { ViewallComponent } from './ui/viewall/viewall.component';
import { UpdateComponent } from './ui/update/update.component';
import { SharedService } from './services/shared.service';
import { TaskfilterPipe } from './pipes/taskfilter.pipe';
import { TaskNewfilterPipe } from './pipes/task-newfilter.pipe';
const appRoutes:Routes=[
  {path:'add',component:AddComponent},
  {path:'viewall',component:ViewallComponent},
  {path:'update/:id',component:UpdateComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    AddComponent,
    ViewallComponent,
    UpdateComponent,
    TaskfilterPipe,
    TaskNewfilterPipe
  ],
  imports: [
    BrowserModule,RouterModule.forRoot(appRoutes),HttpModule,FormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewallComponent } from './viewall.component';
import { Component } from '@angular/core';

describe('ViewallComponent', () => {
  let component: ViewallComponent;
  let fixture: ComponentFixture<ViewallComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewallComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('should redirect', () => {
    component.Modify(2);
    expect(this._route.navigateByUrl('/update/2')).toContain(2);
  });
  it('should delete', () => {
    component.Delete(2);
    expect(this._service.Delete(2).subscribe(k=>this.res=k)).toContain(2);
  });
});

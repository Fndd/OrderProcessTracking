import { Component, RendererStyleFlags2 } from '@angular/core';
import { ShowOnDirtyErrorStateMatcher } from '@angular/material/core';
import { NgxSpinnerService } from 'ngx-spinner';

export class BaseComponent {
constructor(private spinner: NgxSpinnerService){
}
showSpinner(spinnerName: SpinnerName){
this.spinner.show(spinnerName);
}
hideSpinner(spinnerName: SpinnerName){
  this.spinner.hide(spinnerName);
  }
}
export enum SpinnerName{
  BallAtom = "s1",
  BallScaleMultiple = "s2",
  SquareJellyBox ="s3"  
}
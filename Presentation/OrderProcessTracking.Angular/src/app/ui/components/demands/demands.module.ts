import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DemandsComponent } from './demands.component';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    DemandsComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{
      path:"", component: DemandsComponent
      },])
  ]
})
export class DemandsModule { }

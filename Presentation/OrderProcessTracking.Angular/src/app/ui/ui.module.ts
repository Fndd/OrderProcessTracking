import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { ComponentsModule } from './components/components.module';
import { RouterModule } from '@angular/router';
import { ProductsModule } from './components/products/products.module';
import { BasketsModule } from './components/baskets/baskets.module';
import { HomeModule } from './components/home/home.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ComponentsModule,
    RouterModule
  ] ,
  exports: [ 
    ProductsModule, 
    BasketsModule,
    HomeModule
  ]
})
export class UiModule { }

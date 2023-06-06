import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { BasketsModule } from './baskets/baskets.module';
import { ProductsModule } from './products/products.module';
import { HomeModule } from './home/home.module';
import { DemandsModule } from './demands/demands.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    BasketsModule,
    ProductsModule,
    HomeModule,
    DemandsModule,
    RouterModule
  ] ,
  exports: [ 
    BasketsModule,
    ProductsModule,
    HomeModule
  ]
})
export class ComponentsModule { }

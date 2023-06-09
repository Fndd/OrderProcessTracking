import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerName } from 'src/app/base/base.component';
import { Products } from 'src/app/contracts/products';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent extends BaseComponent implements OnInit {

  constructor(spinner: NgxSpinnerService,private httpClientService: HttpClientService) {
    super(spinner);
  }

  ngOnInit(): void {
    this.showSpinner(SpinnerName.SquareJellyBox);
    this.httpClientService.get<Products>({
      controller:"products"
    }).subscribe(data => console.log(data));
    
    this.httpClientService.post(
      {controller:"products"}, 
      {name: "kalem 1"}
    ).subscribe(data => console.log(data));

    this.httpClientService.post(
      {controller:"products"}, 
      {name: "kalem 2"}
    ).subscribe(data => console.log(data));
    this.hideSpinner(SpinnerName.SquareJellyBox);
  } 
}

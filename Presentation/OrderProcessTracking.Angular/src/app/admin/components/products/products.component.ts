import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerName } from 'src/app/base/base.component';
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
    this.httpClientService.get({
      controller:"products"
    }).subscribe(data => console.log(data));
    
    this.httpClientService.post(
      {controller:"products"}, 
      {name: "kalem"}
    ).subscribe(data => console.log(data));
  } 
}

import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerName } from 'src/app/base/base.component';
import { Create_Product } from 'src/app/contracts/Create_Product';
import { AlertifyService, MessagePosition, MessageType } from 'src/app/services/admin/alertify.service';
import { ProductService } from 'src/app/services/common/models/product.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent extends BaseComponent implements OnInit {
  constructor(spinner: NgxSpinnerService, private productService: ProductService, private alertify: AlertifyService) {
    super(spinner);
  }
  ngOnInit(): void { }
  create(name: HTMLInputElement) {
    this.showSpinner(SpinnerName.BallAtom);
    const create_product: Create_Product = new Create_Product();
    create_product.name = name.value;
    this.productService.create(create_product, () => this.hideSpinner(SpinnerName.BallAtom));

  }
}
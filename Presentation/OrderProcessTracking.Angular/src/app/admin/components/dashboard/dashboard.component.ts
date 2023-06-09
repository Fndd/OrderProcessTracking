import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent } from 'src/app/base/base.component';
import { AlertifyOptions, AlertifyService, MessagePosition, MessageType } from 'src/app/services/admin/alertify.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent extends BaseComponent implements OnInit {

  constructor(private alertfy:AlertifyService,spinner : NgxSpinnerService) {
    super(spinner);
   }

  ngOnInit(): void { 
  }
m(){
  this.alertfy.message("hellö",{messageType : MessageType.Success,delay: 5,position: MessagePosition.BottomRight});
}
d(){
  this.alertfy.dismissAll();
}
}

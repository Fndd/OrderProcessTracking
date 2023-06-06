import { Component, OnInit } from '@angular/core';
import { AlertifyOptions, AlertifyService, MessagePosition, MessageType } from 'src/app/services/admin/alertify.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor(private alertfy:AlertifyService) { }

  ngOnInit(): void { 
  }
m(){
  this.alertfy.message("hellö",{messageType : MessageType.Success,delay: 5,position: MessagePosition.BottomRight});
}
d(){
  this.alertfy.dismissAll();
}
}

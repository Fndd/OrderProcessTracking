import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
@Injectable({
  providedIn: 'root'
})
export class CustomToastrService {

  constructor(private toastr: ToastrService) { }

    message(message: string, title: string,options :  Partial<ToastrOptions>){
     
     const msj = this.toastr[options.messageType](message,title,{
      positionClass: options.position
     }); 
    } 
  }
 
export  class ToastrOptions{ 
  messageType: ToastrMessageType = ToastrMessageType.Error;
  position: ToastrMessagePosition = ToastrMessagePosition.BottomRight;
 }
export enum ToastrMessageType{
Error = "error",
Success = "success",
Info = "info", 
Warning = "warning"
}

export enum ToastrMessagePosition{
  TopCenter = "toast-top-center",
  TopLeft = "toast-top-left",
  TopRight = "toast-top-right",
  BottomCenter = "toast-bottom-center",
  BottomLeft = "toast-bottom-left",
  BottomRight = "toast-bottom-right",
  }
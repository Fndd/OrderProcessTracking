import { Injectable } from '@angular/core';
declare var alertify :any;
@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }
  message(message: string, options : Partial<AlertifyOptions>){
    alertify.set('notifier','delay',options.delay);
    alertify.set('notifier','position',options.position);
   const msj = alertify[options.messageType](message);
    if(options.dismissOthers)
    {
      msj.dismissOthers();
    }
  }
  dismissAll(){
    alertify.dismissAll();
  }
}
export  class AlertifyOptions{ 
  messageType: MessageType = MessageType.Message;
  position: MessagePosition = MessagePosition.BottomRight;
  delay : number = 3;
  dismissOthers: boolean = false
}
export enum MessageType{
Error = "error",
Success = "success",
Message = "message",
Notify = "notify",
Warning = "warning"
}

export enum MessagePosition{
  TopCenter = "top-center",
  TopLeft = "top-left",
  TopRight = "top-right",
  BottomCenter = "bottom-center",
  BottomLeft = "bottom-left",
  BottomRight = "bottom-right",
  }
  
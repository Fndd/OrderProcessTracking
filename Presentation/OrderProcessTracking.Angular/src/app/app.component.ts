import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessagePosition, ToastrMessageType } from './services/ui/custom-toastr.service';

declare var $: any

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ETicaretClient';
constructor(private toastrService: CustomToastrService){
  toastrService.message("Hellö","aaa", {
    messageType: ToastrMessageType.Info,
    position: ToastrMessagePosition.BottomLeft});
}
}
$.get("https://localhost:7052/api/Products", data => {
  console.log(data);
});
 
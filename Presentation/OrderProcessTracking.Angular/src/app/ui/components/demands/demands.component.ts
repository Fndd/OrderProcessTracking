import { Component, OnInit } from '@angular/core';
import { NgxSpinner, NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent } from 'src/app/base/base.component';

@Component({
  selector: 'app-demands',
  templateUrl: './demands.component.html',
  styleUrls: ['./demands.component.scss']
})
export class DemandsComponent extends BaseComponent implements OnInit {

  constructor(spinner: NgxSpinnerService) { 
    super(spinner);
  }

  ngOnInit(): void {
  }
} 
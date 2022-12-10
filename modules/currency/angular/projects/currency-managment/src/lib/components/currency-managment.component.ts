import { Component, OnInit } from '@angular/core';
import { CurrencyManagmentService } from '../services/currency-managment.service';

@Component({
  selector: 'lib-currency-managment',
  template: ` <p>currency-managment works!</p> `,
  styles: [],
})
export class CurrencyManagmentComponent implements OnInit {
  constructor(private service: CurrencyManagmentService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}

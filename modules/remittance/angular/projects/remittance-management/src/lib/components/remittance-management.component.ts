import { Component, OnInit } from '@angular/core';
import { RemittanceManagementService } from '../services/remittance-management.service';

@Component({
  selector: 'lib-remittance-management',
  template: ` <p>remittance-management works!</p> `,
  styles: [],
})
export class RemittanceManagementComponent implements OnInit {
  constructor(private service: RemittanceManagementService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}

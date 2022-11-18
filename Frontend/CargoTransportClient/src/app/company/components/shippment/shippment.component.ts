import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import {ShippmentService} from 'src/app/company/models/shippment-service';

@Component({
  selector: 'app-shippment',
  templateUrl: './shippment.component.html',
  styleUrls: ['./shippment.component.css']
})
export class ShippmentComponent implements OnChanges {
  @Input()shipmentService:ShippmentService | null = null;
  price:number = 0;
  constructor() { }

  ngOnChanges(changes: SimpleChanges): void {
      console.log('from shippment service',changes);
  }

}

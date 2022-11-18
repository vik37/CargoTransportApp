import { Component, OnInit,OnDestroy } from '@angular/core';
import {Subscription} from 'rxjs'
import { ActivatedRoute } from '@angular/router';
import {Company} from 'src/app/company/models/company';
import {CompanyService} from 'src/app/company/services/company.service';
import {ShippmentService} from 'src/app/company/models/shippment-service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit, OnDestroy {

  private companySub = new Subscription();
  private routeSub = new Subscription();
  private id:number = 0;
  company :Company | null = null;
  shipmentService:ShippmentService | null = null;

  constructor(private companyService:CompanyService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.routeSub = this.route.params.subscribe(params =>{
        this.id = +params['id'];
      }
    );
    this.companySub = this.companyService.getById(this.id).subscribe(data =>
      this.company = data.body,
  );

  }
  ngOnDestroy(): void {
    this.companySub.unsubscribe();
    this.routeSub.unsubscribe();
  }
}

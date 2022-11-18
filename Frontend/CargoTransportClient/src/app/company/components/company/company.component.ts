import { Component, OnInit,OnDestroy } from '@angular/core';
import {CompanyService} from 'src/app/company/services/company.service';
import {Subscription} from 'rxjs'
import {Company} from 'src/app/company/models/company';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit, OnDestroy {

  private companySub = new Subscription();
  private routeSub = new Subscription();
  private id:number = 0;
  company!:Company;

  constructor(private companyService:CompanyService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.routeSub = this.route.params.subscribe(params =>{
        this.id = +params['id'];
      }
    );
    this.companySub = this.companyService.getById(this.id).subscribe(data =>
        this.company = data.body
      )
  }
  ngOnDestroy(): void {
    this.companySub.unsubscribe();
    this.routeSub.unsubscribe();
  }
}

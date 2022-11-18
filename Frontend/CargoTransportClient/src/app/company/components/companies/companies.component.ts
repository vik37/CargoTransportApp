import { Component, OnInit, OnDestroy } from '@angular/core';
import {CompanyService} from 'src/app/company/services/company.service';
import {Subscription} from 'rxjs'
import {Company} from 'src/app/company/models/company';
import {CompanyRole} from 'src/app/company/models/enums/company-role';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css']
})
export class CompaniesComponent implements OnInit, OnDestroy {
  private subscription = new Subscription();
  role:CompanyRole = CompanyRole.host;
  companies:Company[] = [];
  constructor(private companyService:CompanyService) { }

  ngOnInit(): void {
    this.subscription = this.companyService.companies$.subscribe(
      data => this.companies = data.body
    );
  }
  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
}

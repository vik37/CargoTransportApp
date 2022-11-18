import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes,RouterModule } from '@angular/router';
import { CompaniesComponent } from './components/companies/companies.component';
import { CompanyComponent } from './components/company/company.component';
import { ShippmentComponent } from './components/shippment/shippment.component';

const route:Routes =[
  {
    path:'',component:CompaniesComponent
  },
  {
    path:':id',component:CompanyComponent
  }
]


@NgModule({
  declarations: [
    CompaniesComponent,
    CompanyComponent,
    ShippmentComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(route)
  ],
  exports:[
    RouterModule
  ]
})
export class CompanyModule { }

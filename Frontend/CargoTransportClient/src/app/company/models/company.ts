import {CompanyRole} from 'src/app/company/models/enums/company-role';
export interface Company{
  id:number,
  name:string,
  companyRegisterKey:string,
  address:string,
  postCode:number,
  city:string,
  country:string,
  link:string
  companyRole:CompanyRole
}

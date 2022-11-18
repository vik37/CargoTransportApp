import {DeliveryByDimension} from 'src/app/company/models/delivery-dimension';
import {DeliveryByWeight} from 'src/app/company/models/delivery-weight';
import { Company } from './company';
export interface ShippmentService{
  id:number,
  parcel:number,
  minimumDefaultDimension:number | null,
  maximumDefaultDimension:number | null,
  minimumDefaultWeight:number | null,
  maximumDefaultWeight:number | null,
  initialDimensionPrice:number,
  initialWeightPrice:number,
  companyId:number,
  company:Company,
  deliveryByDimensions:DeliveryByDimension[],
  deliveryByWeights:DeliveryByWeight[]
}

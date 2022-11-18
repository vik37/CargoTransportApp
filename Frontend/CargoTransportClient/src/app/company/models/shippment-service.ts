export interface ShippmentService{
  id:number,
  parcel:number,
  minimumDefaultDimension:number | null,
  maximumDefaultDimension:number | null,
  minimumDefaultWeight:number | null,
  maximumDefaultWeight:number | null,
  initialDimensionPrice:number,
  initialWeightPrice:number,
  companyId:number
}

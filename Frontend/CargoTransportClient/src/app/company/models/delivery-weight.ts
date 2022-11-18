export interface DeliveryByWeight{
  id:number,
  priceIncrease:number | null,
  less:number | null,
  bigger:number | null,
  shippmentServiceId:number,
  forEvery:boolean,
  forEveryPrice:number,
  forEveryKg:number
}

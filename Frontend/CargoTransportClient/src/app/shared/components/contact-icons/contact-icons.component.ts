import { Component } from '@angular/core';
import {faPhone, faAd, faEnvelopeSquare,faAt,faEnvelopeOpen} from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-contact-icons',
  templateUrl: './contact-icons.component.html',
  styleUrls: ['./contact-icons.component.css']
})
export class ContactIconsComponent {

  faPhone = faPhone;
  faAd = faEnvelopeOpen;
  faEnvelopeSquare = faEnvelopeSquare;
  emailCompany:string = "cargoforyou@yahoo.com";
  email:string = "mailto:";
  phoneNumber:string = "+389/77/111-222";

  constructor() { }

}

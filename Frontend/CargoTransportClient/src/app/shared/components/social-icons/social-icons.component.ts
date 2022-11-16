import { Component, OnInit, Type } from '@angular/core';
import {faFacebook,faTwitter,faYoutube} from '@fortawesome/free-brands-svg-icons';
import { IconDefinition } from '@fortawesome/fontawesome-svg-core';

@Component({
  selector: 'app-social-icons',
  templateUrl: './social-icons.component.html',
  styleUrls: ['./social-icons.component.css']
})
export class SocialIconsComponent implements OnInit {
  public fonts:IconDefinition[]=[faFacebook,faTwitter,faYoutube];
  public socialMaps = new Map([
    [faFacebook,"facebookLink"],
    [faTwitter,"twitterLink"],
    [faYoutube,"https://www.youtube.com/watch?v=GjD7x_oInx0"]
  ])
  constructor() {
   }

  ngOnInit(): void {
  }

}

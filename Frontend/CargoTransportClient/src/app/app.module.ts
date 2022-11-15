import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MainComponent } from './container/components/shared/main/main.component';
import { HeaderComponent } from './container/components/shared/header/header.component';
import { NavbarComponent } from './container/components/shared/navbar/navbar.component';
import { FooterComponent } from './container/components/shared/footer/footer.component';
import { HomeComponent } from './container/components/home/home.component';
import { AboutComponent } from './container/components/about/about.component';
import { ContactComponent } from './container/components/contact/contact.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    HeaderComponent,
    NavbarComponent,
    FooterComponent,
    HomeComponent,
    AboutComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

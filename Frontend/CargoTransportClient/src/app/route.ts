import {Routes} from "@angular/router";
import {HomeComponent} from "src/app/container/components/home/home.component";
import {AboutComponent} from "src/app/container/components/about/about.component";
import {ContactComponent} from "src/app/container/components/contact/contact.component";
import {NotFoundComponent} from "src/app/container/components/error-components/not-found/not-found.component";

export const router: Routes = [
  {
    path: '',component:HomeComponent
  },
  {
    path: 'about',component:AboutComponent
  },
  {
    path: 'shipping-services', loadChildren: () => import('./company/company.module').then(c => c.CompanyModule)
  },
  {
    path: 'contact',component: ContactComponent
  },
  {
    path: '',redirectTo:'',pathMatch:'full'
  },
  {
    path: 'not-found',component:NotFoundComponent
  }
]

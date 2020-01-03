import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ConfirmComponent } from './confirm/confirm.component';
import { ContactComponent } from './contact/contact.component';
import { AdressComponent } from './adress/adress.component';


const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'confirm', component: ConfirmComponent },
  { path: 'adress', component: AdressComponent },
  { path: 'contact', component: ContactComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

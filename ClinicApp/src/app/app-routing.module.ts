import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DoctorListComponent } from './components/doctor-list/doctor-list.component';
import { DoctorProfilComponent } from './components/doctor-profil/doctor-profil.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { PanelComponent } from './components/panel/panel.component';
import { RegisterComponent } from './components/register/register.component';

const routes: Routes = [
  {path: '', component:HomeComponent},
  {path: 'Home', component:HomeComponent},
  {path: 'SignUp', component:RegisterComponent},
  {path: 'SignIn', component:LoginComponent},
  {path: 'Panel', component:PanelComponent},
  {path: 'DoctorList', component:DoctorListComponent},
  {path: 'DoctorProfile/:id', component:DoctorProfilComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

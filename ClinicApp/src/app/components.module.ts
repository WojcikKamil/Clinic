import MaterialModule from './materials.module';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { RegisterComponent } from './components/register/register.component';
import { FormsModule }   from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './components/login/login.component';
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';
import { PanelComponent } from './components/panel/panel.component';
import { DoctorListComponent } from './components/doctor-list/doctor-list.component';
import { DoctorCardComponent } from './components/doctor-card/doctor-card.component';
import { MyPofileDialogComponent } from './components/dialog/my-pofile-dialog/my-pofile-dialog.component';
import { DoctorProfilComponent } from './components/doctor-profil/doctor-profil.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavbarComponent,
    RegisterComponent,
    LoginComponent,
    PanelComponent,
    DoctorListComponent,
    DoctorCardComponent,
    MyPofileDialogComponent,
    DoctorProfilComponent,

  ],

  imports:[
    RouterModule,
    MaterialModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,

    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    }),

    SweetAlert2Module.forRoot(),
  ],

  providers:[

  ],
})

export default class ComponentsModule {}

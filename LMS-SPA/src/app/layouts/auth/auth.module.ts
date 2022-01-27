import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';

import { AuthMainComponent } from 'src/app/components/authMain/authMain.component';
import { LandingComponent } from '../../components/landing/landing.component';
import { SignupComponent } from '../../components/signup/signup.component';
import { LoginComponent } from '../../components/login/login.component';


@NgModule({
  declarations: [
    AuthMainComponent,
    SignupComponent,
    LoginComponent,
    LandingComponent
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    SharedModule,
  ]
})
export class AuthModule { }

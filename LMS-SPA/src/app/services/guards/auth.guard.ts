import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private authService: AuthService, private router: Router) { }

  canActivate(): boolean {
    if (this.authService.isUser()) {
      this.router.navigate(['student']);
      return true;
    } else {
      console.log('يجب عليك تسجيل الدخول اولا');
      this.router.navigate(['']);
      return false;
    }
  }

}

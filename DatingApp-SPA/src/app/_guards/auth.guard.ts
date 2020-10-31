import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AlertifyService } from 'src/_services/alertify.service.service';
import { AuthService } from 'src/_services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router, private alertity: AlertifyService) {}
  canActivate(): boolean {
    if (this.authService.loggedIn()){
      return true;
    }
    
    this.alertity.error('You shall notpass!!!');
    this.router.navigate(['/home']);
    return false;
  }
  
}

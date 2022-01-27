import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {


  constructor(private fb: FormBuilder,private authService:AuthService,
              private router: Router ) { }
  public loginForm = this.fb.group({
    userName: ['', Validators.required],
    email:['test@yahoo.com'],
    password: ['', Validators.required],


  });
  ngOnInit(): void {
  }
  onSubmit() {

    console.log(this.loginForm.value);
    this.authService.login(this.loginForm.value).subscribe(res => {
      this.router.navigate(['/student']);
    });
  }

  userName() {
    return this.loginForm.get('userName');
  }
  password() {
    return this.loginForm.get('password');
  }
}

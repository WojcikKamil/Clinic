import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import AccountService from 'src/app/services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent{
  hide = true;
  model: any = {};

  constructor(
    public accountService: AccountService,
    private router : Router,
    private toastr: ToastrService,
  ) { }

  login(){
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.router.navigate(['/Home']);
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
  }
}

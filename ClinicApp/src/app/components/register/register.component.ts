import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import AccountService from 'src/app/services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  hide = true;
  model: any = {};

  constructor(private accountService: AccountService,
    private router : Router,
    private toastr: ToastrService) { }

  register() {
    this.accountService.register(this.model).subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
      this.toastr.error(error.error);
    })
  }

}

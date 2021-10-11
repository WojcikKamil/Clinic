import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import AccountService from 'src/app/services/account.service';
import { MyPofileDialogComponent } from '../dialog/my-pofile-dialog/my-pofile-dialog.component';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {
  public isMenuCollapsed = true;
  constructor(public accountService:AccountService,
    private router : Router,
    private dialog: MatDialog) { }


  ngOnInit(): void {
  }

  logout(){
    this.accountService.logout();
    this.router.navigate(['/home']);
  }

  openMyProfileDialog(): void{
    this.dialog.open(MyPofileDialogComponent)
  }

}

import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { HttpClient } from '@angular/common/http'
import { User } from '../models/user';
import { map } from 'rxjs/operators';



@Injectable({
  providedIn: 'root'
})
export default class AccountService {
  baseUrl = 'https://localhost:44383/api/';
  private currentUser = new ReplaySubject<User>(1);
  currentUser$ = this.currentUser.asObservable();

  constructor(private http: HttpClient)
  {

  }

  login(model: any){
    return this.http.post<User>(this.baseUrl + 'Account/login', model).pipe(
      map((response: User) =>{
        const user = response;
        if(user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUser.next(user);
        }
      })
    )
  }

  register(model: any) {
    return this.http.post<User>(this.baseUrl + 'Account/register', model).pipe(
      map((user: User) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUser.next(user);
        }
        return user;
      })
    )
  }

  setCurrentUser(user: User) {
    this.currentUser.next(user);
  }

  logout() {
    localStorage.removeItem('user');
    this.currentUser.next(null!);
  }

}

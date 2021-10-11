import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Member } from "../models/member";



@Injectable({
  providedIn: "root"
})

export default class DoctorsService {
  baseUrl = 'https://localhost:44383/api/';

  constructor(private http: HttpClient) {}

  getDoctors(){
    return this.http.get<Member[]>(this.baseUrl + 'Doctor');
  }

  getDoctor(id: string) {
    return this.http.get<Member>(this.baseUrl + 'Doctor/' + id);
  }
}

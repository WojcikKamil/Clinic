import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/models/member';
import DoctorsService from 'src/app/services/doctors.service';

@Component({
  selector: 'app-doctor-list',
  templateUrl: './doctor-list.component.html',
  styleUrls: ['./doctor-list.component.scss']
})
export class DoctorListComponent implements OnInit {

  doctors!: Member[];
  constructor( private doctorService: DoctorsService) { }

  ngOnInit(): void {
    this.loadDoctors();
  }

  loadDoctors(){
    this.doctorService.getDoctors().subscribe(doctors => {
      this.doctors = doctors
    })
  }
}

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Member } from 'src/app/models/member';
import DoctorsService from 'src/app/services/doctors.service';

@Component({
  selector: 'app-doctor-profil',
  templateUrl: './doctor-profil.component.html',
  styleUrls: ['./doctor-profil.component.scss']
})
export class DoctorProfilComponent implements OnInit {
  member!: Member;

  constructor(private doctorService: DoctorsService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loadDoctor();
  }

  loadDoctor() {
    this.doctorService.getDoctor(this.route.snapshot.paramMap.get('id')!).subscribe(member =>{
      this.member = member;
    })
  }
}

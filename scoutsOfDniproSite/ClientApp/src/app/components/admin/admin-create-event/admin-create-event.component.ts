import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ScoutEvent } from '../../../models/events';
import { HttpService } from '../../../services/http.service';

@Component({
  selector: 'app-admin-create-event',
  templateUrl: './admin-create-event.component.html',
  styleUrls: ['./admin-create-event.component.scss']
})
export class AdminCreateEventComponent implements OnInit {

  constructor(
    private router: Router,
    private hs: HttpService
  ) { }

  ngOnInit() {
  }
  create(name: string, text: string, type: string, date: string): void{
    this.hs.request('POST', '/api/Events/Create', {Name: name, Text: text, Type: type, Date: date}).subscribe(
      (data: ScoutEvent) => {
        this.router.navigate(['/admins/events']);
      },
      (error: HttpErrorResponse) => {}
    );
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-your-acc-nav',
  templateUrl: './your-acc-nav.component.html',
  styleUrls: ['./your-acc-nav.component.scss']
})
export class YourAccNavComponent implements OnInit {

  constructor() { }

  public activeComp: number = 1;

  clickActive(id: number): void {
    this.activeComp = id;
  }

  ngOnInit() {
  }

}

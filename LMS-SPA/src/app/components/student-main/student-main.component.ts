import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-main',
  templateUrl: './student-main.component.html',
  styleUrls: ['./student-main.component.scss']
})
export class StudentMainComponent implements OnInit {

  sideBarOpen: boolean = true;
  constructor() { }

  ngOnInit(): void {
  }
  public sideBarToggler() {
    this.sideBarOpen = !this.sideBarOpen;
   }

}

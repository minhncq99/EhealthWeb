import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-diseases-recent',
  templateUrl: './diseases-recent.component.html',
  styleUrls: ['./diseases-recent.component.css']
})
export class DiseasesRecentComponent implements OnInit {
  title:string = "Các bệnh đã xem gần đây";
  constructor() { }

  ngOnInit() {
  }

}

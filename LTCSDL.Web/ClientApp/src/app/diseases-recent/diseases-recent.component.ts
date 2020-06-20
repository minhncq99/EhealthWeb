import { Component, OnInit } from '@angular/core';
import { CookieService } from "ngx-cookie-service";
@Component({
  selector: 'app-diseases-recent',
  templateUrl: './diseases-recent.component.html',
  styleUrls: ['./diseases-recent.component.css']
})
export class DiseasesRecentComponent implements OnInit {
  title:string = "Các bệnh đã xem gần đây";
  public listDiseaseWatched:any = [];
  constructor(private _cookieService:CookieService) { }

  ngOnInit() {
    this.listDiseaseWatched = JSON.parse(sessionStorage.getItem('$watched'));
    this.listDiseaseWatched.reverse();
  }

  saveDiseaseWatched(index){

    var id = index.diseaseId;
    this._cookieService.set("Id",id);
    
  }
}

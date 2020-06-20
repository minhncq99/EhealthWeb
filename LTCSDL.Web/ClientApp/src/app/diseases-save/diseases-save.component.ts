import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { CookieService } from "ngx-cookie-service";
import {ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-diseases-save',
  templateUrl: './diseases-save.component.html',
  styleUrls: ['./diseases-save.component.css']
})
export class DiseasesSaveComponent implements OnInit {

  

 
  public item:Diseases ={
    diseaseId: 0,
    englishName: "",
    vietnameseName: "",
    symptom: "",
    numberId: 0,
    number: null,
    diseases_Users: null
  }
  public list : [];
  public listDiseases: Diseases[] = [];
  constructor(private http:HttpClient, private _cookieService: CookieService, private route: Router) { }

  ngOnInit() {
    var x : any ={
      id : 0
    };
    x.id = parseInt(this._cookieService.get("userId"));
    this.http.get(`https://localhost:44381/api/Diseases/get-disease-saved/`+x.id).subscribe(result=>{
    var   res : any;
    res = result;
    this.list = res;
    })
  }

  public myclick(x){
    console.log(x);
    this._cookieService.set("Id",x);
  }

}

interface DiseasesUsers{
      saved: boolean,
      diseaseId: number,
      userId: number,
      disease: null,
      user: null
}

interface mes {
  data: DiseasesUsers[],
  success: boolean,
  code: null,
  message: string,
  variant: string,
  title: string
}

interface Diseases{
    diseaseId: number,
    englishName: string,
    vietnameseName: string,
    symptom: string,
    numberId: number,
    number: null,
    diseases_Users: null
}



import { Component, OnInit, Inject } from '@angular/core';
import { CookieService } from "ngx-cookie-service";
import { IfStmt } from '@angular/compiler';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-i-disease',
  templateUrl: './i-disease.component.html',
  styleUrls: ['./i-disease.component.css']
})
export class IDiseaseComponent implements OnInit {
  public id: string;
  public res: any;
  public list: [];
  public value: number;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,private _cookie: CookieService) { 
    if(this.id != null || this.id != '' || this.id != undefined)
    {
      http.post(`https://localhost:44381/api/Diseases/get-all`, null).subscribe(result => {
        this.res = result;
        this.list = this.res.data;
        console.log(this.list);
      }, error => console.error(error));
    }
  }

  public check(id: number): boolean{
    this.id = this._cookie.get("Id");
    this.value = Number(this.id);
    if(this.value == id)
      return true;
    return false;
  }
  ngOnInit() {
  }

}

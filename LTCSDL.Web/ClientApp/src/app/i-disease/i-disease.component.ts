import { Component, OnInit, Inject, OnChanges } from '@angular/core';
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
  public id1:string;
  public res: any;
  public list: [];
  public value: number;
  public Diseases:any={
    data: [],
    success: true,
    code: null,
    message: "",
    variant: "success",
    title: "Success"
  }
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,private _cookie: CookieService) { 
    if(this.id != null || this.id != '' || this.id != undefined)
    {
      this.id = this._cookie.get("Id");
      this.value = Number(this.id);
    
      http.get(`https://localhost:44381/api/Diseases/get-by-id/`+this.value,this.Diseases)
      .subscribe(result => {
        this.Diseases = result;
        this.list = this.Diseases.data;
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


  ngDoCheck(){
    this.id1 = this._cookie.get("Id");
    if(this.id != this.id1)
      {
        location.reload();
        this.id=this.id1;
      }
  }
}

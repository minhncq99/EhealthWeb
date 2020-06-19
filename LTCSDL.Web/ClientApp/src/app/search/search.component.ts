import { Component, OnInit, Inject, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CookieService } from "ngx-cookie-service";
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  @Input() value: string;
  @Input() numChars: number;
  public res: any;
  public list: [];
  public isShow = false;
  private route: ActivatedRoute;
  public a: string;
  public products: any ={
    data:[]
  }
  public listDiseaseWatched:any = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private _cookieService: CookieService) {
    //if (this.value != null && this.value.length >= this.numChars) {
      http.get(`https://localhost:44381/api/Diseases/get-all`).subscribe(result => {
        this.res = result;
        this.list = this.res.data;
        console.log(this.list);
        console.log(this.value);
      }, error => console.error(error));
    //}
  }

  public check(value: string, key: string): boolean {
    if(value.length >= 3){
      var a =value.toUpperCase();
      var b =key.toUpperCase();
      if (b.indexOf(a) != -1 && a != '' && a != null && a != undefined)
          {
            return true;
          }
    }
    return false;
  }

  public show() {
    return true;
  }

  public myclick(item : Diseased): void {
    console.log(typeof(item.diseaseId));
    this.a = String(item.diseaseId);
    console.log(this.a);
    console.log(typeof(this.a));
    this._cookieService.set("Id",this.a);
    this.value = "";
    this.listDiseaseWatched = this.listDiseaseWatched || [];
    this.listDiseaseWatched.push(item);
    sessionStorage.setItem('$watched', JSON.stringify(this.listDiseaseWatched));
  }

  ngOnInit() {
    this.listDiseaseWatched = JSON.parse(sessionStorage.getItem('$watched'));
  }
}

interface Diseased{
  numberId: number,
  diseaseId: number,
  englishName: string,
  vietnameseName: string,
  symptom: string
}
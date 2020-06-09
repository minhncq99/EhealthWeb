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

  public myclick(id: number): void {
    console.log(typeof(id));
    this.a = String(id);
    console.log(this.a);
    console.log(typeof(this.a));
    this._cookieService.set("Id",this.a);
    this.value = "";
  }

  ngOnInit() {
    
  }
}

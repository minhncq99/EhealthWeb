import { Component, OnInit, OnChanges } from '@angular/core';
import { CookieService } from "ngx-cookie-service";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {Router} from '@angular/router'
@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent implements OnInit {
  signin = "";
  createAccount ="";
  public isShow: boolean;
  constructor(private _cookieService: CookieService, private route: Router, private http: HttpClient) { }

  ngOnInit() {
    
  }
  showDropDownMenu(): boolean{
    this.signin = this._cookieService.get("login");
    if(this.signin === "true" || this.createAccount === "true")
      return true;
    return false;
  }

  deleteCookie(){
    sessionStorage.clear();
    this._cookieService.delete("login");
    this._cookieService.delete("New_Account");
    this._cookieService.delete("userId");
    this.route.navigate(['']);
  }
}

interface typeUser{
  typeUser : number
}
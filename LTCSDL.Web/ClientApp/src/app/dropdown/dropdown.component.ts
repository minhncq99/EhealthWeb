import { Component, OnInit } from '@angular/core';
import { CookieService } from "ngx-cookie-service";

@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent implements OnInit {
  signin = "";
  createAccount ="";
  
  constructor(private _cookieService: CookieService) { }

  ngOnInit() {
  }
  showDropDownMenu(): boolean{
    this.signin = this._cookieService.get("login");
    this.createAccount = this._cookieService.get("New_Account");
    if(this.signin === "true" || this.createAccount === "true")
      return true;
    return false;
  }

  deleteCookie(){
    this._cookieService.delete("login");
    this._cookieService.delete("New_Account");
    this._cookieService.delete("userId");
  }
}

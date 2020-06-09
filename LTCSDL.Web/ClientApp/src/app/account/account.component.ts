import { Component, OnInit } from '@angular/core';
import { CookieService } from "ngx-cookie-service";
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
  public users : any={
    data:[], 
    success: true,
    code: null,
    message: "",
    variant: "success",
    title: "Success"
  }

  public user: any={
    data: [],
    success: true,
    code: null,
    message: "",
    variant: "success",
    title: "Success"
  }
  
  public account:any={
    userId: -1,
    fullName: "",
    userName: "",
    password: "",
    email: "",
    job: "",
    typeUser: -1,
    diseases_Users: -1
  }
  constructor(private _cookieService: CookieService,private http: HttpClient) { 
    var id = this._cookieService.get("userId");
    console.log(id);
    this.http.get(`https://localhost:44381/api/Users/get-by-user-id/`+ id,this.users).subscribe(
      result=>{
        var res : any;
        res = result;
        this.user = res.data;
        this.account = this.user.data;
        console.log(this.account);
      }
    );
  }

  ngOnInit() {
  }

}

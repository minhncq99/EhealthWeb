import { Component,OnInit,Input } from '@angular/core'
import { CookieService } from "ngx-cookie-service";
import { HttpClient,HttpHeaders } from '@angular/common/http';
import {ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-form-component',
  templateUrl: './form.component.html'
})
export class FormComponent {
  public id: number;
  isShow = true;
  @Input() btnSignin: boolean;
  @Input() btnSigout: boolean;
  @Input() btnEdit: boolean;
  @Input() personalInformation: boolean;
  @Input() accountInformation: boolean;
  @Input() check: boolean;
  show = this.isShow;
  goToComponent: boolean;
  public list : any [];
  public users: any ={
    data: [],
    success: true,
    code: null,
    message: "",
    variant: "success",
    title: "Success"
  }


  public user: any ={
    userId : -1,
    fullName :  "",
    email : "",
    job : "",
    userName: "",
    password : ""

  }
  public user1: any ={
    userId : 0,
    fullName :  "",
    email : "",
    job : "",
    userName: "",
    password : "",
    type: 0
  }
  public showUser = false;
  public useraccount: any ={
    userId : -1,
    fullName :  null,
    email : null,
    job : null,
    userName: null,
    password : null

  }
  public fullName :string;
  public email: string;
  public job: string;
  public userName: string;
  public password: string; 

  public isfullName :boolean;
  public isemail: boolean;
  public isuserName: boolean;
  public ispassword: boolean; 

  public showAccount : boolean;
  constructor(private _cookieService: CookieService,private http: HttpClient, private route: Router) {
    http.get(`https://localhost:44381/api/Users/get-all`).subscribe(result =>{
      this.users =result;
      console.log(this.users.data)
    })
    this.isfullName = false;
    this.isemail = false;
    this.isuserName = false;
    this.ispassword = false;
    //this.checkID();
    this.checkUser();
  }
  
  public signin(): boolean {
    for(var i of this.users.data)
        if(this.user.userName == i.userName && this.user.password == i.password)
          {
            this._cookieService.set("login","true");
            this._cookieService.set("userId",i.userId);
            return true;
          }
    return false;
  }

  public checkUser(): void{
    this.id = parseInt(this._cookieService.get("userId"));
    if(this.id > -1){
      this.showUser = false;
      console.log(typeof(this.id));
      this.http.get(`https://localhost:44381/api/Users/get-by-user-id/`+ this.id,this.users).subscribe(
        result=>{
          console.log(result);
          this.users = result;
          this.user = this.users.data;
          console.log(this.user);
        })
    }

    //for(var i of this.users.data)
  }

  public createAccount() {
    var x = this.user;
    this.fullName =this.user.fullName;
    console.log(this.fullName);
    console.log(x.fullName);
    x.fullName = String(x.fullName);   
    this.http.post(`https://localhost:44381/api/Users/create`,x).subscribe(result => {
        this.users = result;
        console.log(this.users.success);
        if(this.users.success == true)
          this.route.navigate(['']);
        else{
          console.log(this.users.success);
          this.kiemtra(this.users.message);
          this.route.navigate(['/create-account']);
        }
    })
    
    
  }

  public checkUserName(): boolean{
    console.log(this.user.userName);
    if(this.user.userName != undefined)
      this.useraccount.userName = this.user.userName;
    console.log(this.useraccount.userName);
    for(var i of this.users.data)
      if(this.useraccount.userName == i.userName)
        {
          return false;
        }
    if(this.useraccount.userName == "" || this.useraccount.userName == null)
      return false;
    return true;
  }

  public checkEmail(): boolean{
    console.log(this.user.email);
    if(this.user.email != undefined)
      this.useraccount.email = this.user.email;
    console.log(this.useraccount.email);
    for(var i of this.users.data)
      if(this.useraccount.email == i.email)
        {
          return false;
        }
    if(this.useraccount.email == "" || this.useraccount.email == null)
      return false;
    return true;
  }
  public Edit(){
    console.log(this.showUser);
    this.user.userId = parseInt(this._cookieService.get("userId"));
    this.http.put(`https://localhost:44381/api/Users/update`,this.user).subscribe(result=>{
      this.users = result;
      if(this.users.success == true){
        alert("Ban da chinh sua thanh cong");
        this.user = this.users.data;
        location.reload();
      }
      else
      this.kiemtra(this.users.message);
    })
  }

  public checkID(){
    this.id = parseInt(this._cookieService.get("userId"));
    if(this.id != null || this.id != undefined || this.id != -1)
     this.showUser = true;
    this.showUser = false;
  }

  public kiemtra(x){
    this.isfullName = false;
    this.ispassword = false;
    this.isemail = false;
    if(x =="Username is not valid")
      this.isuserName = true;
    else if(x == "Email is not valid!")
      this.isemail = true;
    else if(x == "Password is not valid!")
      this.ispassword = true;
  }
}
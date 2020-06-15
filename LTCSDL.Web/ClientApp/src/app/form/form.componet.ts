import { Component,OnInit,Input } from '@angular/core'
import { CookieService } from "ngx-cookie-service";
import { HttpClient,HttpHeaders } from '@angular/common/http';

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

  public showAccount : boolean;
  constructor(private _cookieService: CookieService,private http: HttpClient) {
    http.get(`https://localhost:44381/api/Users/get-all`).subscribe(result =>{
      this.users =result;
      console.log(this.users.data)
    })
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
    console.log(this.user.fullName);
    if(this.checkUserName()== false){
      alert("Ten tai khong duoc trung ve de trong!");
      return;
    }
          
    if(this.checkEmail()== false){
      alert("Email khong duoc trung va de trong!");
      return;
    }
          
    this.http.post(`https://localhost:44381/api/Users/create`,x).subscribe(result => {
      var res: any = result;
      this.user = res.data;
      console.log(this.user.success);
      console.log(typeof(this.user.success));
      
      if(this.user.success == true){
        console.log(this.user);
        this.users = this.users.data;
        console.log(this.users);
        console.log(res.data);
        this.user = null;
        this.users =null;
        this.showUser =true;
        this._cookieService.set(this.user.password,this.fullName);
        this._cookieService.set("New_Account","true");
       
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
    this.http.put(`https://localhost:44381/api/Users/update`,this.user).subscribe(result=>{
      var res: any = result;
      this.users = res.data;
      if(this.users.success){
        console.log(this.users);
        this.users = this.users.data;
        console.log(this.users);
        console.log(res.data);
        alert("Ban da chinh sua thanh cong!");
        location.reload();
      }
    })
  }

  public checkID(){
    this.id = parseInt(this._cookieService.get("userId"));
    if(this.id != null || this.id != undefined || this.id != -1)
     this.showUser = true;
    this.showUser = false;
  }
}
import { Component, OnInit, Inject, OnChanges } from '@angular/core';
import { CookieService } from "ngx-cookie-service";
import { IfStmt } from '@angular/compiler';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-i-disease',
  templateUrl: './i-disease.component.html',
  styleUrls: ['./i-disease.component.css']
})
export class IDiseaseComponent implements OnInit {
  public id: string;
  public id1:string;
  public list:  Diseases={
    chapterId:0,
    chapterName:"",
    groupId: 0,
    groupName: "",
    numberId: 0,
    numberName: "",
    diseaseId: 0,
    englishName: "",
    vietnameseName: "",
}
;
  public value: number;
  public isShow: boolean;

  public create: DiseasesUsers ={
    diseaseId: 0,
    userId: 0,
    saved: false
  };
  public Diseases:any={
    data: [],
    success: true,
    code: null,
    message: "",
    variant: "success",
    title: "Success"
  }
  constructor(private http: HttpClient,https: HttpClient, 
    @Inject('BASE_URL') baseUrl: string,private _cookie: CookieService) { 
      this.id = this._cookie.get("Id");
      this.value = parseInt(this.id);
      this.create.userId = parseInt(this._cookie.get("userId"));
      if(isNaN(this.create.userId) == true)
        this.isShow = true;
    if(this.id != null || this.id != '' || this.id != undefined)
    {
      
      http.get(`https://localhost:44381/api/Diseases/get-i-disease/`+this.value)
      .subscribe(result => {
        var res : any;
        res = result;
        this.list = res;
        
        console.log(this.list);
      }, error => console.error(error));
      
      if(this.create.userId === NaN){
        this.create.userId = 0;
      };

      var a: any={
        id : this.value,
        userId : this.create.userId
      };
      console.log(a.id);
      console.log(a.userId);
      https.get(`https://localhost:44381/api/DiseasesUsers/get-by-id/`+a.userId+"/"+a.id
      ,this.Diseases)
      .subscribe(result=>{
          this.Diseases = result;
          console.log(this.Diseases);
          console.log(this.Diseases.data);
          if(this.Diseases.data == null)
            this.isShow = true;
          else
            this.isShow = false;
      });
      
      
    };
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

  public isSave(){
    this.create.diseaseId = parseInt(this._cookie.get("Id"));
    this.create.userId = parseInt(this._cookie.get("userId"));
    this.create.saved = true;
    if(this.create.userId === NaN)
      window.alert("Ban chu dang nhap!");
    else{
        this.http.post(`https://localhost:44381/api/DiseasesUsers/create`,this.create).subscribe(result=>{
          var res: any;
          res = result;
          this.isShow = !this.isShow;
        })
    }
    
  }

  public isNotSave(){
    
  
    this.create.diseaseId = parseInt(this._cookie.get("Id"));
    this.create.userId = parseInt(this._cookie.get("userId"));
    console.log( parseInt(this._cookie.get("userId")));
    console.log(this.create.userId);
    this.create.saved = false;
    if(this.create.userId === NaN)
    window.alert("Ban chu dang nhap!")
    else{
        const httpOptions1 = {
          headers: new HttpHeaders({ 'Content-Type': 'application/json' }), body: this.create
      };
        this.http.delete(`https://localhost:44381/api/DiseasesUsers/delete`,httpOptions1)
        .subscribe(result=>{
          var res: any;
          res = result;
          this.isShow = !this.isShow;
        })
    }
  }

}

interface DiseasesUsers{
  diseaseId: number,
  userId: number,
  saved: boolean
}

interface Diseases{
    chapterId:number,
    chapterName:string,
    groupId: number,
    groupName: string,
    numberId: number,
    numberName: string,
    diseaseId: number,
    englishName: string,
    vietnameseName: string,
}


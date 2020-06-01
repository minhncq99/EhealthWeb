import { HttpClient } from '@angular/common/http';
import { Component, OnInit, Inject } from '@angular/core';

@Component({
  selector: 'app-disease-catalog',
  templateUrl: './disease-catalog.component.html',
  styleUrls: ['./disease-catalog.component.css']
})
export class DiseaseCatalogComponent implements OnInit {
  private title:string = 'Danh mục bệnh';
  private isShowChapter:boolean = true;
  private isShowGroup:boolean = false;
  private isShowNumber:boolean = false;
  private isShowDiseases:boolean = false;
  public res: any;
  public listChapter: [];
  public listGroup: [];
  public listSTT: [];
  public listDisease: [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseurl: string ) {
    http.get("https://localhost:44381/" + "api/Chapters/get-all").subscribe(result =>{
      this.res = result;
      this.listChapter = this.res.data;
      console.log(this.listChapter);
    }, error => console.error(error));

    http.get("https://localhost:44381/" + "api/Groups/get-all").subscribe(result =>{
      this.res = result;
      this.listGroup = this.res.data;
      console.log(this.listGroup);
    }, error => console.error(error));

    http.get("https://localhost:44381/" + "api/Numbers/get-all").subscribe(result =>{
      this.res = result;
      this.listSTT = this.res.data;
      console.log(this.listSTT);
    }, error => console.error(error));

    http.get("https://localhost:44381/" + "api/Diseases/get-all").subscribe(result =>{
      this.res = result;
      this.listDisease = this.res.data;
      console.log(this.listDisease);
    }, error => console.error(error));
  }

  ngOnInit() {

  }

  showBodyChapter(){
    if(this.isShowChapter == false){
      this.isShowChapter = true;
      this.isShowGroup = false;
      this.isShowNumber = false;
      this.isShowDiseases = false;
    }
  }
  showBodyGroup(){
    if(this.isShowGroup == false){
      this.isShowChapter = false;
      this.isShowGroup = true;
      this.isShowNumber = false;
      this.isShowDiseases = false;
    }
  }
  showBodyNumber(){
    if(this.isShowNumber == false){
      this.isShowChapter = false;
      this.isShowGroup = false;
      this.isShowNumber = true;
      this.isShowDiseases = false;
    }
  }
  showBodyDiseases(){
    if(this.isShowDiseases == false){
      this.isShowChapter = false;
      this.isShowGroup = false;
      this.isShowNumber = false;
      this.isShowDiseases = true;
    }
  } 
  
  public styleMenuHide = {
    color: "black",
    backgroundColor: "#E7E7E7"
  }
  public styleMenuShow = {
    color: "white",
    backgroundColor: "#1576C4"
  }
}


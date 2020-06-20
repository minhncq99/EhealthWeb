import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-group-detail',
  templateUrl: './group-detail.component.html',
  styleUrls: ['./group-detail.component.css']
})
export class GroupDetailComponent implements OnInit {

  public group:any={
    groupId : 0,
    name : "",
    chapterId: 0
  }
  public res:any;
  public listNumber: [] = [];
  title:string = "gồm:"
  
  constructor(private http: HttpClient, @Inject('BASE_URL') baseurl: string) { 
  }

  ngOnInit() {
    this.group = JSON.parse(sessionStorage.getItem('$dataGroup'));
    this.http.get("https://localhost:44381/" + "api/Numbers/get-by-group-id/" + this.group.groupId).subscribe(result =>{
        this.res = result;
        this.listNumber = this.res.data;
      }, error => console.error(error));
  }

  saveNumberData(index){
    sessionStorage.setItem('$dataNumber', JSON.stringify(index));
  }
}

import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-chapter-detail',
  templateUrl: './chapter-detail.component.html',
  styleUrls: ['./chapter-detail.component.css']
})
export class ChapterDetailComponent implements OnInit {

  public chapter:any={
    chapterId : 0,
    name : ""
  }
  public res:any;
  public listGroup: [];
  title:string = "gồm các nhóm bệnh sau:"
  
  constructor(private http: HttpClient, @Inject('BASE_URL') baseurl: string) { 
  }

  ngOnInit() {
    this.chapter = JSON.parse(sessionStorage.getItem('$dataChapter'));
    this.http.get("https://localhost:44381/" + "api/Groups/get-by-chapter-id/" + this.chapter.chapterId).subscribe(result =>{
        this.res = result;
        this.listGroup = this.res.data;
      }, error => console.error(error));
  }

  saveGroupData(index){
    sessionStorage.setItem('$dataGroup', JSON.stringify(index));
  }


}

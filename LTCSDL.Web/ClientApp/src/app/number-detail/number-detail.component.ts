import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-number-detail',
  templateUrl: './number-detail.component.html',
  styleUrls: ['./number-detail.component.css']
})
export class NumberDetailComponent implements OnInit {

  public number:any={
    numberId : 0,
    name : "",
    groupId: 0
  }
  public res:any;
  public listDisease: [];
  public listDiseaseWatched:any = [];
  title:string = "gồm các bệnh sau:"
  
  constructor(private http: HttpClient, @Inject('BASE_URL') baseurl: string) { 
  }

  ngOnInit() {
    this.number = JSON.parse(sessionStorage.getItem('$dataNumber'));
    console.log(this.number)
    this.http.get("https://localhost:44381/" + "api/Diseases/get-by-number-id/" + this.number.numberId).subscribe(result =>{
        this.res = result;
        this.listDisease = this.res.data.data;
        console.log(this.listDisease);
      }, error => console.error(error));
      this.listDiseaseWatched = JSON.parse(sessionStorage.getItem('$watched'));
  }

  saveDiseaseWatched(index){
    this.listDiseaseWatched.push(index);
    sessionStorage.setItem('$watched', JSON.stringify(this.listDiseaseWatched));
  }

}

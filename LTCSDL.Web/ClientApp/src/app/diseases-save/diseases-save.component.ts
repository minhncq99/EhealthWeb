import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Component({
  selector: 'app-diseases-save',
  templateUrl: './diseases-save.component.html',
  styleUrls: ['./diseases-save.component.css']
})
export class DiseasesSaveComponent implements OnInit {

  public res : mes = {
    data: [],
    success: false,
    code: null,
    message: "",
    variant: "",
    title: ""
  };

  public item:Diseases ={
    diseaseId: 0,
    englishName: "",
    vietnameseName: "",
    symptom: "",
    numberId: 0,
    number: null,
    diseases_Users: null
  }
  public listDiseases: Diseases[] = [];
  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.http.get(`https://localhost:44381/api/DiseasesUsers/get-all`).subscribe(result=>{
      var r : any;
      r = result;
      this.res = r;
      console.log(this.res.data);
      this.res.data.forEach(index =>{
        this.http.get(`https://localhost:44381/api/Diseases/get-by-id/`+index.diseaseId).subscribe(result=>{
          var h : any;
          h = result;
          this.item = h.data;
          this.listDiseases.push(this.item);
        });
      });
    });
    console.log(this.listDiseases);
  }

}

interface DiseasesUsers{
      saved: boolean,
      diseaseId: number,
      userId: number,
      disease: null,
      user: null
}

interface mes {
  data: DiseasesUsers[],
  success: boolean,
  code: null,
  message: string,
  variant: string,
  title: string
}

interface Diseases{
    diseaseId: number,
    englishName: string,
    vietnameseName: string,
    symptom: string,
    numberId: number,
    number: null,
    diseases_Users: null
}



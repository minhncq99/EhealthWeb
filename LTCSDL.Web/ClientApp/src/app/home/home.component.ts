import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent{
  public lst :string[] = ['1','123','4','99','872','682'];
  public value: string = "";
  public numChars:number=3;
  public res: any;
  public list : [];

  public title = 'Browser market shares at a specific website, 2014';
  public type = 'PieChart';
  public data = [
      ['Firefox', 45.0],
      ['IE', 26.8],
      ['Chrome', 12.8],
      ['Safari', 8.5],
      ['Opera', 6.2],
      ['Others', 0.7] 
   ];
   public columnNames = ['Browser', 'Percentage'];
   public options = {
    colors: ['#e0440e', '#e6693e', '#ec8f6e', '#f3b49f', '#f6c7b6'], is3D: true
 };
 public width = 550;
 public height = 400;
 public ck = false;
 public rs : mes = {
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
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.post(`https://localhost:44381/api/Diseases/get-all`,null).subscribe(result => {
      this.res = result;
      this.list = this.res.data;
      console.log(this.list);
      
    }, error => console.error(error));
 
  }
    
  public check(value: string, key: string): boolean{
    if(key.indexOf(value) != -1 && value != '' && value != null && value != undefined) 
      return true;
    return false;
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

interface ct{
  mact: string,
  macv: number,
  makn: number[],
  matd: number,
}
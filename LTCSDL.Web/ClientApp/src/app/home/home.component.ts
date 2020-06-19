import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent{
  public value: string = "";
  public numChars:number=3;
  public res: any;
  public list : [];

  
 public ck = false;
 public rs : mes = {
  data: [],
  success: false,
  code: null,
  message: "",
  variant: "",
  title: ""
};


public arrayList: [];
public listDiseases: Diseases[] = [];
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.post(`https://localhost:44381/api/Diseases/get-all`,null).subscribe(result => {
      this.res = result;
      this.list = this.res.data;
      console.log(this.list);
      
    });
    http.get(`https://localhost:44381/api/DiseasesUsers/get-count-disease`).subscribe(result=>{
    console.log(result);
    var r1 : any = result;
    var r: Diseases[] = r1;
    this.drawChart(r);
    })
  }
    
  public check(value: string, key: string): boolean{
    if(key.indexOf(value) != -1 && value != '' && value != null && value != undefined) 
      return true;
    return false;
  }

  public drawChart(chartdata) {
    var arrData = [["VietName","Benh"]];
    chartdata.forEach(element => {
      var item = [];
      item.push(element.vietnameseName);
      item.push(element.diseaseId);
      arrData.push(item);
    });
    var data = google.visualization.arrayToDataTable(arrData);

    var options = {
      title: 'Bieu do cac benh duoc luu'
    };

    var chart = new google.visualization.PieChart(document.getElementById('piechart'));

    chart.draw(data, options);
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
data: Diseases[],
success: boolean,
code: null,
message: string,
variant: string,
title: string
}

interface Diseases{
diseaseId: number,
vietnameseName: string,
}

interface ct{
  mact: string,
  macv: number,
  makn: number[],
  matd: number,
}
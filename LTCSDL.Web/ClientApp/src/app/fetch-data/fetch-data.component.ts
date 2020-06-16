import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { stringify } from 'querystring';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  products:any={
    data:[],
  }
  public product: any={
    id: 1,
    key: 'a' 
  }
  public y: ct ={
    mact: "a",
    macv: 15,
    makn:[],
    matd: 1
  }
  public listy: ct[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    var x = this.product;
    http.get(baseUrl + 'weatherforecast',x).subscribe(result => {
      this.product = result;
    }, error => console.error(error));

    
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

interface ct{
  mact: string,
  macv: number,
  makn: number[],
  matd: number,
}

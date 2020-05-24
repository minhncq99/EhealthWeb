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

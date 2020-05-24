import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public lst :string[] = ['1','123','4','99','872','682'];
  public value: string = "";
  public numChars:number=3;
  public res: any;
  public list : [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.post(`https://localhost:44381/api/Diseases/get-all`,null).subscribe(result => {
      this.res = result;
      this.list = this.res.data;
      console.log(this.list);
    }, error => console.error(error));}
    
  public check(value: string, key: string): boolean{
    if(key.indexOf(value) != -1 && value != '' && value != null && value != undefined) 
      return true;
    return false;
  }
}

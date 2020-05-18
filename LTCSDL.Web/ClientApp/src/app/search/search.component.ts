import { Component, OnInit, Inject,Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  @Input() value : string;
  public res: any;
  public list : [];
  public isShow = false;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.post(`https://localhost:44381/api/Diseases/get-all`,null).subscribe(result => {
      this.res = result;
      this.list = this.res.data;
      console.log(this.list);
      console.log(this.value);
    }, error => console.error(error));
  }

  public check(value: string, key: string): boolean{
    if(key.indexOf(value) != -1 && value != '' && value != null && value != undefined) 
      return true;
    return false;
  }

  public show(){
    return true;
  }
  ngOnInit() {
  }

}

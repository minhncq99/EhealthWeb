import { Component,OnInit,Input } from '@angular/core'
import { CookieService } from "ngx-cookie-service";
@Component({
  selector: 'app-form-component',
  templateUrl: './form.component.html'
})
export class FormComponent {
  isShow = true;
  @Input() btnSignin: boolean;
  @Input() btnSigout: boolean;;
  @Input() btnEdit: boolean;
  @Input() personalInformation: boolean;
  @Input() accountInformation: boolean;
  @Input() check: boolean;
  show = this.isShow;

  constructor(private _cookieService: CookieService) {}
 
  signin(): void {
    this._cookieService.set("login","true");
  }

  createAccount(): void {
    this._cookieService.set("New_Account","true");
  }

}
import { Component, Input } from '@angular/core'
@Component({
  selector: 'app-form-component',
  templateUrl: './form.component.html'
})
export class FormComponent {
  @Input() isShow: boolean;
  show = this.isShow;
}
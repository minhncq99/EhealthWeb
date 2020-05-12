import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent implements OnInit {
  isShow = true;
  constructor() { }

  ngOnInit() {
  }
  showDropDownMenu(){
    this.isShow = !this.isShow
  }
}

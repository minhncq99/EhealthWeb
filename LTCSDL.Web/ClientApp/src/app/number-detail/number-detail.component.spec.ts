import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NumberDetailComponent } from './number-detail.component';

describe('NumberDetailComponent', () => {
  let component: NumberDetailComponent;
  let fixture: ComponentFixture<NumberDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NumberDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NumberDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

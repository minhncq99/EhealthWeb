import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IDiseaseComponent } from './i-disease.component';

describe('IDiseaseComponent', () => {
  let component: IDiseaseComponent;
  let fixture: ComponentFixture<IDiseaseComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IDiseaseComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IDiseaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

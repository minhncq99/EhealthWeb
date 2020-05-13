import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DiseasesSaveComponent } from './diseases-save.component';

describe('DiseasesSaveComponent', () => {
  let component: DiseasesSaveComponent;
  let fixture: ComponentFixture<DiseasesSaveComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DiseasesSaveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DiseasesSaveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

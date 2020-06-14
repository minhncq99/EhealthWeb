import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DiseaseCatalogComponent } from './disease-catalog.component';

describe('DiseaseCatalogComponent', () => {
  let component: DiseaseCatalogComponent;
  let fixture: ComponentFixture<DiseaseCatalogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DiseaseCatalogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DiseaseCatalogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

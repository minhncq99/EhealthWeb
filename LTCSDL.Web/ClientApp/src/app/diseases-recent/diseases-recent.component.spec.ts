import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DiseasesRecentComponent } from './diseases-recent.component';

describe('DiseasesRecentComponent', () => {
  let component: DiseasesRecentComponent;
  let fixture: ComponentFixture<DiseasesRecentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DiseasesRecentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DiseasesRecentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

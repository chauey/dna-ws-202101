import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NetflixDashboardContainerComponent } from './netflix-dashboard-container.component';

describe('NetflixDashboardContainerComponent', () => {
  let component: NetflixDashboardContainerComponent;
  let fixture: ComponentFixture<NetflixDashboardContainerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NetflixDashboardContainerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NetflixDashboardContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

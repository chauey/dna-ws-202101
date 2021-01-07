import { LocalizationPipe, LocalizationService } from '@abp/ng.core';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ShowService } from '@proxy/shows';

import { ShowComponent } from './show.component';

describe('ShowComponent', () => {
  let component: ShowComponent;
  let fixture: ComponentFixture<ShowComponent>;
  const mockShowService = {};
  const mockLocalizationService = jasmine.createSpyObj('LocalizationService', ['instant']);

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ShowComponent, LocalizationPipe],
      providers: [
        { provide: LocalizationService, useValue: mockLocalizationService },
        { provide: ShowService, useValue: mockShowService },
      ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

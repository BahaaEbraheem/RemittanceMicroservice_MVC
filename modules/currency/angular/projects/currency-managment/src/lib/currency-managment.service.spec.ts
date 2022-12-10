import { TestBed } from '@angular/core/testing';
import { CurrencyManagmentService } from './services/currency-managment.service';
import { RestService } from '@abp/ng.core';

describe('CurrencyManagmentService', () => {
  let service: CurrencyManagmentService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(CurrencyManagmentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

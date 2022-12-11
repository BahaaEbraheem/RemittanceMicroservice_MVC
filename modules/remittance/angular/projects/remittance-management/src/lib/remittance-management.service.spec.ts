import { TestBed } from '@angular/core/testing';
import { RemittanceManagementService } from './services/remittance-management.service';
import { RestService } from '@abp/ng.core';

describe('RemittanceManagementService', () => {
  let service: RemittanceManagementService;
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
    service = TestBed.inject(RemittanceManagementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { RemittanceManagementComponent } from './components/remittance-management.component';
import { RemittanceManagementService } from '@remittance-management';
import { of } from 'rxjs';

describe('RemittanceManagementComponent', () => {
  let component: RemittanceManagementComponent;
  let fixture: ComponentFixture<RemittanceManagementComponent>;
  const mockRemittanceManagementService = jasmine.createSpyObj('RemittanceManagementService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [RemittanceManagementComponent],
      providers: [
        {
          provide: RemittanceManagementService,
          useValue: mockRemittanceManagementService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RemittanceManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

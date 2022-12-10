import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { CurrencyManagmentComponent } from './components/currency-managment.component';
import { CurrencyManagmentService } from '@currency-managment';
import { of } from 'rxjs';

describe('CurrencyManagmentComponent', () => {
  let component: CurrencyManagmentComponent;
  let fixture: ComponentFixture<CurrencyManagmentComponent>;
  const mockCurrencyManagmentService = jasmine.createSpyObj('CurrencyManagmentService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [CurrencyManagmentComponent],
      providers: [
        {
          provide: CurrencyManagmentService,
          useValue: mockCurrencyManagmentService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CurrencyManagmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

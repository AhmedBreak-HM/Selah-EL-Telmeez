import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AuthMainComponent } from './authMain.component';


describe('AuthMainComponent', () => {
  let component: AuthMainComponent;
  let fixture: ComponentFixture<AuthMainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AuthMainComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AuthMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

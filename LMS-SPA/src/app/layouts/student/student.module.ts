import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StudentRoutingModule } from './student-routing.module';
import { StudentMainComponent } from '../../components/student-main/student-main.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { SubjectComponent } from '../../components/subject/subject.component';
import { SubjectService } from 'src/app/services/subject.service';


@NgModule({
  declarations: [
    StudentMainComponent,
    SubjectComponent
  ],
  imports: [
    CommonModule,
    StudentRoutingModule,
    SharedModule,
    
  ],
  providers:[SubjectService]
})
export class StudentModule { }

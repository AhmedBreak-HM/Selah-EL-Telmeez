import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentMainComponent } from 'src/app/components/student-main/student-main.component';
import { SubjectComponent } from 'src/app/components/subject/subject.component';

const routes: Routes = [
  {
    path: '', component: StudentMainComponent,
    children: [
      { path: '', component: SubjectComponent },
      { path: 'subject', component: SubjectComponent },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StudentRoutingModule { }

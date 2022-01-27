import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './services/guards/auth.guard';

const routes: Routes = [
  { path: '', loadChildren: () => import('./layouts/auth/auth.module').then(m => m.AuthModule) },
  { path: 'auth', loadChildren: () => import('./layouts/auth/auth.module').then(m => m.AuthModule) },
  { path: 'student',canActivate:[AuthGuard], loadChildren: () => import('./layouts/student/student.module').then(m => m.StudentModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

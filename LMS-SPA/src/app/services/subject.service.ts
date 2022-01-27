import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Subject } from '../models/Subject';

@Injectable({
  providedIn: 'root'
})
export class SubjectService {

  baseURl: string = environment.baseUrl + 'Subject/GetSubjects';
  constructor(private http: HttpClient) { }
getSubject(gradeId:number,termId:number): Observable<Subject[]> {
  let params = new HttpParams();
    params = params.append('gradeId', gradeId.toString());
    params = params.append('termId', termId.toString());
  return this.http.get<Subject[]>(this.baseURl).pipe();

}
 
}
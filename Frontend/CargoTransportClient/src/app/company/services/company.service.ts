import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Response } from 'src/app/shared/models/response';
import {tap,map,Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  private companyUri = environment.apiUrl+"company";
  constructor(private http: HttpClient) { }

  companies$ = this.http.get<Response>(this.companyUri)
                    .pipe(
                      tap(data => console.log('companies',data.body)),
                      map(data => data)
                    );
  getById(id:number): Observable<Response>{
    return this.http.get<Response>(this.companyUri+id).pipe(
      map(data => data)
    )
  }
}

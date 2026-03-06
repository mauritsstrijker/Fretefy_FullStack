import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { Cidade } from '../models/cidade.model';

@Injectable({
  providedIn: 'root'
})
export class CidadeService {
  private readonly apiUrl = `${environment.apiUrl}/api/cidade`;

  constructor(private http: HttpClient) {}

  list(): Observable<Cidade[]> {
    return this.http.get<Cidade[]>(this.apiUrl);
  }
}
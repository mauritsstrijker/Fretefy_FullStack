import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { environment } from '../../../../environments/environment';
import { ToastService } from '../../../shared/toast/toast.service';
import { Regiao } from '../models/regiao.model';
import { CreateRegiaoRequest } from '../requests/create-regiao.request';
import { UpdateRegiaoRequest } from '../requests/update-regiao.request';

@Injectable({
  providedIn: 'root'
})
export class RegiaoService {
  private readonly apiUrl = `${environment.apiUrl}/api/regiao`;

  private _regioes$ = new BehaviorSubject<Regiao[]>([]);
  regioes$ = this._regioes$.asObservable();

  constructor(private http: HttpClient, private toastService: ToastService) {}

  loadAll(): void {
    this.http.get<Regiao[]>(this.apiUrl).subscribe(regioes => 
      this._regioes$.next(regioes)
    );
  }

  getById(id: string): Observable<Regiao> {
    return this.http.get<Regiao>(`${this.apiUrl}/${id}`);
  }

  create(request: CreateRegiaoRequest): Observable<{ id: string }> {
    return this.http.post<{ id: string }>(this.apiUrl, request).pipe(
      tap(() => {
        this.loadAll();
        this.toastService.success('Região criada com sucesso!');
      }),
      catchError(err => {
        this.toastService.error('Erro ao criar região.');
        return throwError(err);
      })
    );
  }

  update(id: string, request: UpdateRegiaoRequest): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${id}`, request).pipe(
      tap(() => {
        this.loadAll();
        this.toastService.success('Região atualizada com sucesso!');
      }),
      catchError(err => {
        this.toastService.error('Erro ao atualizar região.');
        return throwError(err);
      })
    );
  }

  activate(id: string): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${id}/activate`, {}).pipe(
      tap(() => {
        this.loadAll();
        this.toastService.success('Região ativada com sucesso!');
      }),
      catchError(err => {
        this.toastService.error('Erro ao ativar região.');
        return throwError(err);
      })
    );
  }

  deactivate(id: string): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${id}/deactivate`, {}).pipe(
      tap(() => {
        this.loadAll();
        this.toastService.success('Região desativada com sucesso!');
      }),
      catchError(err => {
        this.toastService.error('Erro ao desativar região.');
        return throwError(err);
      })
    );
  }

  existsByName(name: string): Observable<{ exists: boolean }> {
    return this.http.get<{ exists: boolean }>(`${this.apiUrl}/exists-by-name`, { params: { name } });
  }

  export(): Observable<Blob> {
    return this.http.get(`${this.apiUrl}/export`, { responseType: 'blob' }).pipe(
      tap(() => this.toastService.success('Exportação concluída!')),
      catchError(err => {
        this.toastService.error('Erro ao exportar regiões.');
        return throwError(err);
      })
    );
  }
}
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { environment } from '../../../environments/environment';
import { ToastService } from '../toast/toast.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private readonly apiUrl = `${environment.apiUrl}/api/auth`;

  private _authenticated$ = new BehaviorSubject<boolean>(false);
  authenticated$ = this._authenticated$.asObservable();

  private _username$ = new BehaviorSubject<string>(null);
  username$ = this._username$.asObservable();

  get isAuthenticated(): boolean {
    return this._authenticated$.value;
  }

  constructor(private http: HttpClient, private toastService: ToastService) {}

  login(username: string, password: string): Observable<any> {
    return this.http.post(`${this.apiUrl}/login`, { username, password }).pipe(
      tap(() => {
        this._authenticated$.next(true);
        this._username$.next(username);
      })
    );
  }

  logout(): Observable<any> {
    return this.http.post(`${this.apiUrl}/logout`, {}).pipe(
      tap(() => {
        this.clearSession();
        this.toastService.info('Você foi desconectado.');
      }),
      catchError(err => {
        this.clearSession();
        this.toastService.info('Você foi desconectado.');
        return throwError(err);
      })
    );
  }

  refresh(): Observable<any> {
    return this.http.post(`${this.apiUrl}/refresh`, {});
  }

  me(): Observable<{ username: string }> {
    return this.http.get<{ username: string }>(`${this.apiUrl}/me`).pipe(
      tap(res => {
        this._authenticated$.next(true);
        this._username$.next(res.username);
      })
    );
  }

  checkSession(): void {
    this.me().subscribe({
      error: () => this.clearSession()
    });
  }

  private clearSession(): void {
    this._authenticated$.next(false);
    this._username$.next(null);
  }
}

import {
  HttpErrorResponse,
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, filter, switchMap, take } from 'rxjs/operators';
import { AuthService } from './auth.service';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  private isRefreshing = false;
  private refreshDone$ = new BehaviorSubject<boolean>(false);

  constructor(private authService: AuthService, private router: Router) {}

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const credReq = req.clone({ withCredentials: true });

    return next.handle(credReq).pipe(
      catchError((error: HttpErrorResponse) => {
        if (error.status !== 401 || this.isAuthUrl(req.url)) {
          return throwError(error);
        }

        if (this.isRefreshing) {
          return this.refreshDone$.pipe(
            filter(done => done),
            take(1),
            switchMap(() => next.handle(credReq))
          );
        }

        this.isRefreshing = true;
        this.refreshDone$.next(false);

        return this.authService.refresh().pipe(
          switchMap(() => {
            this.isRefreshing = false;
            this.refreshDone$.next(true);
            return next.handle(credReq);
          }),
          catchError(refreshError => {
            this.isRefreshing = false;
            this.refreshDone$.next(true);
            this.router.navigate(['/login']);
            return throwError(refreshError);
          })
        );
      })
    );
  }

  private isAuthUrl(url: string): boolean {
    return url.includes('/api/auth/login') ||
           url.includes('/api/auth/refresh');
  }
}

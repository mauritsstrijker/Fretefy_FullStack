import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

export interface Toast {
  id: number;
  message: string;
  type: 'success' | 'error' | 'info';
}

@Injectable({
  providedIn: 'root'
})
export class ToastService {
  private _toasts$ = new BehaviorSubject<Toast[]>([]);
  toasts$ = this._toasts$.asObservable();

  private counter = 0;

  success(message: string): void {
    this.show(message, 'success');
  }

  error(message: string): void {
    this.show(message, 'error');
  }

  info(message: string): void {
    this.show(message, 'info');
  }

  private show(message: string, type: Toast['type']): void {
    const id = ++this.counter;
    const toast: Toast = { id, message, type };
    this._toasts$.next([...this._toasts$.value, toast]);

    setTimeout(() => this.remove(id), 4000);
  }

  remove(id: number): void {
    this._toasts$.next(this._toasts$.value.filter(t => t.id !== id));
  }
}

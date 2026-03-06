import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Toast, ToastService } from './toast.service';

@Component({
  selector: 'app-toast',
  templateUrl: './toast.component.html',
  styleUrls: ['./toast.component.scss']
})
export class ToastComponent {
  toasts$: Observable<Toast[]>;

  constructor(private toastService: ToastService) {
    this.toasts$ = this.toastService.toasts$;
  }

  close(id: number): void {
    this.toastService.remove(id);
  }
}

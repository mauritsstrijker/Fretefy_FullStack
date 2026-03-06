import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../../shared/auth/auth.service';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent {
  authenticated$: Observable<boolean>;
  username$: Observable<string>;

  constructor(private authService: AuthService, private router: Router) {
    this.authenticated$ = this.authService.authenticated$;
    this.username$ = this.authService.username$;
  }

  logout(): void {
    this.authService.logout().subscribe(
      () => this.router.navigate(['/login']),
      () => this.router.navigate(['/login'])
    );
  }
}

import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../shared/auth/auth.service';
import { ToastService } from '../../shared/toast/toast.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  form: FormGroup;
  loading = false;
  error = '';

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router,
    private toastService: ToastService
  ) {
    this.form = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  onSubmit(): void {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      this.error = 'Preencha todos os campos.';
      return;
    }

    this.loading = true;
    this.error = '';

    const { username, password } = this.form.value;
    this.authService.login(username, password).subscribe(
      () => {
        this.toastService.success('Login realizado com sucesso!');
        this.router.navigate(['/home']);
      },
      () => {
        this.error = 'Usuário ou senha inválidos.';
        this.loading = false;
      }
    );
  }
}

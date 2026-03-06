import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { RegiaoForm } from '../../models/regiao-form.model';
import { RegiaoService } from '../../services/regiao.service';

@Component({
  selector: 'app-regiao-create',
  templateUrl: './regiao-create.component.html',
  styleUrls: ['./regiao-create.component.scss']
})
export class RegiaoCreateComponent {
  constructor(
    private regiaoService: RegiaoService,
    private router: Router
  ) {}

  onSubmitted(request: RegiaoForm): void {
    this.regiaoService.create(request).subscribe(() =>
      this.router.navigate(['/regiao'])
    );
  }

  onCancelled(): void {
    this.router.navigate(['/regiao']);
  }
}
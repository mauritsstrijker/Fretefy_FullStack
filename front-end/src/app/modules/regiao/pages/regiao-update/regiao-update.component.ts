import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RegiaoForm } from '../../models/regiao-form.model';
import { Regiao } from '../../models/regiao.model';
import { RegiaoService } from '../../services/regiao.service';

@Component({
  selector: 'app-regiao-update',
  templateUrl: './regiao-update.component.html',
  styleUrls: ['./regiao-update.component.scss']
})
export class RegiaoUpdateComponent implements OnInit {
  regiao: Regiao;

  constructor(
    private regiaoService: RegiaoService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.regiaoService.getById(id).subscribe(regiao => this.regiao = regiao);
  }

  onSubmitted(request: RegiaoForm): void {
    this.regiaoService.update(this.regiao.id, request).subscribe(() =>
      this.router.navigate(['/regiao'])
    );
  }

  onCancelled(): void {
    this.router.navigate(['/regiao']);
  }
}
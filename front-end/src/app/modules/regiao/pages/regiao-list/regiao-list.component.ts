import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Regiao } from '../../models/regiao.model';
import { RegiaoService } from '../../services/regiao.service';

@Component({
  selector: 'app-regiao-list',
  templateUrl: './regiao-list.component.html',
  styleUrls: ['./regiao-list.component.scss']
})
export class RegiaoListComponent implements OnInit {
  regioes$: Observable<Regiao[]>;

  constructor(private regiaoService: RegiaoService) {}

  ngOnInit(): void {
    this.regioes$ = this.regiaoService.regioes$;
    this.regiaoService.loadAll();
  }

  activate(id: string): void {
    this.regiaoService.activate(id).subscribe();
  }

  deactivate(id: string): void {
    this.regiaoService.deactivate(id).subscribe();
  }

  export(): void {
    this.regiaoService.export().subscribe(blob => {
      const url = window.URL.createObjectURL(blob);
      const a = document.createElement('a');
      a.href = url;
      a.download = `regioes_${new Date().toISOString().slice(0, 10)}.xlsx`;
      a.click();
      window.URL.revokeObjectURL(url);
    });
  }
}
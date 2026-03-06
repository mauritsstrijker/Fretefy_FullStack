import { Pipe, PipeTransform } from '@angular/core';
import { Cidade } from '../models/cidade.model';

@Pipe({ name: 'cidadesFormat' })
export class CidadesFormatPipe implements PipeTransform {
  transform(cidades: Cidade[]): string {
    if (!cidades?.length) return '-';
    return cidades.map(c => `${c.nome} / ${c.uf}`).join(', ');
  }
}
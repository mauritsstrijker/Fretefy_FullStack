import { Component, Input, OnInit, forwardRef } from '@angular/core';
import { ControlValueAccessor, FormControl, NG_VALUE_ACCESSOR } from '@angular/forms';
import { Cidade } from '../../models/cidade.model';
import { CidadeService } from '../../services/cidade.service';

@Component({
  selector: 'app-cidade-seletor',
  templateUrl: './cidade-seletor.component.html',
  styleUrls: ['./cidade-seletor.component.scss'],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => CidadeSeletorComponent),
      multi: true
    }
  ]
})
export class CidadeSeletorComponent implements OnInit, ControlValueAccessor {
  @Input() excludeIds: string[] = [];

  cidades: Cidade[] = [];
  control = new FormControl(null);

  get cidadesFiltradas(): Cidade[] {
    const currentValue = this.control.value;
    return this.cidades.filter(c => c.id === currentValue || !this.excludeIds.includes(c.id));
  }

  private onChange: (value: string) => void = () => {};
  private onTouched: () => void = () => {};

  constructor(private cidadeService: CidadeService) {}

  ngOnInit(): void {
    this.cidadeService.list().subscribe(cidades => this.cidades = cidades);
    this.control.valueChanges.subscribe(value => {
      this.onChange(value);
      this.onTouched();
    });
  }

  writeValue(value: string): void {
    this.control.setValue(value, { emitEvent: false });
  }

  registerOnChange(fn: (value: string) => void): void {
    this.onChange = fn;
  }

  registerOnTouched(fn: () => void): void {
    this.onTouched = fn;
  }

  setDisabledState(isDisabled: boolean): void {
    isDisabled ? this.control.disable() : this.control.enable();
  }
}
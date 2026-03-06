import { Component, EventEmitter, Input, OnChanges, OnInit, Output } from '@angular/core';
import { AbstractControl, FormArray, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { Observable, of } from 'rxjs';
import { debounceTime, map, switchMap } from 'rxjs/operators';
import { RegiaoForm } from '../../models/regiao-form.model';
import { Regiao } from '../../models/regiao.model';
import { RegiaoService } from '../../services/regiao.service';

@Component({
  selector: 'app-regiao-form',
  templateUrl: './regiao-form.component.html',
  styleUrls: ['./regiao-form.component.scss']
})
export class RegiaoFormComponent implements OnInit, OnChanges {
  @Input() regiao?: Regiao;
  @Output() submitted = new EventEmitter<RegiaoForm>();
  @Output() cancelled = new EventEmitter<void>();

  form: FormGroup;

  constructor(private regiaoService: RegiaoService) {}

  ngOnInit(): void {
    this.buildForm();
  }

  ngOnChanges(): void {
    if (this.form && this.regiao) {
      this.preencherForm();
    }
  }

  get cidades(): FormArray {
    return this.form.get('cityIds') as FormArray;
  }

  get selectedCityIds(): string[] {
    return this.cidades.controls
      .map(c => c.value)
      .filter(v => v != null);
  }

  getExcludeIds(index: number): string[] {
    return this.cidades.controls
      .filter((_, i) => i !== index)
      .map(c => c.value)
      .filter(v => v != null);
  }

  addCidade(): void {
    this.cidades.push(new FormControl(null, Validators.required));
  }

  removeCidade(index: number): void {
    this.cidades.removeAt(index);
  }

  onSubmit(): void {
    if (this.form.invalid) return;
    this.submitted.emit(this.form.value);
  }

  onCancel(): void {
    this.cancelled.emit();
  }

  private buildForm(): void {
    this.form = new FormGroup({
      name: new FormControl('', {
        validators: [Validators.required],
        asyncValidators: [this.nameExistsValidator()],
      }),
      cityIds: new FormArray([], [Validators.required, Validators.minLength(1), this.noDuplicateCitiesValidator()])
    });

    if (this.regiao) {
      this.preencherForm();
    }
  }

  private preencherForm(): void {
    this.form.patchValue({ name: this.regiao.nome });
    this.regiao.cidades.forEach(c => {
      this.cidades.push(new FormControl(c.id, Validators.required));
    });
  }

  private noDuplicateCitiesValidator() {
    return (formArray: AbstractControl): ValidationErrors | null => {
      const values = (formArray as FormArray).controls
        .map(c => c.value)
        .filter(v => v != null);
      const hasDuplicates = new Set(values).size !== values.length;
      return hasDuplicates ? { duplicateCities: true } : null;
    };
  }

  private nameExistsValidator() {
    return (control: AbstractControl): Observable<ValidationErrors | null> => {
      if (!control.value || control.value === this.regiao?.nome)
        return of(null);

      return of(control.value).pipe(
        debounceTime(400),
        switchMap(name => this.regiaoService.existsByName(name)),
        map(({ exists }) => exists ? { nameExists: true } : null)
      );
    };
  }
}
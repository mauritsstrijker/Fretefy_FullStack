import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { CidadeSeletorComponent } from './components/cidade-seletor/cidade-seletor.component';
import { RegiaoFormComponent } from './components/regiao-form/regiao-form.component';
import { RegiaoCreateComponent } from './pages/regiao-create/regiao-create.component';
import { RegiaoListComponent } from './pages/regiao-list/regiao-list.component';
import { RegiaoUpdateComponent } from './pages/regiao-update/regiao-update.component';
import { CidadesFormatPipe } from './pipes/cidades-format.pipe';
import { RegiaoRoutingModule } from './regiao.routing';

@NgModule({
  imports: [
    CommonModule,
    ReactiveFormsModule,
    RegiaoRoutingModule
  ],
  declarations: [
    RegiaoListComponent,
    RegiaoCreateComponent,
    RegiaoUpdateComponent,
    RegiaoFormComponent,
    CidadeSeletorComponent,
    CidadesFormatPipe
  ]
})
export class RegiaoModule { }
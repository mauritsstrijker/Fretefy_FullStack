import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegiaoCreateComponent } from './pages/regiao-create/regiao-create.component';
import { RegiaoListComponent } from './pages/regiao-list/regiao-list.component';
import { RegiaoUpdateComponent } from './pages/regiao-update/regiao-update.component';
const routes: Routes = [
  { path: '', component: RegiaoListComponent },
  { path: 'novo', component: RegiaoCreateComponent },
  { path: ':id/editar', component: RegiaoUpdateComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RegiaoRoutingModule {}
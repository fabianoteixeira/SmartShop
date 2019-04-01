import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CategoryListComponent } from './pages/category/category-list/category-list.component';

const routes: Routes = [
  {
    path: 'categories', loadChildren: './pages/category/category.module#CategoryModule'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

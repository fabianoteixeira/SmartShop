import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryFormComponent } from 'src/app/pages/category/category-form/category-form.component';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';

@NgModule({
  declarations: [CategoryFormComponent, NavBarComponent],
  imports: [
    CommonModule
  ],
  exports: [
    CategoryFormComponent,
    NavBarComponent
  ]
})
export class CoreModule { }

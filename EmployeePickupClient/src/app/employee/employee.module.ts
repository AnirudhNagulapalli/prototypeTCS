import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { EmployeeListComponent } from './employee-list/employee-list.component';

 
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild([
        { path: 'list', component: EmployeeListComponent }
    ])
  ],
  declarations: [EmployeeListComponent]
})
export class EmployeeModule { }
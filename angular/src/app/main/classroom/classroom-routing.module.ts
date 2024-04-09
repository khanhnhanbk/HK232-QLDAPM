import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ClassroomComponent } from './classroom.component';

@NgModule({
  imports: [
    RouterModule.forChild([
      {
        path: '',
        component: ClassroomComponent,
        pathMatch: 'full',
      },
    ]),
  ],

  exports: [RouterModule],
})
export class ClassroomRoutingModule { }

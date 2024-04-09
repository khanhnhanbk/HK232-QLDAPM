import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClassroomRoutingModule } from './classroom-routing.module';
import { ClassroomComponent } from './classroom.component';
import { AdminSharedModule } from '@app/admin/shared/admin-shared.module';
import { AppSharedModule } from '@app/shared/app-shared.module';
import { CreateOrEditClassroomModalComponent } from './create-or-edit-modal.component';



@NgModule({
  declarations: [ClassroomComponent, CreateOrEditClassroomModalComponent],
  imports: [
    CommonModule,
    ClassroomRoutingModule,
    AppSharedModule, AdminSharedModule,
  ]
})
export class ClassroomModule { }

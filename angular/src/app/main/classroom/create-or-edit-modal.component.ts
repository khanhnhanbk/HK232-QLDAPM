import { Component, EventEmitter, Injector, Output, ViewChild, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import {
  ClassroomServiceProxy,
  ClassroomListDto,
  CreateClassroomInput,
} from '@shared/service-proxies/service-proxies';
import { ModalDirective } from 'ngx-bootstrap/modal';

import { map as _map, filter as _filter } from 'lodash-es';

@Component({
  selector: 'createOrEditClassroomModal',
  templateUrl: './create-or-edit-modal.component.html',
  encapsulation: ViewEncapsulation.None,
})
export class CreateOrEditClassroomModalComponent extends AppComponentBase {
  @ViewChild('createOrEditModal', { static: true }) modal: ModalDirective;
  @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

  classroom: ClassroomListDto;
  active = false;
  saving = false;

  constructor(
    injector: Injector,
    private _classroomService: ClassroomServiceProxy
  ) {
    super(injector);
  }

  show(classId?: number): void {
    if (!classId) {
      this.active = true;

    }

    this._classroomService.getClassroomById(classId).subscribe((result) => {
      this.classroom = result
      console.log(this.classroom)
      this.modal.show();
    });




  }


  save(): void {
    let input = this.classroom;

    if (!input.id) {
      this._classroomService.createClassroom(input).subscribe(() => {
        this.saving = false;
        this.notify.info(this.l('SavedSuccessfully'));
        this.close();
        this.modalSave.emit(null);
      });
    }

    else {
      this._classroomService.editClassroom(input).subscribe(() => {
        this.saving = false;
        this.notify.info(this.l('SavedSuccessfully'));
        this.close();
        this.modalSave.emit(null);
      });
    }



  }

  close(): void {
    this.active = false;
    this.modal.hide();
  }


}

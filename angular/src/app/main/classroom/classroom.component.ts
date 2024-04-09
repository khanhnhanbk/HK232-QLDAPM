import { AfterViewInit, Component, Injector } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ClassroomListDto, ClassroomServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.css'],
  animations: [appModuleAnimation()]
})
export class ClassroomComponent extends AppComponentBase implements AfterViewInit {

  classroomList: ClassroomListDto[] = [];

  constructor(
    injector: Injector,
    private _classroomService: ClassroomServiceProxy
  ) {
    super(injector);
  }

  ngAfterViewInit(): void {
    this.getClassroomList();
  }

  getClassroomList() {
    this._classroomService.getClassroom("")
      .subscribe(result => {
        this.classroomList = result.items
      });
  }
  createClassroom() {

  }
}

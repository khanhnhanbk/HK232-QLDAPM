import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

@NgModule({
  imports: [
    RouterModule.forChild([
      {
        path: '',
        children: [
          {
            path: 'dashboard',
            loadChildren: () => import('./dashboard/dashboard.module').then((m) => m.DashboardModule),
            data: { permission: 'Pages.Tenant.Dashboard' },
          },
          {
            path: 'classroom',
            loadChildren: () => import('./classroom/classroom.module').then((m) => m.ClassroomModule),
            data: { permission: 'Pages.Tenant.Classroom' },
          },
          { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
          { path: '**', redirectTo: 'dashboard' },
        ],
      },
    ]),
  ],
  exports: [RouterModule],
})
export class MainRoutingModule { }

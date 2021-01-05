import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { NetflixDashboardContainerComponent } from './containers/netflix-dashboard-container/netflix-dashboard-container.component';

const routes: Routes = [
  {
    path: '',
    component: NetflixDashboardContainerComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class NetflixNgLibRoutingModule {}

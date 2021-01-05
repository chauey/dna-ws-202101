import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NetflixDashboardContainerComponent } from './containers/netflix-dashboard-container/netflix-dashboard-container.component';
import { NetflixNgLibRoutingModule } from './netflix-ng-lib-routing.module';

@NgModule({
  imports: [CommonModule, NetflixNgLibRoutingModule],
  declarations: [NetflixDashboardContainerComponent],
  // exports: [NetflixDashboardContainerComponent]
})
export class NetflixNgLibModule {}

import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { ShowRoutingModule } from './show-routing.module';
import { ShowComponent } from './show.component';


@NgModule({
  declarations: [ShowComponent],
  imports: [
    ShowRoutingModule, SharedModule
  ]
})
export class ShowModule { }
